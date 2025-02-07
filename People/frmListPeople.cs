using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_Business.People;

namespace DVLD.People
{
    public partial class frmListPeople : Form
    {
        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "GendorCaption", "DateOfBirth", "CountryName",
                                                         "Phone", "Email");


        ////only select the columns that you want to show in the grid
        //private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
        //                                                 "FirstName", "SecondName", "ThirdName", "LastName",
        //                                                 "GendorCaption", "DateOfBirth", "CountryName",
        //                                                 "Phone", "Email");

        private void _RefreshPeoplList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dgvListPeople.DataSource = _dtPeople;
        }

        public frmListPeople()
        {
            InitializeComponent();
            LoadDataToGirdView();
        }
        private void frmListPeople_Load(object sender, EventArgs e)
        {
            //dgvListPeople.DataSource = clsPerson.GetAllPeople();
            //dgvListPeople.Columns["ImagePath"].Visible = false;

            cbSearchBy.SelectedIndex = 0;
            txtFillter.Visible = false;
            dgvListPeople.DataSource = _dtPeople;

        }

        int SelectedID = -1;

        private void LoadDataToGirdView()
        {
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddOrUpdate frm = new frmAddOrUpdate();
            frm.ShowDialog();
            LoadDataToGirdView();
        }

        private void dgvListPeople_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvListPeople.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvListPeople.ClearSelection();
                    dgvListPeople.Rows[hitTestInfo.RowIndex].Selected = true;

                    // عرض القائمة المنسدلة
                    contextMenuStrip1.Show(dgvListPeople, e.Location);

                    //// الحصول على قيمة الـ ID من السطر المحدد
                    var selectedRow = dgvListPeople.Rows[hitTestInfo.RowIndex];
                    var idValue = selectedRow.Cells["PersonID"].Value; // تأكد من أن اسم العمود هو "ID"
                    if(idValue != null)
                        SelectedID = int.Parse(idValue.ToString());

                    //// يمكنك الآن استخدام idValue كما تريد
                    //MessageBox.Show("Selected ID: " + idValue.ToString());
                }
            }

        }


        private void personIformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var idValue = dgvListPeople.SelectedCells;
            frmPersonInfo frm = new frmPersonInfo(SelectedID);
            frm.ShowDialog();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure to delete this Account", "Delete Account", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsPerson.Delete(SelectedID))
                {
                    MessageBox.Show("Person Delete Successfuly ");
                }
                else
                    MessageBox.Show("This Person Linked in another places you can't delete it");
                LoadDataToGirdView();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrUpdate frm = new frmAddOrUpdate(clsPerson.Find(SelectedID));
            frm.ShowDialog();
        }

        private void frmListPeople_ResizeBegin(object sender, EventArgs e)
        {
            dgvListPeople.Width = this.Width;
        }

        private void frmListPeople_MaximumSizeChanged(object sender, EventArgs e)
        {
            dgvListPeople.Width = this.Width;

        }


        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFillter.Clear();
            if(txtFillter.Text == "None")
            {
                txtFillter.Visible = false;
            }
            else
            {
                txtFillter.Visible = true;
                if(txtFillter.Text == "PersonID")
                {
                    
                }
            }
        }

        private void txtFillter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbSearchBy.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFillter_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbSearchBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFillter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                //lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFillter.Text.Trim());
            else

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFillter.Text.Trim());

            //lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();


        }
    }
}