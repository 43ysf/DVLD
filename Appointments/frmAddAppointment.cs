using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_Business.Applications;
using DVLD_Business.ApplicationTypes;
using DVLD_Business.Appointments;
using DVLD_Business.LicenseClasses;
using DVLD_Business.LocalDrivingLicenseApplications;
using DVLD_Business.Manage_Test_Types;
using DVLD_Business.People;
using DVLD_Business.Tests;

namespace DVLD.Appointments
{
    public partial class frmAddAppointment : Form
    {
        clsApplication rApp = null;
        double RAppFees = 0;

        public enum enMode { TakeTest = 0, RetakeTest = 1 }
        public enMode Mode { get; set; }
        public frmAddAppointment(int AppID)
        {
            InitializeComponent();
        }
        private clsLocalDrivingLicenseApplication app = null;
        public frmAddAppointment(int AppID, enMode mode )
        {
            InitializeComponent();
            Mode = mode;
            grbRetakeInfo.Enabled = (Mode == enMode.RetakeTest);
            app = clsLocalDrivingLicenseApplication.Find(AppID);
            FillData();
        }

        public void FillData()
        {
            
            //clsLocalDrivingLicenseApplication app = clsLocalDrivingLicenseApplication.Find(ID);
            lblDLAppID.Text = app.LocalDrivingLicenseApplicationID.ToString();
            lblDClass.Text = clsLicenseClass.Find(app.LicenseClassID).LicenseClassName;
            lblName.Text = clsPerson.GetFullNamePerson(clsApplication.Find(app.ApplicationID).ApplicationPersonID);
            lblTrial.Text = clsAppointment.GetNumberOfTrials(app.LocalDrivingLicenseApplicationID, 1).ToString();
            lblFees.Text =  clsTestType.Find(1).TestFees.ToString();
            if(Mode == enMode.TakeTest)
            {
                lblTotalFees.Text = lblFees.Text;
                lblRTestAppID.Text = "N/A";
                lblRAppFees.Text = RAppFees.ToString();
            }
            else
            {
                RAppFees = clsApplicationType.Find(8).ApplicationFees;

                lblTotalFees.Text = (RAppFees +  clsTestType.Find(1).TestFees).ToString();
                lblRTestAppID.Text = rApp.ApplicationID.ToString();
                lblRAppFees.Text = RAppFees.ToString();
                
            }
            dtpDate.MinDate = DateTime.Now;
            
        }





        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsAppointment appointment = new clsAppointment();
            appointment.LocalDrivingLicenseApplicationID = Convert.ToInt32(lblDLAppID.Text) ;
            appointment.IsLocked = false;
            appointment.AppointmentDate = (DateTime)dtpDate.Value;
            appointment.CreatedByUserID = clsCurrentUserInfo.CurrentUserID;
            appointment.PaidFees = Convert.ToDecimal(lblTotalFees.Text);
            appointment.TestTypeID = 1;

            if (Mode == enMode.TakeTest)
            {
               if( appointment.Save())
                {
                    MessageBox.Show("Appointment Added successfully");
                }
            }
            else
            {
                rApp.ApplicationDate = DateTime.Now;
                rApp.PaidFees = RAppFees;
                rApp.ApplicationStatus = 3;
                rApp.LastStatusDate = DateTime.Now;
                rApp.ApplicationType = 8;
                rApp.CreatedBy = clsCurrentUserInfo.CurrentUserID;
                rApp.ApplicationPersonID = clsApplication.Find(app.ApplicationID).ApplicationPersonID;
                if(rApp.AddNew())
                {
                    if(appointment.Save())
                    {
                        lblRTestAppID.Text = appointment.TestAppointmentID.ToString();
                        MessageBox.Show("Appointment Added Successfully");
                    }
                }
            }
        }
    }
}
