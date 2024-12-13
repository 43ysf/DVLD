using DVLD_Business.Applications;
using DVLD_Business.Drivers;
using DVLD_Business.LicenseClasses;
using DVLD_Business.Licenses;
using DVLD_Business.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.LicenseManagement
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _ApplicationID = -1;
        private clsApplication _Application = null;
        private clsLicense _License = null;
        private clsDriver _Driver = null;
        private clsPerson _Person = null;
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadData(int ApplicationID)
        {
            _ApplicationID = ApplicationID;
            _Application = clsApplication.Find(_ApplicationID);
            _License = clsLicense.FindByApplicationID(_ApplicationID);
            _Person = clsPerson.Find(_Application.ApplicationPersonID);
            _Driver = clsDriver.Find(_License.DriverID);


            lblName.Text = _Person.FullName;
            lblClass.Text = clsLicenseClass.Find(_License.LicenseClass).LicenseClassName;
            lblNotes.Text = _License.Notes;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblGendor.Text = _Person.Gendor ? "Female" : "Male";
            lblDriverID.Text = _Driver.DriverID.ToString();
            lblIsDetained.Text = "NO";
            lblNationalNo.Text = _Person.NationalNo;
            lblIssueReason.Text = _License.IssueReason == 1 ? "New" : "Update";
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblExpirationDate.Text = _License.ExpirationDate.ToShortDateString();
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblLicenseID.Text = _License.LicenseID.ToString();
            pictureBox1.Image = (!string.IsNullOrEmpty(_Person.ImagePath)) ? Image.FromFile(_Person.ImagePath) : lblGendor.Text == "Male" ? Properties.Resources.Businessman : Properties.Resources.Businesswoman;
               
            
        }

        public void LoadDataByLicenseID(int LicenseID)
        {
            clsLicense license = clsLicense.Find(LicenseID);
            _License = license;
            _Application = clsApplication.Find(_License.ApplicationID);
            _Person = clsPerson.Find(_Application.ApplicationPersonID);
            _Driver = clsDriver.Find(_License.DriverID);

            lblName.Text = _Person.FullName;
            lblClass.Text = clsLicenseClass.Find(_License.LicenseClass).LicenseClassName;
            lblNotes.Text = _License.Notes;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblGendor.Text = _Person.Gendor ? "Female" : "Male";
            lblDriverID.Text = _Driver.DriverID.ToString();
            lblIsDetained.Text = "NO";
            lblNationalNo.Text = _Person.NationalNo;
            lblIssueReason.Text = _License.IssueReason == 1 ? "New" : "Update";
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblExpirationDate.Text = _License.ExpirationDate.ToShortDateString();
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblLicenseID.Text = _License.LicenseID.ToString();
            pictureBox1.Image = (!string.IsNullOrEmpty(_Person.ImagePath)) ? Image.FromFile(_Person.ImagePath) : lblGendor.Text == "Male" ? Properties.Resources.Businessman : Properties.Resources.Businesswoman;

        }

        private void grbDriverLicenseInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
