﻿namespace DVLD.LicenseManagement
{
    partial class ctrlDrivingLicenseWithFilter
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
            this.ctrlDriverLicenseInfo1 = new DVLD.LicenseManagement.ctrlDriverLicenseInfo();
            this.gbFindOrAdd = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFindOrAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(19, 195);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(894, 436);
            this.ctrlDriverLicenseInfo1.TabIndex = 0;
            // 
            // gbFindOrAdd
            // 
            this.gbFindOrAdd.Controls.Add(this.btnFind);
            this.gbFindOrAdd.Controls.Add(this.txtSearch);
            this.gbFindOrAdd.Controls.Add(this.label1);
            this.gbFindOrAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFindOrAdd.Location = new System.Drawing.Point(19, 34);
            this.gbFindOrAdd.Name = "gbFindOrAdd";
            this.gbFindOrAdd.Size = new System.Drawing.Size(894, 134);
            this.gbFindOrAdd.TabIndex = 1;
            this.gbFindOrAdd.TabStop = false;
            this.gbFindOrAdd.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::DVLD.Properties.Resources.Search;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFind.FlatAppearance.BorderSize = 2;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(543, 57);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(45, 36);
            this.btnFind.TabIndex = 2;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(289, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(246, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LicenseID: ";
            // 
            // ctrlDrivingLicenseWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFindOrAdd);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Name = "ctrlDrivingLicenseWithFilter";
            this.Size = new System.Drawing.Size(943, 650);
            this.gbFindOrAdd.ResumeLayout(false);
            this.gbFindOrAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.GroupBox gbFindOrAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}
