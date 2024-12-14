using DVLD_Business.Licenses;
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
    public partial class ctrlFindDriverLicense : UserControl
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;
        public ctrlFindDriverLicense()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                MessageBox.Show("You should Enter LicenseID !!");
                return;
            }
            if(!clsLicense.IsLicenseExist(Convert.ToInt32(txtSearch.Text.Trim())))
            {
                MessageBox.Show("Licnese is Not Exist please enter another license");
                return;
            }
            ctrlDriverLicenseInfo1.LoadDataByLicenseID(Convert.ToInt32(txtSearch.Text.Trim()));

            DataBack?.Invoke(sender, Convert.ToInt32(txtSearch.Text.Trim()));
            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
