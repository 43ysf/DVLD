using DVLD.People;
using DVLD_Business.Applications;
using DVLD_Business.ApplicationTypes;
using DVLD_Business.People;
using DVLD_Business.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        clsApplication app = null;
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }
        public void FillData(int ApplicationID)
        {
             app = clsApplication.Find(ApplicationID);
            if (app != null)
            {
                lblID.Text = app.ApplicationID.ToString();
                lblFees.Text = app.PaidFees.ToString();
                lblCreatedBy.Text = clsUser.Find(app.CreatedBy).UserName.ToString();
                lblDate.Text = app.ApplicationDate.ToShortDateString();
                lblStatus.Text = app.GetStatus();
                lblType.Text = clsApplicationType.Find(app.ApplicationType).ApplicationTypeTitle;
                lblApplicant.Text = clsPerson.Find(app.ApplicationPersonID).FullName;
                lblStatusDate.Text = app.LastStatusDate.ToShortDateString();

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo(app.ApplicationPersonID);
            frm.ShowDialog();
        }
    }
}
