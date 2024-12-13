using DVLD.DriverLicenseApplications;
using DVLD.InternationalDrivingLicense;
using DVLD.LicenseManagement;
using DVLD.LocalDriverLicenseApplications;
using DVLD.Manage_Test_type;
using DVLD.People;
using DVLD.Users;
using DVLD_Presentation.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new frmAddNewLocalDrivingApplication());
            Application.Run(new frmIntranatioalLicenseApplications());
            //Application.Run(new frmTest());
        }
    }
}
