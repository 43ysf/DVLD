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
    public partial class ctrlLoginInformation : UserControl
    {
        public ctrlLoginInformation()
        {
            InitializeComponent();
        }


        public void LoadData(int UserID)
        {
            clsUser user = clsUser.Find(UserID);
            lblIsActive.Text = (bool)user.IsActive ? "Yes" : "No";
            lblUserID.Text = user.UserID.ToString();
            lblUserName.Text = user.UserName;
        }

        public void LoadData(clsUser user)
        {
            LoadData(user.UserID);  
        }
    }
}
