using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Properties;
using DVLD_Business;
using DVLD_Business.ApplicationTypes;

namespace DVLD.Manage_Application_Types
{
    public partial class frmManageApplicationTypes : Form
    {
        DataTable _Applications;
        public frmManageApplicationTypes()
        {
            InitializeComponent();
            //_FillDataGridVeiwData();
        }
        
        private void _FillDataGridVeiwData()
        {
            DataTable dt = clsApplicationType.GettAllApplicationTypes();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Fees", "Fees");
            foreach(DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["ApplicationTypeID"], dr["ApplicationTypeTitle"], dr["ApplicationFees"]);
            }
            lblNumberOfRecords.Text = dt.Rows.Count.ToString(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hitTestInfo.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                }

            }

            //if (e.Button == MouseButtons.Left)
            //{
            //    var hitMouseInfo = dgvListUsers.HitTest(e.X, e.Y);
            //    if (hitMouseInfo.RowIndex >= 0)
            //    {
            //        dgvListUsers.ClearSelection();
            //        dgvListUsers.Rows[hitMouseInfo.RowIndex].Selected = true;

            //    }
            //}

        }

        private void EditApplicationType(object sender, EventArgs e)
        {
            int ApplicationID =(int) dataGridView1.SelectedRows[0].Cells["ID"].Value;
            frmEditApplicationType frm = new frmEditApplicationType( ApplicationID);
            frm.ShowDialog();
            //_FillDataGridVeiwData();
            frmManageApplicationTypes_Load(null, null);
        }

        public void Edit(string Title)
        {
            this.lbTitle.Text = Title;
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _Applications = clsApplicationType.GettAllApplicationTypes();
            dataGridView1.DataSource = _Applications;
            lblNumberOfRecords.Text = dataGridView1.Rows.Count.ToString();

            if(dataGridView1.Rows.Count > 0 )
            {
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[0].Width = 110;

                dataGridView1.Columns[1].HeaderText = "Title";
                dataGridView1.Columns[1].Width = 400;


                dataGridView1.Columns[2].HeaderText = "Fees";
                dataGridView1.Columns[2].Width = 100;


                //dataGridView1.Columns[3].HeaderText = "Fees";
                //dataGridView1.Columns[3].Width = 100;
            }
        }
    }
}
