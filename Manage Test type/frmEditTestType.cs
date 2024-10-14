using DVLD.Manage_Application_Types;
using DVLD_Business.Manage_Test_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Manage_Test_type
{
    public class frmEditTestType : frmEditApplicationType
    {
        protected System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;

        private void InitializeComponent()
        {
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Location = new System.Drawing.Point(114, 9);
            this.lbTitle.Size = new System.Drawing.Size(332, 42);
            this.lbTitle.Text = "Update Test Type";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(90, 83);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(72, 134);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(65, 348);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(141, 132);
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(141, 346);
            this.txtFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFees_KeyPress);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(141, 83);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(399, 380);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(246, 380);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(141, 186);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(386, 135);
            this.txtDescription.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Description: ";
            // 
            // frmEditTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(558, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Name = "frmEditTestType";
            this.Load += new System.EventHandler(this.frmEditTestType_Load);
            this.Controls.SetChildIndex(this.lbTitle, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtTitle, 0);
            this.Controls.SetChildIndex(this.txtFees, 0);
            this.Controls.SetChildIndex(this.lblID, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        clsTestType Test = null;
        public frmEditTestType(int TestTypeID)
        {
            InitializeComponent();
            Test = clsTestType.Find(TestTypeID);
            _LoadData(TestTypeID);
        }

        private void _LoadData(int TestID)
        {
            Test = clsTestType.Find(TestID);
            if(Test != null)
            {
                lblID.Text = Test.TestTypeID.ToString();
                txtDescription.Text = Test.TestTypeDescription.ToString();
                txtFees.Text = Test.TestFees.ToString();
                txtTitle.Text = Test.TestTypeTitle.ToString();

            }
        }
        private void frmEditTestType_Load(object sender, EventArgs e)
        {

        }


        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtTitle.Text))
            {
                MessageBox.Show("Title Shoud not be Empty");
                return;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Description shout not be Empty");
                txtDescription.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                MessageBox.Show("Fees Shoud not be Empty");
                txtFees.Focus();
                return;
            }

            Test.TestTypeTitle = txtTitle.Text;
            Test.TestTypeDescription = txtDescription.Text;
            Test.TestFees = Convert.ToDouble(txtFees.Text);
            if (Test.UpdateTestType())
            {
                MessageBox.Show("Test Updated Successfully");


            }



        }

    }
}
