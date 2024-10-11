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
    public partial class frmLoginInfo : Form
    {

        public frmLoginInfo(int UserID)
        {
            InitializeComponent();
            clsUser user = clsUser.Find(UserID);
            ctrlPersonInfo1.FillPersonInfo(user.Person);
            ctrlLoginInformation1.LoadData(user);
        }




    }
}
