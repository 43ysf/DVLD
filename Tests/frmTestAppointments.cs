using DVLD.Appointments;
using DVLD_Business.Appointments;
using DVLD_Business.LocalDrivingLicenseApplications;
using DVLD_Business.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests
{
    public partial class frmTestAppointments : Form
    {
        public enum enMode {enVisonTest = 1, enWrttenTest = 2, enStreetTest = 3};
        public enMode Mode;
        private clsLocalDrivingLicenseApplication _LDLApp = null;
        private int _AppointmentID = -1;
        int _TestTypeID = -1;
        frmAddAppointments.enTestAppointmentType TestTypeAppointment;

        public frmTestAppointments(enMode mode, int LDLAppID)
        {
            InitializeComponent();
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            Mode = mode;
            ctrlLocalDrivingLicenseAppInfo1.FillData(LDLAppID);
            _TestTypeID = Mode == enMode.enVisonTest ? 1 : Mode == enMode.enWrttenTest ? 2 : 3;
            TestTypeAppointment = Mode == enMode.enVisonTest ? frmAddAppointments.enTestAppointmentType.VisionTest : Mode == enMode.enWrttenTest ? frmAddAppointments.enTestAppointmentType.WrittenTest : frmAddAppointments.enTestAppointmentType.StreetTest;


            _FilData();
            _FillDataGridView();
        }

        private void _FilData()
        {
            switch(Mode)
            {
                case enMode.enVisonTest:
                    pbTestIcon.Image = Properties.Resources.Vision_512;
                    lbTitle.Text = "Vison Test Appointments";
                    break;
                case enMode.enWrttenTest:
                    pbTestIcon.Image = Properties.Resources.Written_Test_512;
                    lbTitle.Text = "Written Test Appointments";
                    break;
                case enMode.enStreetTest:
                    pbTestIcon.Image = Properties.Resources.driving_test_512;
                    lbTitle.Text = "Street Test Appointments";
                    break;
            }
        }
        private void _FillDataGridView()
        {
            //_TestTypeID = Mode == enMode.enVisonTest ? 1 : Mode == enMode.enWrttenTest ? 2 : 3;
            DataTable dt = clsAppointment.GettAllAppointments(_LDLApp.LocalDrivingLicenseApplicationID, _TestTypeID);
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("AppointmentID", "AppointmentID");
            dataGridView1.Columns.Add("AppointmentDate", "AppointmentDate");
            dataGridView1.Columns.Add("PaidFees", "PaidFees");
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.HeaderText = "IsChecked";
            col.Name = "IsChecked";
            dataGridView1.Columns.Add(col);
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row["TestAppointmentID"], row["AppointmentDate"], row["PaidFees"], row["IsLocked"]);
            }
            lblRecods.Text = dt.Rows.Count.ToString(); 


        }
        private void btnAddAppointments_Click(object sender, EventArgs e)
        {
            DataTable dt = clsAppointment.GettAllAppointments(_LDLApp.LocalDrivingLicenseApplicationID, _TestTypeID);

            if(dt.Rows.Count > 0)
            {

                if (clsAppointment.IsThereAppointmentNotChecked(_LDLApp.LocalDrivingLicenseApplicationID, _TestTypeID))
                {
                    MessageBox.Show("There is active appointment");
                    return;
                }
       
                int AppointID = -1;
                foreach (DataRow dr in dt.Rows)
                {
                    AppointID =(int) dr["TestAppointmentID"];
                    if(clsTest.IsTestDone(AppointID))
                    {
                        MessageBox.Show("This Person already passed this test");
                        return;
                    }
                
                }

                frmAddAppointments frm = new frmAddAppointments(_LDLApp.LocalDrivingLicenseApplicationID, frmAddAppointments.enMode.RetakeTest, TestTypeAppointment);
                frm.ShowDialog();
                _FillDataGridView();

            }
            else
            {

                frmAddAppointments frm = new frmAddAppointments(_LDLApp.LocalDrivingLicenseApplicationID, frmAddAppointments.enMode.AddNew, TestTypeAppointment);
                frm.ShowDialog();
                _FillDataGridView();

            }


            _FillDataGridView();


        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo HitInfo = dataGridView1.HitTest(e.X, e.Y);
                if (HitInfo.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[HitInfo.RowIndex].Selected = true;
                    _AppointmentID = int.Parse(dataGridView1.SelectedRows[0].Cells["AppointmentID"].Value.ToString());
                    contextMenuStrip1.Show(dataGridView1, e.Location);

                }

            }
        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsAppointment appointment = clsAppointment.Find(_AppointmentID);
            if(appointment.IsLocked)
            {
                MessageBox.Show("This appointment Taken already");
                return;
            }
            frmTakeTest.enMod mode = (Mode == enMode.enVisonTest) ? frmTakeTest.enMod.VisionTest : (Mode == enMode.enWrttenTest) ? frmTakeTest.enMod.WrittenTest : frmTakeTest.enMod.StreetTest;
            frmTakeTest frm = new frmTakeTest(_AppointmentID, mode);
            frm.ShowDialog();
            _FillDataGridView();
        }
    }
}
