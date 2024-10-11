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
        public frmListPeople()
        {
            InitializeComponent();
            LoadDataToGirdView();
        }
        private void frmListPeople_Load(object sender, EventArgs e)
        {
            //dgvListPeople.DataSource = clsPerson.GetAllPeople();
            //dgvListPeople.Columns["ImagePath"].Visible = false;

        }

        int SelectedID = -1;

        private void LoadDataToGirdView()
        {
            dgvListPeople.Columns.Clear();
            DataTable dt = clsPerson.GetAllPeople();
            dgvListPeople.Columns.Add("PersonID", "PersonID");
            dgvListPeople.Columns.Add("First Name", "FirstName");
            dgvListPeople.Columns.Add("SecondName", "SecondName");
            dgvListPeople.Columns.Add("ThirdName", "ThirdName");
            dgvListPeople.Columns.Add("LastName", "LastName");
            dgvListPeople.Columns.Add("DateOfBirth", "DateOfBirth");
            dgvListPeople.Columns.Add("Gendor", "Gendor");
            dgvListPeople.Columns.Add("Address", "Address");
            dgvListPeople.Columns.Add("Phone", "Phone");
            dgvListPeople.Columns.Add("Email", "Email");
            foreach (DataRow row in dt.Rows)
            {
                string Gendor = "Female";
                Gendor = Convert.ToBoolean(row["Gendor"]) ? "Female" : "Male";
                DateTime dob = (DateTime)row["DateOfBirth"];
                dob = dob.Date;
                dgvListPeople.Rows.Add(row["PersonID"], row["FirstName"], row["SecondName"], row["ThirdName"], row["LastName"], dob, Gendor, row["Address"], row["Phone"], row["Email"]);

            }
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
    }
}