﻿using DVLD_Business.Applications;
using DVLD_Business.ApplicationTypes;
using DVLD_Business.LicenseClasses;
using DVLD_Business.Licenses;
using DVLD_Business.LocalDrivingLicenseApplications;
using DVLD_Business.Users;
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
    public partial class frmRenewLicense : Form
    {
        private clsApplication _App = new clsApplication();
        private clsLicense _OldLicense = null;
        private clsLicense _NewLicense = null;
        public frmRenewLicense()
        {
            InitializeComponent();

            //_OldLicense = clsLicense.Find(LicenseID);
            ctrlFindDriverLicense1.DataBack += GetPersonIDFromctrl;
            //FillData();

        }

        public void ApplicationData()
        {
            _App.CreatedBy = 22;//clsCurrentUserInfo.CurrentUserID;
            _App.ApplicationPersonID = _OldLicense.Driver.PersonID;
            _App.ApplicationDate = DateTime.Now;
            _App.ApplicationType = 2;
            _App.ApplicationStatus = 3;
            _App.LastStatusDate = DateTime.Now;
            _App.PaidFees = clsApplicationType.Find(2).ApplicationFees;
        }
        public void FillData()
        {
            lblApplicationDate.Text = _App.ApplicationDate.ToString();
            lblCreatedBy.Text = clsUser.Find(_App.CreatedBy).UserName;
            lblExpartaionDate.Text = _App.ApplicationDate.AddYears(10).ToShortDateString();
            lblFees.Text = _App.PaidFees.ToString();
            lblLicenseFees.Text = clsLicenseClass.Find(_OldLicense.LicenseClass).ClassFees.ToString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblTotalFees.Text = (_App.PaidFees + clsLicenseClass.Find(_OldLicense.LicenseClass).ClassFees).ToString();
            lblOldLicense.Text = _OldLicense != null ? _OldLicense.LicenseID.ToString() : "????";
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(!_OldLicense.IsActive)
            {
                MessageBox.Show("License Is not Active !!");
                return;
            }
            if(_OldLicense.ExpirationDate >  DateTime.Now)
            {
                MessageBox.Show("Licnese dose not Expired");
                
            }
            _NewLicense = new clsLicense();
            //_NewLicense = _OldLicense;
            _NewLicense.IssueDate = DateTime.Now;
            _NewLicense.ExpirationDate = DateTime.Now.AddYears(10);
            _NewLicense.LicenseID = -1;
            //_NewLicense.Mode = clsLicense.enMode.AddNew;
            _NewLicense.CreatedByUserID = clsCurrentUserInfo.CurrentUserID ;
            _NewLicense.IssueReason = 2;
            _NewLicense.DriverID = _OldLicense.DriverID;
            _NewLicense.Notes = txtNotes.Text;
            _NewLicense.IsActive = true;
            _NewLicense.LicenseClass = _OldLicense.LicenseClass;
            _NewLicense.PaidFees = Convert.ToDecimal(clsLicenseClass.Find(_OldLicense.LicenseClass).ClassFees);
            if(_App.Save())
            {
                _NewLicense.ApplicationID = _App.ApplicationID;
                clsLocalDrivingLicenseApplication newApp = new clsLocalDrivingLicenseApplication();
                newApp.ApplicationID = _App.ApplicationID;
                newApp.LicenseClassID = _NewLicense.LicenseClass;
                if(newApp._AddNew())
                {
                    if(_NewLicense.Save())
                    {
                        lblRenwedLicense.Text =  _NewLicense.LicenseID.ToString();
                        _OldLicense.IsActive = false;
                        if(_OldLicense.Save())
                        {
                            MessageBox.Show("License Updated Successfully");

                        }
                    }
                }

            }


        }

        public void GetPersonIDFromctrl(object obj, int LicenseID)
        {
            _OldLicense = clsLicense.Find(LicenseID);
            if(_OldLicense == null)
            {
                btnIssue.Enabled = false;
                return;
            }
            else
            {
                btnIssue.Enabled = true;
                ApplicationData();
                FillData();
            
                if(_OldLicense.ExpirationDate > DateTime.Now)
                {
                    MessageBox.Show("The License is not Expaired !!");
                    btnIssue.Enabled = false;

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
