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
    public partial class frmListDrivingLicenseApplications : Form
    {
        public frmListDrivingLicenseApplications()
        {
            InitializeComponent();
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
            DataTable dataTable = clsTestType.GetAllTestTypes();
            dgvListLicenseApplications.Columns.Add("ID", "ID");
            dgvListLicenseApplications.Columns.Add("Title", "Title");
            dgvListLicenseApplications.Columns.Add("Discription", "Title");
        }

        private void schdualTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
