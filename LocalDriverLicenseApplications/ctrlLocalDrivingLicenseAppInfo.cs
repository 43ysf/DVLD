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
    public partial class ctrlLocalDrivingLicenseAppInfo : UserControl
    {
        public ctrlLocalDrivingLicenseAppInfo()
        {
            InitializeComponent();
        }



        public void FillData(int LocalDrivingLicenseAppID)
        {
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseAppID);
            ctrlApplicationBasicInfo1.FillData(LDLApp.ApplicationID);
            ctrlDrivinLicenseApplicationInfo1.FillData(LocalDrivingLicenseAppID);
        }

    }
}
