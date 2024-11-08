using DVLD.Appointments;
using DVLD_Business.Appointments;
using DVLD_Business.LocalDrivingLicenseApplications;
using DVLD_Business.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests
{
    public partial class frmVisonTest : Form
    {
        private int _LDLAppID = -1;
        int _AppointmentID = -1;
        clsLocalDrivingLicenseApplication application = null;
        clsAppointment TestAppointment = null;
        public frmVisonTest(int LDLAppID)
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseAppInfo1.FillData(LDLAppID);
            _LDLAppID = LDLAppID;
            application = clsLocalDrivingLicenseApplication.Find(LDLAppID);

            FillDataGridViewData();
        }

        public void FillDataGridViewData()
        {
       
            DataTable dt = clsAppointment.GettAllAppointments(_LDLAppID, 1);
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
        }

        private void btnAddAppointments_Click(object sender, EventArgs e)
        {
            DataTable dt = clsAppointment.GettAllAppointments(_LDLAppID, 1);
            if(dt.Rows.Count > 0)
            {

                if (clsAppointment.IsThereAppointmentNotChecked(_LDLAppID, 1))
                {
                    MessageBox.Show("There Is Active Appointment");
                    return;



                }
                else
                {
                    int TestAppointmentID = -1;
                    foreach (DataRow dr in dt.Rows)
                    {
                        TestAppointmentID = (int)dr["TestAppointmentID"];
                        if (clsTest.IsTestDone(TestAppointmentID))
                        {
                            MessageBox.Show("Person Already Passed this Tests");
                            return ;
                        
                        }
                    }
                    frmAddAppointment frm = new frmAddAppointment(_LDLAppID, frmAddAppointment.enMode.RetakeTest) ;
                    frm.ShowDialog();
                }
            }
            else
            {
                frmAddAppointment frm = new frmAddAppointment(_LDLAppID, frmAddAppointment.enMode.TakeTest);
                frm.ShowDialog();
            }

            
          

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo HitInfo = dataGridView1.HitTest(e.X, e.Y) ;
                if(HitInfo.RowIndex >=0)
                {
                    dataGridView1.ClearSelection() ;
                    dataGridView1.Rows[HitInfo.RowIndex].Selected = true ;
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                     _AppointmentID = int.Parse(dataGridView1.SelectedRows[0].Cells["AppointmentID"].Value.ToString());

                }
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest(_AppointmentID, frmTakeTest.enMod.VisionTest);
            frm.ShowDialog();
        }

        private void editAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!clsAppointment.Find(_AppointmentID).IsLocked)
            {
                frmAddAppointment frm = new frmAddAppointment(_AppointmentID);
                frm.ShowDialog();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRecods_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ctrlLocalDrivingLicenseAppInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
