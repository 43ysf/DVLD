namespace DVLD.Users
{
    partial class frmManageUsers
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.shwoDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phonCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.ManageUsers;
            this.pictureBox1.Location = new System.Drawing.Point(95, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(191, 257);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(274, 42);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Manage Users";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(277, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 307);
            this.panel1.TabIndex = 2;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowDrop = true;
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsers.Location = new System.Drawing.Point(12, 385);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1160, 392);
            this.dgvUsers.TabIndex = 3;
            this.dgvUsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvListUsers_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shwoDetailsToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phonCallToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 172);
            // 
            // shwoDetailsToolStripMenuItem
            // 
            this.shwoDetailsToolStripMenuItem.Name = "shwoDetailsToolStripMenuItem";
            this.shwoDetailsToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.shwoDetailsToolStripMenuItem.Text = "Shwo Details";
            this.shwoDetailsToolStripMenuItem.Click += new System.EventHandler(this.shwoDetailsToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phonCallToolStripMenuItem
            // 
            this.phonCallToolStripMenuItem.Name = "phonCallToolStripMenuItem";
            this.phonCallToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.phonCallToolStripMenuItem.Text = "Phon call";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddNewUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewUser.BackgroundImage = global::DVLD.Properties.Resources.AddNewPerson;
            this.btnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewUser.FlatAppearance.BorderSize = 2;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Location = new System.Drawing.Point(1024, 315);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(148, 64);
            this.btnAddNewUser.TabIndex = 4;
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter by: ";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Active",
            "None",
            "PersonID",
            "UserID",
            "Username"});
            this.cbFilterBy.Location = new System.Drawing.Point(113, 351);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(226, 28);
            this.cbFilterBy.Sorted = true;
            this.cbFilterBy.TabIndex = 6;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(345, 352);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(342, 27);
            this.txtFilter.TabIndex = 7;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 817);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "#Recodrs: ";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(136, 817);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(48, 25);
            this.lblNumberOfRecords.TabIndex = 9;
            this.lblNumberOfRecords.Text = "???";
            // 
            // cbActive
            // 
            this.cbActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActive.FormattingEnabled = true;
            this.cbActive.Items.AddRange(new object[] {
            "All",
            "No",
            "Yes"});
            this.cbActive.Location = new System.Drawing.Point(345, 351);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(226, 28);
            this.cbActive.Sorted = true;
            this.cbActive.TabIndex = 10;
            this.cbActive.Visible = false;
            this.cbActive.SelectedIndexChanged += new System.EventHandler(this.cbActive_SelectedIndexChanged);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 851);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panel1);
            this.Name = "frmManageUsers";
            this.Text = "frmManageUsers";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shwoDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phonCallToolStripMenuItem;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.ComboBox cbActive;
    }
}