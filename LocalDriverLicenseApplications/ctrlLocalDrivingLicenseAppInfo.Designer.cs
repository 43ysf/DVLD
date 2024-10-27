namespace DVLD.LocalDriverLicenseApplications
{
    partial class ctrlLocalDrivingLicenseAppInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlDrivinLicenseApplicationInfo1 = new DVLD.LocalDriverLicenseApplications.ctrlDrivinLicenseApplicationInfo();
            this.ctrlApplicationBasicInfo1 = new DVLD.Applications.ctrlApplicationBasicInfo();
            this.SuspendLayout();
            // 
            // ctrlDrivinLicenseApplicationInfo1
            // 
            this.ctrlDrivinLicenseApplicationInfo1.Location = new System.Drawing.Point(3, 3);
            this.ctrlDrivinLicenseApplicationInfo1.Name = "ctrlDrivinLicenseApplicationInfo1";
            this.ctrlDrivinLicenseApplicationInfo1.Size = new System.Drawing.Size(881, 155);
            this.ctrlDrivinLicenseApplicationInfo1.TabIndex = 1;
            // 
            // ctrlApplicationBasicInfo1
            // 
            this.ctrlApplicationBasicInfo1.Location = new System.Drawing.Point(3, 165);
            this.ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            this.ctrlApplicationBasicInfo1.Size = new System.Drawing.Size(881, 264);
            this.ctrlApplicationBasicInfo1.TabIndex = 0;
            // 
            // ctrlLocalDrivingLicenseAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlDrivinLicenseApplicationInfo1);
            this.Controls.Add(this.ctrlApplicationBasicInfo1);
            this.Name = "ctrlLocalDrivingLicenseAppInfo";
            this.Size = new System.Drawing.Size(901, 437);
            this.ResumeLayout(false);

        }

        #endregion

        private Applications.ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
        private ctrlDrivinLicenseApplicationInfo ctrlDrivinLicenseApplicationInfo1;
    }
}
