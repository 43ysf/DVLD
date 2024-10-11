using DVLD_Business.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD.Users
{
    public partial class frmAddNewOrUpdateUser : Form
    {
        private bool _UserFromFind = false;
        public frmAddNewOrUpdateUser()
        {
            InitializeComponent();
            ctrlFindPerson.DataBack += GetPersonID;
            _UserFromFind = true;
        }
        public frmAddNewOrUpdateUser(int UserID)
        {
            InitializeComponent();
            lbTitle.Text = "Update User";
            ctrlFindPerson.DataBack += GetPersonID;
            this.User = clsUser.Find(UserID);
            _PersonID = UserID;
            this.ctrlFindPerson.UpdateMode(User);
        }

        clsUser User = new clsUser(); 


        int _PersonID = -1;

        private void GetPersonID(object Sender,  int PersonID)
        {
            _PersonID = PersonID;

        }

        private bool canSwitchTab = false;


        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!canSwitchTab && tabControl1.SelectedIndex == 1)
            {
                e.Cancel = true;
            }
            else
            {
                canSwitchTab = false; // إعادة تعيين المتغير
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_PersonID == -1)
            {
                MessageBox.Show("You should choose person");
                return;
            }
            if (!clsUser.IsPersonIDExists(_PersonID))
            {

                canSwitchTab = true;
                tabControl1.SelectedIndex = 1;
                User.PersonID = _PersonID;
            }
            else
            {
                MessageBox.Show("Person Already Exists in Users" + _PersonID);
            }

            if(User != null && !_UserFromFind)
            {
                lblUserID.Text = User.UserID.ToString(); 
                txtUserName.Text = User.UserName.ToString();
                cbIsActive.Checked= (bool)User.IsActive;
                txtPassword.Text = User.Password.ToString();
                txtConfirmPassword.Text = User.Password.ToString();

            }


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("User Name is Empty");
                txtUserName.Focus();
                return;
            }
            if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Confirm Password Again");
                txtConfirmPassword.Focus();
                return;
            }
            //if(clsUser.IsExist(txtUserName.Text)) 
            //{
            //    MessageBox.Show("User Name already is exist");
            //    txtUserName.Focus();
            //    return;
            //}


            User.UserName = txtUserName.Text;
            User.Password = txtPassword.Text;
            User.IsActive = cbIsActive.Checked;
            if(User.Save())
            {
                MessageBox.Show("User Add Succefuly");
                lblUserID.Text = User.UserID.ToString();
                
            }
            else
            {
                MessageBox.Show("User Faild to add ");

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlFindPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
