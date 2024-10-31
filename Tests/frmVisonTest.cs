using DVLD.Appointments;
using DVLD_Business.Appointments;
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
    public partial class frmVisonTest : Form
    {
        private int _LDLAppID = -1;
        public frmVisonTest(int LDLAppID)
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseAppInfo1.FillData(LDLAppID);
            _LDLAppID = LDLAppID;
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
            frmAddAppointment frm = new frmAddAppointment(_LDLAppID, frmAddAppointment.enMode.TakeTest) ;
            frm.ShowDialog();
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
                }
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int appID =int.Parse( dataGridView1.SelectedRows[0].Cells["AppointmentID"].Value.ToString());

        }

        private void editAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int appID = int.Parse(dataGridView1.SelectedRows[0].Cells["AppointmentID"].Value.ToString());

        }
    }
}
