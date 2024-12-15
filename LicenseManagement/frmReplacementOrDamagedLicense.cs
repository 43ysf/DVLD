using DVLD_Business.Applications;
using DVLD_Business.ApplicationTypes;
using DVLD_Business.LicenseClasses;
using DVLD_Business.Licenses;
using DVLD_Business.LocalDrivingLicenseApplications;
using DVLD_Business.Users;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.LicenseManagement
{
    public partial class frmReplacementOrDamagedLicense : Form
    {
        private int _LicenseID = -1;
        private clsLicense _OldLicense = null;
        private clsLicense _NewLicense = new clsLicense();
        private clsApplication _App = new clsApplication();

        
        public frmReplacementOrDamagedLicense()
        {
            InitializeComponent();
        }



        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            lbTitle.Text = rbDamaged.Checked ? "Replacement For Damaged License" : "Replacement For Lost License";

        }

        public void ApplicationData()
        {

            _App.CreatedBy = clsCurrentUserInfo.CurrentUserID;
            _App.ApplicationPersonID = _OldLicense.Driver.PersonID;
            _App.ApplicationDate = DateTime.Now;
            _App.ApplicationType = rbDamaged.Checked ? 4 : 3;
            _App.ApplicationStatus = 3;
            _App.LastStatusDate = DateTime.Now;
            _App.PaidFees = clsApplicationType.Find(rbDamaged.Checked ? 4 : 3).ApplicationFees;
        }
        public void FillData()
        {
            lblApplicationDate.Text = _App.ApplicationDate.ToString();
            lblCreatedBy.Text = clsUser.Find(clsCurrentUserInfo.CurrentUserID).UserName;
            lblExpartaionDate.Text = _App.ApplicationDate.AddYears(10).ToShortDateString();
            lblFees.Text = _App.PaidFees.ToString();
            lblLicenseFees.Text = clsLicenseClass.Find(_OldLicense.LicenseClass).ClassFees.ToString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblTotalFees.Text = (_App.PaidFees + clsLicenseClass.Find(_OldLicense.LicenseClass).ClassFees).ToString();
            lblOldLicense.Text = _OldLicense != null ? _OldLicense.LicenseID.ToString() : "????";

            _NewLicense = new clsLicense();
            _NewLicense.Notes = _OldLicense.Notes;
            _NewLicense.IssueDate = _OldLicense.IssueDate;
            _NewLicense.ExpirationDate = _OldLicense.ExpirationDate;
            _NewLicense.CreatedByUserID = clsCurrentUserInfo.CurrentUserID;
            _NewLicense.Driver = _OldLicense.Driver;
            _NewLicense.DriverID = _OldLicense.DriverID;
            _NewLicense.IssueReason = rbDamaged.Checked ? 4 : 3;
            _NewLicense.PaidFees = Convert.ToDecimal(clsLicenseClass.Find(_OldLicense.LicenseClass).ClassFees);
            _NewLicense.LicenseClass = _OldLicense.LicenseClass;
           _NewLicense.IsActive = true; 
            
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            _LicenseID = Convert.ToInt32(txtSearch.Text.Trim());
            if(clsLicense.IsLicenseExist(_LicenseID))
            {
                ctrlDriverLicenseInfo1.LoadDataByLicenseID(_LicenseID);
                _OldLicense = clsLicense.Find(_LicenseID);
                if(!_OldLicense.IsActive)
                {
                    MessageBox.Show("This license is not active !!!");
                    btnIssue.Enabled = false;
                    return;
                }
                else
                {
                    btnIssue.Enabled = true;
                    ApplicationData();
                    FillData();
                }

            }
            else
            {
                MessageBox.Show("License not exist in system ");
            }
        
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_App.Save())
            {
                _NewLicense.ApplicationID = _App.ApplicationID;
                if(_NewLicense.Save())
                {
                    clsLocalDrivingLicenseApplication NewDrL = new clsLocalDrivingLicenseApplication();
                    NewDrL.LicenseClassID = _NewLicense.LicenseClass;
                    NewDrL.ApplicationID = _App.ApplicationID;
                    if(NewDrL._AddNew())
                    {
                        _OldLicense.IsActive = false;
                        if(_OldLicense.Save()) 
                            MessageBox.Show($"Successfully New LicenseID = {_NewLicense.PaidFees}");
                    }
                }
            }
        }
    }
}
