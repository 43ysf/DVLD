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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

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
                dgvListLicenseApplications.Rows.Add(dr["LocalDrivingLicenseApplicationID"], dr["NationalNo"], dr["ClassName"], dr["FullName"], dr["ApplicationDate"], dr["PassedTestCount"], dr["Status"]);
            }
            lblNumberOfRecords.Text = dataTable.Rows.Count.ToString();
        }

        private void schdualTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
