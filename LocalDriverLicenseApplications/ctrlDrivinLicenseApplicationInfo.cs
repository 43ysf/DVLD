using DVLD_Business.LicenseClasses;
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

namespace DVLD.LocalDriverLicenseApplications
{
    public partial class ctrlDrivinLicenseApplicationInfo : UserControl
    {
        public ctrlDrivinLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void FillData(int DLAppID)
        {
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.Find(DLAppID);
            lblClassName.Text = clsLicenseClass.Find(LDLApp.LicenseClassID).LicenseClassName;
            lblDLAppID.Text = DLAppID.ToString() ;
            lblPassedTests.Text = LDLApp.GetPassedTest().ToString();
        }

    }
}
