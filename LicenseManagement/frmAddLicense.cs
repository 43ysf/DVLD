using DVLD_Business.Applications;
using DVLD_Business.Drivers;
using DVLD_Business.Licenses;
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

namespace DVLD.LicenseManagement
{

    public partial class frmAddLicense : Form
    {
        int _LDLAppID = -1;
        clsApplication app = null;
        clsLocalDrivingLicenseApplication _LDLApp = null;
        clsDriver driver = null;
        public frmAddLicense(int LDLApp)
        {
            InitializeComponent();
            _LDLAppID  = LDLApp; 
            ctrlLocalDrivingLicenseAppInfo1.FillData(_LDLAppID);
            _LDLApp = clsLocalDrivingLicenseApplication.Find(_LDLAppID);
            app = clsApplication.Find(_LDLApp.ApplicationID);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

            if (_LDLApp.GetPassedTest() == 3)
            {
                if(!clsDriver.IsPersonDriver(app.ApplicationPersonID))
                {
                    driver = new clsDriver();
                    driver.PersonID = clsApplication.Find(_LDLApp.ApplicationID).ApplicationPersonID;
                    driver.CreatedByUserID = clsCurrentUserInfo.CurrentUserID;
                    driver.CreatedDate = DateTime.Now;
                    driver.AddNew();
                }
                else
                {
                    driver = clsDriver.FindByPersonID(app.ApplicationPersonID);
                }

                clsLicense License = new clsLicense();
                License.DriverID = driver.DriverID;
                License.Notes = txtNotes.Text.Trim();
                License.IssueReason = 1;
                License.ApplicationID = _LDLApp.ApplicationID;
                License.CreatedByUserID= clsCurrentUserInfo.CurrentUserID;
                License.IsActive = true;    
                License.IssueDate = DateTime.Now;
                License.ExpirationDate = License.IssueDate.AddYears(10);
                License.PaidFees = Convert.ToDecimal(app.PaidFees);
                License.LicenseClass = _LDLApp.LicenseClassID;

                if(License.Save())
                {
                    app.ApplicationStatus = 3;
                    app.UpdateLastStatus();
                    MessageBox.Show("License Add Successfully");
                }


                
            }

        }
    }
}
