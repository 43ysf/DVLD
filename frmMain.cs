﻿using DVLD.People;
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
        public frmMain(clsUser User)
        {
            InitializeComponent();
            //SystemEvents.PowerModeChanged += OnScreenIsOf;
            this.User = User;
 
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
            Application.Exit();
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
            this.Visible = false;
            frmLoginScreen frm = new frmLoginScreen();
            frm.ShowDialog();
        }

        private void currentUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginInfo frm = new frmLoginInfo(User.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(User.UserID);
            frm.ShowDialog();
        }
    }
}
