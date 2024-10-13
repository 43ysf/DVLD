using DVLD_Business.ApplicationTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Manage_Application_Types
{
    public partial class frmEditApplicationType : Form
    {
        clsApplicationType Application = null;
        public frmEditApplicationType(int ApplicationTypeID)
        {
            Application = clsApplicationType.Find(ApplicationTypeID);
            InitializeComponent();
            _FillData(Application);
        }

        private void _FillData(clsApplicationType Application)
        {
            if (Application != null)
            {
                lblID.Text = Application.ApplictionTypeID.ToString();
                txtFees.Text = Application.ApplicationFees.ToString();
                txtTitle.Text = Application.ApplicationTypeTitle.ToString();
            }
            else
            {
                MessageBox.Show("There is wrong");
            }
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Application.ApplicationTypeTitle = txtTitle.Text;
            Application.ApplicationFees = Convert.ToDouble(txtFees.Text);
            if (Application.UpdateApplication())
            {
                MessageBox.Show("Application Updated Successfully");

            }
            else
            {
                MessageBox.Show("Fail to update application ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط والحذف والمسافة
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
