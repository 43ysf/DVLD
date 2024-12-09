namespace DVLD.InternationalDrivingLicense
{
    partial class frmInternationalDrivingLicense
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
            this.btnIssue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlDrivingLicenseWithFilter1 = new DVLD.LicenseManagement.ctrlDrivingLicenseWithFilter();
            this.SuspendLayout();
            // 
            // btnIssue
            // 
            this.btnIssue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIssue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIssue.FlatAppearance.BorderSize = 2;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::DVLD.Properties.Resources.International_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(800, 751);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(148, 64);
            this.btnIssue.TabIndex = 22;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DVLD.Properties.Resources.cross;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(635, 751);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 64);
            this.button1.TabIndex = 21;
            this.button1.Text = "Clsoe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlDrivingLicenseWithFilter1
            // 
            this.ctrlDrivingLicenseWithFilter1.Location = new System.Drawing.Point(12, 12);
            this.ctrlDrivingLicenseWithFilter1.Name = "ctrlDrivingLicenseWithFilter1";
            this.ctrlDrivingLicenseWithFilter1.Size = new System.Drawing.Size(943, 733);
            this.ctrlDrivingLicenseWithFilter1.TabIndex = 0;
            // 
            // frmInternationalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 834);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlDrivingLicenseWithFilter1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInternationalDrivingLicense";
            this.Text = "frmInternationalDrivingLicense";
            this.ResumeLayout(false);

        }

        #endregion

        private LicenseManagement.ctrlDrivingLicenseWithFilter ctrlDrivingLicenseWithFilter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIssue;
    }
}