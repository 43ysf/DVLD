namespace DVLD.DriverLicenseApplications
{
    partial class frmListLocalDrivingLicenseApplications
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgvListLicenseApplications = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewLicenseApplication = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.schdualTest = new System.Windows.Forms.ToolStripMenuItem();
            this.schdualVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.schdualWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.schdualStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.IssuDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLicenseApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 815);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "#Recodrs: ";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(350, 350);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(342, 27);
            this.txtFilter.TabIndex = 16;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "FullName",
            "L.D.LAppID",
            "NationalNo",
            "None",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(118, 349);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(226, 28);
            this.cbFilterBy.Sorted = true;
            this.cbFilterBy.TabIndex = 15;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filter by: ";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(141, 815);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(48, 25);
            this.lblNumberOfRecords.TabIndex = 18;
            this.lblNumberOfRecords.Text = "???";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(297, 266);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(620, 42);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Local Driving License Applications";
            // 
            // dgvListLicenseApplications
            // 
            this.dgvListLicenseApplications.AllowDrop = true;
            this.dgvListLicenseApplications.AllowUserToAddRows = false;
            this.dgvListLicenseApplications.AllowUserToDeleteRows = false;
            this.dgvListLicenseApplications.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvListLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLicenseApplications.Location = new System.Drawing.Point(17, 383);
            this.dgvListLicenseApplications.Name = "dgvListLicenseApplications";
            this.dgvListLicenseApplications.ReadOnly = true;
            this.dgvListLicenseApplications.RowHeadersWidth = 51;
            this.dgvListLicenseApplications.RowTemplate.Height = 24;
            this.dgvListLicenseApplications.Size = new System.Drawing.Size(1160, 392);
            this.dgvListLicenseApplications.TabIndex = 12;
            this.dgvListLicenseApplications.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvListLicenseApplications_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(376, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewLicenseApplication
            // 
            this.btnAddNewLicenseApplication.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddNewLicenseApplication.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewLicenseApplication.BackgroundImage = global::DVLD.Properties.Resources.New_Application_64;
            this.btnAddNewLicenseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewLicenseApplication.FlatAppearance.BorderSize = 2;
            this.btnAddNewLicenseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLicenseApplication.Location = new System.Drawing.Point(1029, 313);
            this.btnAddNewLicenseApplication.Name = "btnAddNewLicenseApplication";
            this.btnAddNewLicenseApplication.Size = new System.Drawing.Size(148, 64);
            this.btnAddNewLicenseApplication.TabIndex = 13;
            this.btnAddNewLicenseApplication.UseVisualStyleBackColor = false;
            this.btnAddNewLicenseApplication.Click += new System.EventHandler(this.btnAddNewLicenseApplication_Click);
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
            this.button1.Location = new System.Drawing.Point(1029, 781);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 64);
            this.button1.TabIndex = 20;
            this.button1.Text = "Clsoe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancel,
            this.schdualTest,
            this.IssuDrivingLicense});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(293, 176);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            // 
            // cancel
            // 
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(292, 24);
            this.cancel.Text = "Cancel Application";
            this.cancel.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // schdualTest
            // 
            this.schdualTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schdualVisionTest,
            this.schdualWrittenTest,
            this.schdualStreetTest});
            this.schdualTest.Name = "schdualTest";
            this.schdualTest.Size = new System.Drawing.Size(292, 24);
            this.schdualTest.Text = "Sechduale Test";
            this.schdualTest.Click += new System.EventHandler(this.schdualTestToolStripMenuItem_Click);
            // 
            // schdualVisionTest
            // 
            this.schdualVisionTest.Name = "schdualVisionTest";
            this.schdualVisionTest.Size = new System.Drawing.Size(236, 26);
            this.schdualVisionTest.Text = "Schdual a vision Test";
            this.schdualVisionTest.Click += new System.EventHandler(this.schdualAVisionTestToolStripMenuItem_Click);
            // 
            // schdualWrittenTest
            // 
            this.schdualWrittenTest.Name = "schdualWrittenTest";
            this.schdualWrittenTest.Size = new System.Drawing.Size(236, 26);
            this.schdualWrittenTest.Text = "Schdual a written Test";
            this.schdualWrittenTest.Click += new System.EventHandler(this.schdualAToolStripMenuItem_Click);
            // 
            // schdualStreetTest
            // 
            this.schdualStreetTest.Name = "schdualStreetTest";
            this.schdualStreetTest.Size = new System.Drawing.Size(236, 26);
            this.schdualStreetTest.Text = "Schdual a street t Test";
            this.schdualStreetTest.Click += new System.EventHandler(this.schdualAStreetTTestToolStripMenuItem_Click);
            // 
            // IssuDrivingLicense
            // 
            this.IssuDrivingLicense.Name = "IssuDrivingLicense";
            this.IssuDrivingLicense.Size = new System.Drawing.Size(292, 24);
            this.IssuDrivingLicense.Text = "Issue Driving License (First Time)";
            this.IssuDrivingLicense.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // frmListLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 851);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewLicenseApplication);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.dgvListLicenseApplications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListLocalDrivingLicenseApplications";
            this.Text = "frmListDrivingLicenseApplications";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLicenseApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewLicenseApplication;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvListLicenseApplications;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancel;
        private System.Windows.Forms.ToolStripMenuItem schdualTest;
        private System.Windows.Forms.ToolStripMenuItem schdualVisionTest;
        private System.Windows.Forms.ToolStripMenuItem schdualWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem schdualStreetTest;
        private System.Windows.Forms.ToolStripMenuItem IssuDrivingLicense;
    }
}