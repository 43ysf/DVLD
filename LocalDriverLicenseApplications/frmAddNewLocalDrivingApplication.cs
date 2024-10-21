using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.LocalDriverLicenseApplications
{
    public partial class frmAddNewLocalDrivingApplication : Form
    {
        private int _PersonID = -1;
        public frmAddNewLocalDrivingApplication()
        {
            InitializeComponent();
            ucFindOrAddPerson.DataBack += _GetPersonID;
        }

        private void _GetPersonID(object Sender, int PersonID)
        {
            _PersonID = PersonID;
            
        }

        



        private bool _CanSwitchTap = false;

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(!_CanSwitchTap && tabControl1.SelectedIndex == 1)
            {
                e.Cancel = true;
            }
            else
            {
                _CanSwitchTap = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_PersonID == -1)
            {
                MessageBox.Show("Person should not be empty");
                return;
            }
            _CanSwitchTap = true;
            tabControl1.SelectedIndex = 1;
            

        }
    }
}
