using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;
using DVLD.People;
using DVLD_Business;
using DVLD_Business.People;
using DVLD_Business.Users;

namespace DVLD.Users
{
    public partial class frmManageUsers : Form
    {
        clsUser CurrentUser = null;
        public frmManageUsers(clsUser CurrentUser)
        {
            InitializeComponent();
            //LoadDataToDataGrideView();
            //txtFilter.Visible = false;
            //cbFilterBy.Text = "None";
            //this.CurrentUser = CurrentUser;
        }
        private DataTable _dtAllUsers = null;
        public ComboBox cbIsActive = new ComboBox();
        private string _RowFiltter = "None";
        
        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void LoadDataToDataGrideView()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            string FullName = "";
            string s = "";
            dgvUsers.Columns.Clear();
            dgvUsers.Columns.Add("UserID", "UserID");
            dgvUsers.Columns.Add("PersonID", "PersonID");
            dgvUsers.Columns.Add("FullName", "FullName");
            dgvUsers.Columns.Add("UserName", "UserName");
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.HeaderText = "IsActive";
            col.Name = "IsActive";
            dgvUsers.Columns.Add(col);
            foreach (DataRow dr in _dtAllUsers.Rows) {
                FullName = clsPerson.GetFullNamePerson((int)dr["PersonID"]);
                dgvUsers.Rows.Add(dr["UserID"], dr["PersonID"], FullName, dr["UserName"], dr["IsActive"]);
                
            }
            lblNumberOfRecords.Text = dgvUsers.Rows.Count.ToString();
           
        }


