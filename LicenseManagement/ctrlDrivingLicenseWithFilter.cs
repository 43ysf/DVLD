using DVLD_Business.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.LicenseManagement
{
    public partial class ctrlDrivingLicenseWithFilter : UserControl
    {
        clsLicense _License = null;
        public ctrlDrivingLicenseWithFilter()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
         
            int LicenseID = Convert.ToInt32(txtSearch.Text.Trim());    
            if(!clsLicense.ILicenseExist(LicenseID))
            {
                MessageBox.Show("License is not present in the system.");
                return;
            }

            _License = clsLicense.Find(LicenseID);
            ctrlDriverLicenseInfo1.LoadDataByLicenseID(_License);
            
        }


    }
}
