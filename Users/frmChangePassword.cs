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

namespace DVLD.Users
{
    public partial class frmChangePassword : Form
    {
        clsUser _User = null;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _User = clsUser.Find(UserID);
            this.ctrlLoginInformation1.LoadData(_User);
            this.ctrlPersonInfo1.FillPersonInfo(_User.Person);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_User.Password != txtCurrentPassword.Text)
            {
                MessageBox.Show("Current Password is wrong !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Focus();
                return;
            }
            if(txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Confirm Password Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }
            if(_User.Save())
            {
                MessageBox.Show("Password changed successfuly");
           
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
