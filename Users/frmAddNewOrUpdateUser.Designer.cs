namespace DVLD.Users
{
    partial class frmAddNewOrUpdateUser
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.ctrlFindPerson = new DVLD.People.ctrlFindOrAddUser();
            this.tbLoginInfo = new System.Windows.Forms.TabPage();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlFindOrAddUser1 = new DVLD.People.ctrlFindOrAddUser();
            this.tabControl1.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tbLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(862, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPersonInfo);
            this.tabControl1.Controls.Add(this.tbLoginInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 642);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.ctrlFindPerson);
            this.tpPersonInfo.Controls.Add(this.button1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1018, 613);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlFindPerson
            // 
            this.ctrlFindPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlFindPerson.Location = new System.Drawing.Point(3, 3);
            this.ctrlFindPerson.Name = "ctrlFindPerson";
            this.ctrlFindPerson.Size = new System.Drawing.Size(1012, 543);
            this.ctrlFindPerson.TabIndex = 0;
            this.ctrlFindPerson.Load += new System.EventHandler(this.ctrlFindPerson_Load);
            // 
            // tbLoginInfo
            // 
            this.tbLoginInfo.Controls.Add(this.cbIsActive);
            this.tbLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tbLoginInfo.Controls.Add(this.txtPassword);
            this.tbLoginInfo.Controls.Add(this.txtUserName);
            this.tbLoginInfo.Controls.Add(this.lblUserID);
            this.tbLoginInfo.Controls.Add(this.label4);
            this.tbLoginInfo.Controls.Add(this.label3);
            this.tbLoginInfo.Controls.Add(this.label2);
            this.tbLoginInfo.Controls.Add(this.label1);
            this.tbLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tbLoginInfo.Name = "tbLoginInfo";
            this.tbLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbLoginInfo.Size = new System.Drawing.Size(1018, 613);
            this.tbLoginInfo.TabIndex = 1;
            this.tbLoginInfo.Text = "Login Info";
            this.tbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(201, 246);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(79, 20);
            this.cbIsActive.TabIndex = 17;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Location = new System.Drawing.Point(201, 174);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(190, 22);
            this.txtConfirmPassword.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(201, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(190, 22);
            this.txtPassword.TabIndex = 15;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(201, 118);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(190, 22);
            this.txtUserName.TabIndex = 14;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(195, 76);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(46, 32);
            this.lblUserID.TabIndex = 13;
            this.lblUserID.Text = "????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirm Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "UserName: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "UserID: ";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Cairo", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(410, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(223, 62);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Add New User";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(910, 705);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(776, 705);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlFindOrAddUser1
            // 
            this.ctrlFindOrAddUser1.Location = new System.Drawing.Point(-36, -237);
            this.ctrlFindOrAddUser1.Name = "ctrlFindOrAddUser1";
            this.ctrlFindOrAddUser1.Size = new System.Drawing.Size(480, 148);
            this.ctrlFindOrAddUser1.TabIndex = 0;
            // 
            // frmAddNewOrUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 767);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ctrlFindOrAddUser1);
            this.Name = "frmAddNewOrUpdateUser";
            this.Text = "clsAddNewOrUpdate";
            this.tabControl1.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tbLoginInfo.ResumeLayout(false);
            this.tbLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private People.ctrlFindOrAddUser ctrlFindOrAddUser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private People.ctrlFindOrAddUser ctrlFindPerson;
        private System.Windows.Forms.TabPage tbLoginInfo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}