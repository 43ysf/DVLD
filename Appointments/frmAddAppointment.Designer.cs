namespace DVLD.Appointments
{
    partial class frmAddAppointment
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
            this.grbTestVision = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbRetakeInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblRAppFees = new System.Windows.Forms.Label();
            this.lblRTestAppID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTrial = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDClass = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbTestVision.SuspendLayout();
            this.grbRetakeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTestVision
            // 
            this.grbTestVision.Controls.Add(this.btnClose);
            this.grbTestVision.Controls.Add(this.btnSave);
            this.grbTestVision.Controls.Add(this.grbRetakeInfo);
            this.grbTestVision.Controls.Add(this.dtpDate);
            this.grbTestVision.Controls.Add(this.label11);
            this.grbTestVision.Controls.Add(this.lblTrial);
            this.grbTestVision.Controls.Add(this.lblFees);
            this.grbTestVision.Controls.Add(this.lblName);
            this.grbTestVision.Controls.Add(this.lblDClass);
            this.grbTestVision.Controls.Add(this.lblDLAppID);
            this.grbTestVision.Controls.Add(this.label5);
            this.grbTestVision.Controls.Add(this.label4);
            this.grbTestVision.Controls.Add(this.label2);
            this.grbTestVision.Controls.Add(this.label1);
            this.grbTestVision.Controls.Add(this.label3);
            this.grbTestVision.Controls.Add(this.lbTitle);
            this.grbTestVision.Controls.Add(this.pictureBox1);
            this.grbTestVision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTestVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTestVision.Location = new System.Drawing.Point(0, 0);
            this.grbTestVision.Name = "grbTestVision";
            this.grbTestVision.Size = new System.Drawing.Size(590, 762);
            this.grbTestVision.TabIndex = 0;
            this.grbTestVision.TabStop = false;
            this.grbTestVision.Text = "Vision Test";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD.Properties.Resources.cross;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(200, 706);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(448, 618);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 50);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grbRetakeInfo
            // 
            this.grbRetakeInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbRetakeInfo.Controls.Add(this.lblTotalFees);
            this.grbRetakeInfo.Controls.Add(this.lblRAppFees);
            this.grbRetakeInfo.Controls.Add(this.lblRTestAppID);
            this.grbRetakeInfo.Controls.Add(this.label14);
            this.grbRetakeInfo.Controls.Add(this.label13);
            this.grbRetakeInfo.Controls.Add(this.label12);
            this.grbRetakeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRetakeInfo.Location = new System.Drawing.Point(6, 469);
            this.grbRetakeInfo.Name = "grbRetakeInfo";
            this.grbRetakeInfo.Size = new System.Drawing.Size(584, 133);
            this.grbRetakeInfo.TabIndex = 30;
            this.grbRetakeInfo.TabStop = false;
            this.grbRetakeInfo.Text = "Retake Test info";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(438, 42);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(49, 20);
            this.lblTotalFees.TabIndex = 24;
            this.lblTotalFees.Text = "????";
            // 
            // lblRAppFees
            // 
            this.lblRAppFees.AutoSize = true;
            this.lblRAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAppFees.Location = new System.Drawing.Point(157, 42);
            this.lblRAppFees.Name = "lblRAppFees";
            this.lblRAppFees.Size = new System.Drawing.Size(49, 20);
            this.lblRAppFees.TabIndex = 23;
            this.lblRAppFees.Text = "????";
            // 
            // lblRTestAppID
            // 
            this.lblRTestAppID.AutoSize = true;
            this.lblRTestAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTestAppID.Location = new System.Drawing.Point(157, 80);
            this.lblRTestAppID.Name = "lblRTestAppID";
            this.lblRTestAppID.Size = new System.Drawing.Size(49, 20);
            this.lblRTestAppID.TabIndex = 22;
            this.lblRTestAppID.Text = "????";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(325, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Total Fees: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "R.Test.AppID: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "R.App.Fees: ";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(162, 380);
            this.dtpDate.MinDate = new System.DateTime(2024, 10, 31, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(166, 27);
            this.dtpDate.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(58, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Date: ";
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrial.Location = new System.Drawing.Point(162, 346);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(49, 20);
            this.lblTrial.TabIndex = 27;
            this.lblTrial.Text = "????";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(162, 423);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(49, 20);
            this.lblFees.TabIndex = 26;
            this.lblFees.Text = "????";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(162, 311);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "????";
            // 
            // lblDClass
            // 
            this.lblDClass.AutoSize = true;
            this.lblDClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDClass.Location = new System.Drawing.Point(162, 276);
            this.lblDClass.Name = "lblDClass";
            this.lblDClass.Size = new System.Drawing.Size(49, 20);
            this.lblDClass.TabIndex = 24;
            this.lblDClass.Text = "????";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppID.Location = new System.Drawing.Point(162, 241);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(49, 20);
            this.lblDLAppID.TabIndex = 23;
            this.lblDLAppID.Text = "????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fees: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Trial: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "D. Class: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "D.L.AppID: ";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(145, 175);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(293, 42);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "Scheduale Test";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Vision_512;
            this.pictureBox1.Location = new System.Drawing.Point(131, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 762);
            this.Controls.Add(this.grbTestVision);
            this.Name = "frmAddAppointment";
            this.Text = "frmAddAppointment";
            this.grbTestVision.ResumeLayout(false);
            this.grbTestVision.PerformLayout();
            this.grbRetakeInfo.ResumeLayout(false);
            this.grbRetakeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTestVision;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDClass;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grbRetakeInfo;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblRAppFees;
        private System.Windows.Forms.Label lblRTestAppID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}