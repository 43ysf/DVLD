using DVLD.LocalDriverLicenseApplications;
using DVLD_Business.Applications;
using DVLD_Business.LocalDrivingLicenseApplications;
using DVLD_Business.Manage_Test_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.DriverLicenseApplications
{
    public partial class frmListLocalDrivingLicenseApplications : Form
    {
        public frmListLocalDrivingLicenseApplications()
        {
            InitializeComponent();
            _FillDataGirdView();
            cbFilterBy.Text = "None";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillDataGirdView()
        {
            dgvListLicenseApplications.Columns.Clear();
            DataTable dataTable = clsLocalDrivingLicenseApplication.GetAll();
            dgvListLicenseApplications.Columns.Add("L.D.LAppID", "L.D.LAppID");
            dgvListLicenseApplications.Columns.Add("DrivingClass", "Driving Class");
            dgvListLicenseApplications.Columns.Add("NationalNo", "Nationl No");
            dgvListLicenseApplications.Columns.Add("FullName", "Full Name");
            dgvListLicenseApplications.Columns.Add("ApplicationDate", "Application Date");
            dgvListLicenseApplications.Columns.Add("PassedTests", "PassedTests");
            dgvListLicenseApplications.Columns.Add("Status", "Status");
            foreach(DataRow dr in dataTable.Rows)
            {
                dgvListLicenseApplications.Rows.Add(dr["LocalDrivingLicenseApplicationID"], dr["ClassName"], dr["NationalNo"], dr["FullName"], dr["ApplicationDate"], dr["PassedTestCount"], dr["Status"]);
            }
            lblNumberOfRecords.Text = dataTable.Rows.Count.ToString();
        }

        private void schdualTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewLicenseApplication_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingApplication frm  = new frmAddNewLocalDrivingApplication();
            frm.ShowDialog();
            _FillDataGirdView();
        }

        private void _SearchInDataGirdeView(string ColumnName)
        {
            string Value = txtFilter.Text.ToLower().Trim();
            foreach(DataGridViewRow r in dgvListLicenseApplications.Rows)
            {
             
                if (r.Cells[ColumnName].Value != null && r.Cells[ColumnName].Value.ToString().ToLower() == Value)
                {
                    r.Visible = true;
                   // r.Selected = true;
                }
                else
                    r.Visible = false;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Clear();
            txtFilter.Visible = cbFilterBy.Text != "None";
            if(cbFilterBy.Text == "L.D.LAppID")
            {
             txtFilter.KeyPress   += new KeyPressEventHandler(txtFilter_KeyPress);
            }
            else
            {
                txtFilter.KeyPress -= new KeyPressEventHandler(txtFilter_KeyPress);
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // منع الإدخال
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFilter.Text))
            {
                _FillDataGirdView();
                return;
            }
            _SearchInDataGirdeView(cbFilterBy.Text.Trim());
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID =(int) dgvListLicenseApplications.SelectedRows[0].Cells["L.D.LAppID"].Value;
            clsApplication.CancelApplication(clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID).ApplicationID);
            _FillDataGirdView();
            
        }

        private void dgvListLicenseApplications_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var hitPose = dgvListLicenseApplications.HitTest(e.X, e.Y);
                if(hitPose.RowIndex >= 0)
                {
                    dgvListLicenseApplications.ClearSelection();
                    dgvListLicenseApplications.Rows[hitPose.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dgvListLicenseApplications, e.Location);
                    //var cell = dgvListLicenseApplications.SelectedRows[0].Cells["UserID"];
                    //int IDValue = int.Parse(cell.Value.ToString());

                }
            }
        }
    }
}
