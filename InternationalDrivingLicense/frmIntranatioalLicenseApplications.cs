using DVLD.People;
using DVLD_Business.Applications;
using DVLD_Business.InternationalLicenses;
using DVLD_Business.LocalDrivingLicenseApplications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.InternationalDrivingLicense
{
    public partial class frmIntranatioalLicenseApplications : Form
    {
        private clsInternationalLicense _Licnese = null;
        int _LicneseID = -1;
        public frmIntranatioalLicenseApplications()
        {
            InitializeComponent();
            FillData();
        }

        public void FillData()
        {
            DataTable dt = clsInternationalLicense.GetAll();
            dataGridView1.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shwoDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPersonInfo frm = new frmPersonInfo();
            //frm.ShowDialog();   
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitPose = dataGridView1.HitTest(e.X, e.Y);
                if (hitPose.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hitPose.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                    //var cell = dgvListLicenseApplications.SelectedRows[0].Cells["UserID"];
                    //int IDValue = int.Parse(cell.Value.ToString());
                    _LicneseID = int.Parse(dataGridView1.SelectedRows[0].Cells["InterNationalLicenseID"].Value.ToString());
                    //_Licnese = clsInternationalLicense.Find(_LicneseID);

                }
            }

        }
    }
}
