using DVLD_Business.Applications;
using DVLD_Business.ApplicationTypes;
using DVLD_Business.LicenseClasses;
using DVLD_Business.LocalDrivingLicenseApplications;
using DVLD_Business.People;
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

namespace DVLD.LocalDriverLicenseApplications
{
    public partial class frmAddNewLocalDrivingApplication : Form
    {
        private int _PersonID = -1;
        private clsPerson _Person = null;
        private clsApplication app = new clsApplication(); 
        private clsLocalDrivingLicenseApplication dla = new clsLocalDrivingLicenseApplication();
        public frmAddNewLocalDrivingApplication()
        {
            InitializeComponent();
            ucFindOrAddPerson.DataBack += _GetPersonID;
            _LoadComboBoxData();
            _LoadApplicationData();
        }



        private void _LoadApplicationData()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            if (clsCurrentUserInfo.User != null)
                lblCreatedBy.Text = clsCurrentUserInfo.User.UserName.ToString();
            else
                lblCreatedBy.Text = "No User yet";
            lblFees.Text = clsApplicationType.Find(1).ApplicationFees.ToString();

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
            _Person = clsPerson.Find(_PersonID);
            
            

        }

        private void tbLoginInfo_Click(object sender, EventArgs e)
        {

        }

        private void _LoadComboBoxData()
        {
            DataTable dt = clsLicenseClass.GetAll();
            cbLicenseClasses.DataSource = dt;
            cbLicenseClasses.DisplayMember = "ClassName";
            cbLicenseClasses.ValueMember = "LicenseClassID";
            cbLicenseClasses.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(clsLocalDrivingLicenseApplication.IsPersonHasThisLicense(_Person.PersonID, (int)cbLicenseClasses.SelectedValue))
            {
                MessageBox.Show("Person Has License Enter another Application");
                return;
            }
            if (!clsLocalDrivingLicenseApplication.IsPersonHasTheSamAppOrder(_Person.NationalNo, cbLicenseClasses.Text) )
            {
                MessageBox.Show(cbLicenseClasses.Text);

                app.CreatedBy = clsCurrentUserInfo.CurrentUserID;
                app.ApplicationStatus = 1;
                app.ApplicationDate = Convert.ToDateTime(lblApplicationDate.Text);
                app.PaidFees = Convert.ToDouble(lblFees.Text);
                app.ApplicationPersonID = _PersonID;
                app.LastStatusDate = app.ApplicationDate;
                app.ApplicationType = clsApplicationType.Find(1).ApplictionTypeID;
                if (app.Save())
                {
                    dla.ApplicationID = app.ApplicationID;
                    dla.LicenseClassID = (int)cbLicenseClasses.SelectedValue;
                    if (dla._AddNew())
                    {
                        MessageBox.Show("dla add successfuly");
                        lblApplicationID.Text = dla.LocalDrivingLicenseApplicationID.ToString();
                    }
                    else
                        MessageBox.Show(" dal not add");

                }
                else
                    MessageBox.Show("app not add");
            }
            else
                MessageBox.Show("The application is already Exist pleae enter another application or Done your application or cancel it!!!");
        }
    }
}
