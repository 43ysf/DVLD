using DVLD_Business.Appointments;
using DVLD_Business.LocalDrivingLicenseApplications;
using DVLD_Business.Tests;
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
    public partial class frmTestAppointments : Form
    {
        public enum enMode {enVisonTest = 1, enWrttenTest = 2, enStreetTest = 3};
        public enMode Mode;
        private clsLocalDrivingLicenseApplication _LDLApp = null;
        public frmTestAppointments(enMode mode, int LDLAppID)
        {
            InitializeComponent();
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            Mode = mode;
            ctrlLocalDrivingLicenseAppInfo1.FillData(LDLAppID);

            _FilData();
        }

        private void _FilData()
        {
            switch(Mode)
            {
                case enMode.enVisonTest:
                    pbTestIcon.Image = Properties.Resources.Vision_512;
                    lbTitle.Text = "Vison Test Appointments";
                    break;
                case enMode.enWrttenTest:
                    pbTestIcon.Image = Properties.Resources.Written_Test_512;
                    lbTitle.Text = "Written Test Appointments";
                    break;
                case enMode.enStreetTest:
                    pbTestIcon.Image = Properties.Resources.driving_test_512;
                    lbTitle.Text = "Street Test Appointments";
                    break;
            }
        }



        private void btnAddAppointments_Click(object sender, EventArgs e)
        {
            DataTable dt = clsAppointment.GettAllAppointments(_LDLApp.LocalDrivingLicenseApplicationID, 2);
            int AppointID = -1;
            foreach (DataRow dr in dt.Rows)
            {
                AppointID =(int) dr["TestAppointmentID"];
                if(clsTest.IsTestDone(AppointID))
                {
                    MessageBox.Show("This Person already passed this test");
                    return;
                }
            }

        }
    }
}
