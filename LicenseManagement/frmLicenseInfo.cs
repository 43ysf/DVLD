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
    public partial class frmLicenseInfo : Form
    {
        public frmLicenseInfo(int LDLAppID)
        {
            InitializeComponent();
            ctrlDriverLicenseInfo1.LoadData(LDLAppID);
        }
    }
}
