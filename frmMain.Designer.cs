namespace DVLD
{
    partial class frmMain
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.msApplicatinos = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loacalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLicesnseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassworedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msApplicatinos,
            this.msPeople,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1312, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // msApplicatinos
            // 
            this.msApplicatinos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.msApplicatinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msApplicatinos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msApplicatinos.Name = "msApplicatinos";
            this.msApplicatinos.Size = new System.Drawing.Size(126, 24);
            this.msApplicatinos.Text = "Applications";
            // 
            // drivingLicenToolStripMenuItem
            // 
            this.drivingLicenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLiToolStripMenuItem});
            this.drivingLicenToolStripMenuItem.Name = "drivingLicenToolStripMenuItem";
            this.drivingLicenToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.drivingLicenToolStripMenuItem.Text = "Driving Licenses Services";
            this.drivingLicenToolStripMenuItem.Click += new System.EventHandler(this.drivingLicenToolStripMenuItem_Click);
            // 
            // newDrivingLiToolStripMenuItem
            // 
            this.newDrivingLiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockalLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLiToolStripMenuItem.Name = "newDrivingLiToolStripMenuItem";
            this.newDrivingLiToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.newDrivingLiToolStripMenuItem.Text = "New Driving License";
            // 
            // lockalLicenseToolStripMenuItem
            // 
            this.lockalLicenseToolStripMenuItem.Name = "lockalLicenseToolStripMenuItem";
            this.lockalLicenseToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.lockalLicenseToolStripMenuItem.Text = "Local License";
            this.lockalLicenseToolStripMenuItem.Click += new System.EventHandler(this.lockalLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loacalToolStripMenuItem,
            this.internationalDrivingLicesnseToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // loacalToolStripMenuItem
            // 
            this.loacalToolStripMenuItem.Name = "loacalToolStripMenuItem";
            this.loacalToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.loacalToolStripMenuItem.Text = "Local Driving License Applications";
            this.loacalToolStripMenuItem.Click += new System.EventHandler(this.loacalToolStripMenuItem_Click);
            // 
            // internationalDrivingLicesnseToolStripMenuItem
            // 
            this.internationalDrivingLicesnseToolStripMenuItem.Name = "internationalDrivingLicesnseToolStripMenuItem";
            this.internationalDrivingLicesnseToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.internationalDrivingLicesnseToolStripMenuItem.Text = "International Licesnse Applications";
            this.internationalDrivingLicesnseToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingLicesnseToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // msPeople
            // 
            this.msPeople.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msPeople.Name = "msPeople";
            this.msPeople.Size = new System.Drawing.Size(80, 24);
            this.msPeople.Text = "People";
            this.msPeople.Click += new System.EventHandler(this.msPeople_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInformationToolStripMenuItem,
            this.changePassworedToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            this.accountSettingsToolStripMenuItem.Click += new System.EventHandler(this.accountSettingsToolStripMenuItem_Click);
            // 
            // currentUserInformationToolStripMenuItem
            // 
            this.currentUserInformationToolStripMenuItem.Name = "currentUserInformationToolStripMenuItem";
            this.currentUserInformationToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.currentUserInformationToolStripMenuItem.Text = "current user info";
            this.currentUserInformationToolStripMenuItem.Click += new System.EventHandler(this.currentUserInformationToolStripMenuItem_Click);
            // 
            // changePassworedToolStripMenuItem
            // 
            this.changePassworedToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassworedToolStripMenuItem.Name = "changePassworedToolStripMenuItem";
            this.changePassworedToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.changePassworedToolStripMenuItem.Text = "Change password";
            this.changePassworedToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Logo_Final;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1312, 645);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem msApplicatinos;
        private System.Windows.Forms.ToolStripMenuItem msPeople;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePassworedToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loacalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLicesnseToolStripMenuItem;
    }
}

