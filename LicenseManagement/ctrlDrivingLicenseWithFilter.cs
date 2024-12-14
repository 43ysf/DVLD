using DVLD_Business.Applications;
using DVLD_Business.ApplicationTypes;
using DVLD_Business.InternationalLicenses;
using DVLD_Business.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.LicenseManagement
{
    public partial class ctrlDrivingLicenseWithFilter : UserControl
    {
       public  clsLicense _License = null;
        public ctrlDrivingLicenseWithFilter()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
         
            int LicenseID = Convert.ToInt32(txtSearch.Text.Trim());    
            if(!clsLicense.IsLicenseExist(LicenseID))
            {
                MessageBox.Show("License is not present in the system.");
                return;
            }

            _License = clsLicense.Find(LicenseID);
            ctrlDriverLicenseInfo1.LoadDataByLicenseID(LicenseID);
            LoadData();
            
        }
        public void LoadData()
        {

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblExpartaionDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblFees.Text = clsApplicationType.Find(6).ApplicationFees.ToString();
            lblLocackLicenseID.Text = _License.LicenseID.ToString();
            lblCreatedBy.Text = clsCurrentUserInfo.CurrentUserID.ToString();

        }

        public bool Issue()
        {
            if(!_License.IsActive)
            {
                MessageBox.Show("Driving License not active please enter active driving License");
                return false; 
            }

            if (clsInternationalLicense.IsDriverHasInternationalLicense(_License.DriverID))
            {
                MessageBox.Show("The driver has active License ");
                return false;
            }


   

            clsApplication app = new clsApplication();
            app.ApplicationDate = Convert.ToDateTime(lblApplicationDate.Text);
            app.LastStatusDate = DateTime.Now;
            app.CreatedBy = clsCurrentUserInfo.CurrentUserID;
            app.ApplicationType = 6;
            app.ApplicationPersonID = _License.Driver.PersonID;
            app.PaidFees = clsApplicationType.Find(6).ApplicationFees;
            if(app.Save())
            {
                lblIApplicationID.Text = app.ApplicationID.ToString();
                clsInternationalLicense InternationalLicense = new clsInternationalLicense();   
                InternationalLicense.ApplicationID = app.ApplicationID;
                InternationalLicense.ExpirationDate = Convert.ToDateTime(lblExpartaionDate.Text);
                InternationalLicense.DriverID = _License.DriverID;
                InternationalLicense.IssueDate = DateTime.Now;
                InternationalLicense.CreatedByUserID = clsCurrentUserInfo.CurrentUserID;
                InternationalLicense.IsActive = true;
                InternationalLicense.IssuedUsingLocalLicenseID = _License.LicenseID;
                if(InternationalLicense.AddNew())
                {
                    MessageBox.Show("International License Created Successfully");
                    return true;
                }
                else
                {
                    MessageBox.Show("International License dose not created ");
                    return false;
                }
            }
            MessageBox.Show("Something wrong");
            return false;   
            
        }


    }
}
