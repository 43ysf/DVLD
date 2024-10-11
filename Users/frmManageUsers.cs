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
        public frmManageUsers()
        {
            InitializeComponent();
            LoadDataToDataGrideView();
            txtFilter.Visible = false;
            cbFilterBy.Text = "None";
        }

        public ComboBox cbIsActive = new ComboBox();
        
        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void LoadDataToDataGrideView()
        {
            DataTable dt = clsUser.GetAllUsers();
            string FullName = "";
            dgvListUsers.Columns.Clear();
            dgvListUsers.Columns.Add("UserID", "UserID");
            dgvListUsers.Columns.Add("PersonID", "PersonID");
            dgvListUsers.Columns.Add("FullName", "FullName");
            dgvListUsers.Columns.Add("UserName", "UserName");
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            col.HeaderText = "IsActive";
            col.Name = "IsActive";
            dgvListUsers.Columns.Add(col);
            foreach (DataRow dr in dt.Rows) {
                FullName = clsPerson.GetFullNamePerson((int)dr["PersonID"]);
                dgvListUsers.Rows.Add(dr["UserID"], dr["PersonID"], FullName, dr["UserName"], dr["IsActive"]);
                
            }
            lblNumberOfRecords.Text = dgvListUsers.Rows.Count.ToString();
           
        }


        private void dgvListUsers_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvListUsers.HitTest(e.X, e.Y);
                 if (hitTestInfo.RowIndex >= 0)
                {
                    dgvListUsers.ClearSelection();
                    dgvListUsers.Rows[hitTestInfo.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dgvListUsers, e.Location);
                    var cell = dgvListUsers.SelectedRows[0].Cells["UserID"];
                    int IDValue = int.Parse(cell.Value.ToString());
                    //contextMenuStrip1.Show();
                }

           }

            if(e.Button == MouseButtons.Left)
            {
                var hitMouseInfo = dgvListUsers.HitTest(e.X, e.Y);
                if(hitMouseInfo.RowIndex >= 0)
                {
                    dgvListUsers.ClearSelection();
                    dgvListUsers.Rows[hitMouseInfo.RowIndex].Selected = true;   

                }
            }
        }

        private void shwoDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgvListUsers.SelectedRows[0];
            DataGridViewCell cell = r.Cells["PersonID"];

            string ID =dgvListUsers.SelectedRows[0].Cells["PersonID"].Value.ToString();
            MessageBox.Show(ID);
            int PersonID = int.Parse(ID);
           frmPersonInfo frm = new  frmPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = int.Parse( dgvListUsers.SelectedRows[0].Cells["UserID"].Value.ToString());
            //frmAddOrUpdate frm = new frmAddOrUpdate(PersonID);  
            //frm.ShowDialog();
            frmAddNewOrUpdateUser frm = new frmAddNewOrUpdateUser(UserID);
            frm.ShowDialog();
            LoadDataToDataGrideView();
            
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewOrUpdateUser frm = new frmAddNewOrUpdateUser();
            frm.ShowDialog();
            this.LoadDataToDataGrideView();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ReloadDataGirdView();

            string SelectedItem = cbFilterBy.SelectedItem.ToString();
            if (SelectedItem == "UserID" || SelectedItem == "PersonID")
            {
                txtFilter.Clear();
                txtFilter.Visible = true ;
                cbActive.Visible = false;
                txtFilter.KeyPress += new KeyPressEventHandler(txtFilter_KeyPress);

            }
            if(cbFilterBy.SelectedText == "None")
            {
                txtFilter.Visible = false;
                cbActive.Visible = false;
            }
            if(SelectedItem == "None")
            {

                txtFilter.Clear();
                txtFilter.Visible = false;
                cbActive.Visible = false;
            }
            if(SelectedItem == "Username")
            {
                txtFilter.Clear();
                txtFilter.Visible = true;
                txtFilter.KeyPress -= new KeyPressEventHandler(txtFilter_KeyPress);
                cbActive.Visible = false;
            }
            if(SelectedItem == "Active")
            {
                txtFilter.Clear();
                txtFilter.Visible = false;
                cbActive.Visible = true;
                cbActive.SelectedText = "Yes";
                //AddComboBox();
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
            foreach (DataGridViewRow row in dgvListUsers.Rows)
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
            if(string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                _ReloadDataGirdView();
            }
            else
            {

                string SelectedItem = cbFilterBy.SelectedItem.ToString();
                switch (SelectedItem)
                {
                    case "PersonID":
                        _SearchInDataGirdView("PersonID");
                        break;
                    case "UserID":
                        _SearchInDataGirdView("UserID");
                        break;
                    case "Username":
                        _SearchInDataGirdView("Username");
                        break;
                    case ("Active"):
                        _SearchInDataGirdView("IsActive");
                        break;
                    case "None":
                        LoadDataToDataGrideView();
                        break;

                }

            }




        }

        private void _ReloadDataGirdView()
        {
            foreach(DataGridViewRow row in dgvListUsers.Rows)
            {
                row.Visible = true;
            }
        }
        private void cbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadDataToDataGrideView();
            _ReloadDataGirdView();
            string searchValue = cbActive.SelectedItem.ToString().ToLower();
            if(searchValue == "all")
            {
                return;
            }
            foreach (DataGridViewRow row in dgvListUsers.Rows)
            {

                if ( ((bool)row.Cells["IsActive"].Value == false) && searchValue == "no" )
                {
                    row.Visible = true;
                }
                
              else  if((bool)row.Cells["IsActive"].Value ==  true && searchValue == "yes")
                {
                    row.Visible = true;
                }
                
               else
                {
                    row.Visible = false;
                }
            }


        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID =(int) dgvListUsers.SelectedRows[0].Cells["UserID"].Value;
            if(clsUser.Delete(UserID))
            {
                MessageBox.Show("User Deleted Successfully");
                LoadDataToDataGrideView(); 
            }
            else
            {
                MessageBox.Show("There is wrong", "Worning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvListUsers.SelectedRows[0].Cells["UserID"].Value;
            frmChangePassword frm = new frmChangePassword(UserID);
            frm.ShowDialog();
            _ReloadDataGirdView();

        }
    }
}
