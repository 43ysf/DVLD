using System;
using System.CodeDom;
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
    public partial class frmInternationalDrivingLicense : Form
    {
        public frmInternationalDrivingLicense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(ctrlDrivingLicenseWithFilter1._License == null)
            {
                MessageBox.Show("You should Enter Active License");
                return;
            }
            ctrlDrivingLicenseWithFilter1.Issue();
        }
    }
}
