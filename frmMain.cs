﻿using DVLD.DriverLicenseApplications;
using DVLD.InternationalDrivingLicense;
using DVLD.LicenseManagement;
using DVLD.LocalDriverLicenseApplications;
using DVLD.Manage_Application_Types;
using DVLD.Manage_Test_type;
using DVLD.People;
using DVLD.Users;
using DVLD_Business.Users;
using DVLD_Presentation.Users;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {
        clsUser User = null;
        private frmLoginScreen _LoginSrcren;
        bool CloseForm = false;
        public frmMain(frmLoginScreen loginScreen)
        {
            
            InitializeComponent();
            _LoginSrcren = loginScreen;
            //SystemEvents.PowerModeChanged += OnScreenIsOf;
 
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void msPeople_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            if(e.CloseReason == CloseReason.UserClosing  && !CloseForm)
            {
                Application.Exit();
            }
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btn clicked");
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers frm = new frmManageUsers(User);
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            clsCurrentUserInfo.User = null;
            _LoginSrcren.Show();
            CloseForm = true;
            this.Close();
            
            //frm.ShowDialog();
        }

        private void currentUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginInfo frm = new frmLoginInfo(clsCurrentUserInfo.CurrentUserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsCurrentUserInfo.CurrentUserID);
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void drivingLicenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void loacalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplications frm = new frmListLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void lockalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingApplication frm = new frmAddNewLocalDrivingApplication();
            frm.ShowDialog();
        }

        private void internationalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalDrivingLicense frm = new frmInternationalDrivingLicense();
            frm.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void internationalDrivingLicesnseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntranatioalLicenseApplications frm = new frmIntranatioalLicenseApplications();
            frm.ShowDialog(); 
        }

        private void renewDriveingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLicense frm = new frmRenewLicense();
            frm.ShowDialog();
        }

        private void replacementForDamagedOrLostLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplacementOrDamagedLicense frm = new frmReplacementOrDamagedLicense();
            frm.ShowDialog();

        }
    }
}
