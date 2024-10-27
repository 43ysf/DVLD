using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests
{
    public partial class frmVisonTest : Form
    {
        public frmVisonTest(int LDLAppID)
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseAppInfo1.FillData(LDLAppID);
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
