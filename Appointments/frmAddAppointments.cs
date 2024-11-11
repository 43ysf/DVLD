using DVLD_Business.Applications;
using DVLD_Business.ApplicationTypes;
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
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Appointments
{
    public partial class frmAddAppointments : Form
    {
        private clsLocalDrivingLicenseApplication _LDLApp = null;
        private clsApplication _Application = null;
        private clsAppointment _Appointment = null;

        public enum enTestAppointmentType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        public enum enMode { AddNew=1, Update=2, RetakeTest = 3 }
        public enTestAppointmentType TestAppointmentType { get; set; }
        public enMode Mode { get; set; }
        public frmAddAppointments(int LDLAppID, enMode mode, enTestAppointmentType testAppointmentType)
        {
            InitializeComponent();
            TestAppointmentType  = testAppointmentType;
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            _Application = clsApplication.Find(_LDLApp.ApplicationID); ;
            Mode = mode;
            _FillData();
        }

        public frmAddAppointments(int LDLAppID, int AppointmentID, enTestAppointmentType testAppointmentType)
        {
            InitializeComponent();
            Mode = enMode.Update;
            TestAppointmentType = testAppointmentType;
            _LDLApp = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            _Application = clsApplication.Find(_LDLApp.ApplicationID);
            _Appointment = clsAppointment.Find(AppointmentID);
            _FillData();

        }
        private void _FillData()
        {
             
            lblDLAppID.Text = _LDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = clsLicenseClass.Find(_LDLApp.LicenseClassID).LicenseClassName;
            lblFees.Text = _Application.PaidFees.ToString();
            lblTotalFees.Text = Mode != enMode.RetakeTest ? _Application.PaidFees.ToString() : (Convert.ToDouble(lblFees.Text) + clsApplicationType.Find(8).ApplicationFees).ToString();
            grbRetakeInfo.Enabled = Mode == enMode.RetakeTest;
            lblName.Text = clsPerson.GetFullNamePerson(_Application.ApplicationPersonID).ToString();
            
            switch (TestAppointmentType)
            {
                case enTestAppointmentType.VisionTest:
                    lblTrial.Text = clsAppointment.GetNumberOfTrials(_LDLApp.LocalDrivingLicenseApplicationID, 1).ToString();
                    grbTestType.Text = "Test Vision";
                    break;
                case enTestAppointmentType.WrittenTest:
                    grbTestType.Text = "Written Test";

                    lblTrial.Text = clsAppointment.GetNumberOfTrials(_LDLApp.LocalDrivingLicenseApplicationID, 2).ToString();
                    break;
                case enTestAppointmentType.StreetTest:
                    grbTestType.Text = "Street Test";
                    lblTrial.Text = clsAppointment.GetNumberOfTrials(_LDLApp.LocalDrivingLicenseApplicationID, 3).ToString();
                    break;

            }
        }

        private void _Save()
        {

            if(Mode != enMode.Update)
            {
                _Appointment = new clsAppointment();
                _Appointment.PaidFees = Convert.ToDecimal(lblTotalFees.Text);
                _Appointment.AppointmentDate = dtpDate.Value;
                _Appointment.IsLocked = false;
                _Appointment.CreatedByUserID = clsCurrentUserInfo.CurrentUserID;
                _Appointment.LocalDrivingLicenseApplicationID = _LDLApp.LocalDrivingLicenseApplicationID;
                _Appointment.TestTypeID = (TestAppointmentType == enTestAppointmentType.VisionTest) ? 1 : (TestAppointmentType == enTestAppointmentType.WrittenTest) ? 2 : 3;
            }
            else
            {
                _Appointment.AppointmentDate = dtpDate.Value;
                if(_Appointment.Save())
                {
                    _Application.UpdateLastStatus();

                    MessageBox.Show("Appointment Updated Successfuly ");
                    return;
                }
            }
            if(Mode == enMode.RetakeTest)
            {
                clsApplication RetakeApp = new clsApplication();
                RetakeApp.ApplicationStatus = 1;
                RetakeApp.ApplicationDate = DateTime.Now;
                RetakeApp.CreatedBy = clsCurrentUserInfo.CurrentUserID;
                RetakeApp.ApplicationPersonID = _Application.ApplicationPersonID;
                RetakeApp.ApplicationType = 8;
                RetakeApp.PaidFees = clsApplicationType.Find(8).ApplicationFees;
                RetakeApp.LastStatusDate = DateTime.Now;
                if(RetakeApp.Save())
                {
                   if( _Appointment.Save())
                    {
                        _Application.UpdateLastStatus();

                        MessageBox.Show("Appointment Added successfuly !");
                        Mode = enMode.Update;
                        lblRTestAppID.Text = _Appointment.TestAppointmentID.ToString();
                    }
                }
            }
            else
            {
                if(_Appointment.Save())
                {
                    MessageBox.Show("Appointment Saved Successfully");
                    _Application.UpdateLastStatus();
              
                    Mode = enMode.Update;
                    _Application.UpdateLastStatus();

                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(TestAppointmentType == enTestAppointmentType.StreetTest && clsLocalDrivingLicenseApplication.GetPassedTest(_LDLApp.LocalDrivingLicenseApplicationID) == 2)
            {
                //_Application.ApplicationStatus = 3;
                _Application.UpdateLastStatus();
            }
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