        private void dgvListUsers_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvUsers.HitTest(e.X, e.Y);
                 if (hitTestInfo.RowIndex >= 0)
                {
                    dgvUsers.ClearSelection();
                    dgvUsers.Rows[hitTestInfo.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dgvUsers, e.Location);
                    //contextMenuStrip1.Show();
                }

           }

            if(e.Button == MouseButtons.Left)
            {
                var hitMouseInfo = dgvUsers.HitTest(e.X, e.Y);
                if(hitMouseInfo.RowIndex >= 0)
                {
                    dgvUsers.ClearSelection();
                    dgvUsers.Rows[hitMouseInfo.RowIndex].Selected = true;   

                }
            }
        }

        private void shwoDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // DataGridViewRow r = dgvListUsers.SelectedRows[0];
            // DataGridViewCell cell = r.Cells["PersonID"];

            // string ID =dgvListUsers.SelectedRows[0].Cells["PersonID"].Value.ToString();
            // MessageBox.Show(ID);
            // int PersonID = int.Parse(ID);
            //frmPersonInfo frm = new  frmPersonInfo(PersonID);
            // frm.ShowDialog();
            int UserID = (int)dgvUsers.SelectedRows[0].Cells["UserID"].Value;
            frmLoginInfo frm = new frmLoginInfo(UserID);
            frm.ShowDialog();
            _ReloadDataGirdView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse( dgvUsers.SelectedRows[0].Cells["UserID"].Value.ToString());
            //frmAddOrUpdate frm = new frmAddOrUpdate(PersonID);  
            //frm.ShowDialog();
            frmAddNewOrUpdateUser frm = new frmAddNewOrUpdateUser(UserID);
            frm.ShowDialog();
            //LoadDataToDataGrideView();
            
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewOrUpdateUser frm = new frmAddNewOrUpdateUser();
            frm.ShowDialog();
            //this.LoadDataToDataGrideView();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ReloadDataGirdView();

            

            string SelectedItem = cbFilterBy.Text.ToLower();

           //if(SelectedItem != "UserName")
           // {
           //     txtFilter.KeyPress += txtFilter_KeyPress;
           // }


           // if (SelectedItem == "UserID" || SelectedItem == "PersonID")
           // {
           //     txtFilter.Clear();
           //     txtFilter.Visible = true ;
           //     cbActive.Visible = false;
           //     txtFilter.KeyPress += new KeyPressEventHandler(txtFilter_KeyPress);

           // }
           // if(SelectedItem == "None")
           // {
           //     txtFilter.Clear();
           //     txtFilter.Visible = false;
           //     cbActive.Visible = false;
           // }
           // if(SelectedItem == "Username")
           // {
           //     txtFilter.Clear();
           //     txtFilter.Visible = true;
           //     txtFilter.KeyPress -= new KeyPressEventHandler(txtFilter_KeyPress);
           //     cbActive.Visible = false;
           // }
           // if(SelectedItem == "Active")
           // {
           //     txtFilter.Clear();
           //     txtFilter.Visible = false;
           //     cbActive.Visible = true;
           //     cbActive.SelectedText = "Yes";
           //     //AddComboBox();
           // }
           if(SelectedItem == "active")
            {
                _RowFiltter = "Active";
                cbActive.Visible = true;
                txtFilter.Visible = false;
                cbActive.Focus();
                cbActive.SelectedIndex = 0;
            }
           else
            {
                cbActive.Visible = false;
                if(SelectedItem == "username")
                {
                    txtFilter.Visible = true;
                    _RowFiltter = "UserName";
                    txtFilter.KeyPress -= new KeyPressEventHandler(txtFilter_KeyPress); 

                }
                else if (SelectedItem == "personid" ||  SelectedItem == "userid")
                {
                    txtFilter.Visible = true;
                    txtFilter.KeyPress += new KeyPressEventHandler(txtFilter_KeyPress);
                    if(SelectedItem == "personid")
                    {
                        _RowFiltter = "PersonID";

                    }
                    else
                    {
                        _RowFiltter = "UserID";
                    }
                }
                else
                {
                        txtFilter.Visible = false;
                        _RowFiltter = "None";
                   
                }
            }
            

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // منع الإدخال
            }
        }

        private void _SearchInDataGirdView(string Column)
        {
            string searchValue = txtFilter.Text.ToLower();
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                bool rowVisible = false;

                if (row.Cells[Column].Value != null && row.Cells[Column].Value.ToString().ToLower() == searchValue)
                {
                    rowVisible = true;

                }
                row.Visible = rowVisible;
                row.Selected = true;
             //  row.Cells[Column].Selected = true;
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            //if(string.IsNullOrWhiteSpace(txtFilter.Text))
            //{
            //    _ReloadDataGirdView();
            //}
            //else
            //{

            //    string SelectedItem = cbFilterBy.SelectedItem.ToString();
            //    switch (SelectedItem)
            //    {
            //        case "PersonID":
            //            _SearchInDataGirdView("PersonID");
            //            break;
            //        case "UserID":
            //            _SearchInDataGirdView("UserID");
            //            break;
            //        case "Username":
            //            _SearchInDataGirdView("Username");
            //            break;
            //        case ("Active"):
            //            _SearchInDataGirdView("IsActive");
            //            break;
            //        case "None":
            //            LoadDataToDataGrideView();
            //            break;

            //    }

            //}

            if(txtFilter.Text.Trim() == "" || _RowFiltter ==  "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = _dtAllUsers.Rows.Count.ToString();
                return;
            }
            if(_RowFiltter != "UserName")
            {
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", _RowFiltter, txtFilter.Text.Trim());

            }
            else
            {
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", _RowFiltter, txtFilter.Text.Trim());

            }
            lblNumberOfRecords.Text = _dtAllUsers.Rows.Count.ToString();





        }

        private void _ReloadDataGirdView()
        {
            foreach(DataGridViewRow row in dgvUsers.Rows)
            {
                row.Visible = true;
            }
        }
        private void cbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadDataToDataGrideView();

            string FilterColumn = "IsActive";
            string FilterValue = cbActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            //lblRecordsCount.Text = _dtAllUsers.Rows.Count.ToString();

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID =(int) dgvUsers.SelectedRows[0].Cells["UserID"].Value;
            if(UserID == CurrentUser.UserID)
            {
                MessageBox.Show("You can't delete current user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(clsUser.Delete(UserID))
            {
                MessageBox.Show("User Deleted Successfully");
                //LoadDataToDataGrideView(); 
            }
            else
            {
                MessageBox.Show("There is wrong", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.SelectedRows[0].Cells["UserID"].Value;
            frmChangePassword frm = new frmChangePassword(UserID);
            frm.ShowDialog();
            _ReloadDataGirdView();

        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            cbFilterBy.SelectedIndex = 0;
            cbActive.SelectedIndex = 0;
            lblNumberOfRecords.Text = dgvUsers.Rows.Count.ToString();

            dgvUsers.Columns[0].HeaderText = "User ID";
            dgvUsers.Columns[0].Width = 110;

            dgvUsers.Columns[1].HeaderText = "Person ID";
            dgvUsers.Columns[1].Width = 120;

            dgvUsers.Columns[2].HeaderText = "Full Name";
            dgvUsers.Columns[2].Width = 350;

            dgvUsers.Columns[3].HeaderText = "UserName";
            dgvUsers.Columns[3].Width = 120;

            dgvUsers.Columns[4].HeaderText = "Is Active";
            dgvUsers.Columns[4].Width = 120;


        }
    }
}
