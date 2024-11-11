using DVLD_Business.Applications;
using DVLD_Business.Appointments;
using DVLD_Business.LicenseClasses;
using DVLD_Business.LocalDrivingLicenseApplications;
using DVLD_Business.People;
using DVLD_Business.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Tests
{
    public partial class frmTakeTest : Form
    {
        public enum enMod { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        enMod Mode = enMod.VisionTest;
        clsTest _Test = null;
        clsAppointment _app = null;
        public frmTakeTest(int TestAppointmentID, enMod mode)
        {
            InitializeComponent();
            _app = clsAppointment.Find(TestAppointmentID);
            FillData();


        }
        
        public void SaveResults()
        {
            if(_app.IsLocked)
            {
                MessageBox.Show("This Test Taken Already");
                return;
            }
            _Test = new clsTest();
            _Test.Notes = txtNotes.Text;
            _Test.TestResult = rbPass.Checked;
            _Test.CreatedBy = clsCurrentUserInfo.CurrentUserID;
            _Test.TestAppointmentID = _app.TestAppointmentID;

            if (_Test.TestID == -1)
            {

                if (_Test.AddNew())
                {
                    _app.IsLocked = true;
                    if(_app.Save())
                    {
                        MessageBox.Show("Test Saved Successfully");

                    }
                }

                btnSave.Enabled = false;
                panel1.Enabled = false;
                txtNotes.Enabled = false;
            }
               
         
               
        }

        public void FillData()
        {
            int TestTypeID = 0;

            switch (Mode)
            {
                case enMod.VisionTest:
                    TestTypeID = 1;
                    groupBox1.Text = "Vision Test";
                    pbTestPicture.Image = Properties.Resources.Vision_512;
                    lbTitle.Text = "Vision Test";
                    break;
                case enMod.StreetTest:
                    TestTypeID = 3;
                    groupBox1.Text = "Street Test";
                    pbTestPicture.Image = Properties.Resources.driving_test_512;
                    lbTitle.Text = "Street Test";
                    break;
                case enMod.WrittenTest:
                    TestTypeID = 2;
                    groupBox1.Text = "Writtien Test";
                    pbTestPicture.Image = Properties.Resources.Vision_512;
                    lbTitle.Text = "Wrtten Test";
                    break;

            }

            clsLocalDrivingLicenseApplication LDLAPP = clsLocalDrivingLicenseApplication.Find(_app.LocalDrivingLicenseApplicationID);

            lblFees.Text = _app.PaidFees.ToString();
            lblClass.Text = clsLicenseClass.Find(clsLocalDrivingLicenseApplication.Find(_app.LocalDrivingLicenseApplicationID).LicenseClassID).LicenseClassName;
            lblName.Text = clsPerson.Find(clsApplication.Find(LDLAPP.ApplicationID).ApplicationPersonID).FullName;
            lblDLAppID.Text = LDLAPP.LocalDrivingLicenseApplicationID.ToString();
            lblTrial.Text = clsAppointment.GetNumberOfTrials(LDLAPP.LocalDrivingLicenseApplicationID, TestTypeID).ToString();
            lblDate.Text = _app.AppointmentDate.ToString();
            lblTestID.Text = "N/A";


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveResults();
        }
    }
}
