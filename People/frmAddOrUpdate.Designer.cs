namespace DVLD.People
{
    partial class frmAddOrUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlMyAdd = new DVLD_Presentation.People.ctrlAddNewPerson();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(467, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add New Person";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ctrlMyAdd
            // 
            this.ctrlMyAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ctrlMyAdd.Location = new System.Drawing.Point(73, 73);
            this.ctrlMyAdd.Name = "ctrlMyAdd";
            this.ctrlMyAdd.Size = new System.Drawing.Size(1053, 565);
            this.ctrlMyAdd.TabIndex = 0;
            this.ctrlMyAdd.Load += new System.EventHandler(this.ctrlAddOrUpdate_Load);
            // 
            // frmAddOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 694);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlMyAdd);
            this.Name = "frmAddOrUpdate";
            this.Text = "frmAddOrUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DVLD_Presentation.People.ctrlAddNewPerson ctrlMyAdd;
        private System.Windows.Forms.Label lblTitle;
    }
}