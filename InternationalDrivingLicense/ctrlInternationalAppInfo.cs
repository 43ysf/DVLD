using DVLD_Business.ApplicationTypes;
using DVLD_Business.InternationalLicenses;
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
    public partial class ctrlInternationalAppInfo : UserControl
    {
        clsInternationalLicense _License = null;
        public ctrlInternationalAppInfo()
        {
            InitializeComponent();
        }

        private void ctrlInternationalAppInfo_Load(object sender, EventArgs e)
        {

        }

        public void LoadData(int LocalDrivingLicenseID)
        {

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblExpartaionDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblFees.Text = clsApplicationType.Find(6).ApplicationFees.ToString();
            lblLocackLicenseID.Text  = LocalDrivingLicenseID.ToString();
            lblCreatedBy.Text = clsCurrentUserInfo.CurrentUserID.ToString();
            
        }


    }
}
