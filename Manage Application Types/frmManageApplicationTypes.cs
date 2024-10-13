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

        public frmManageApplicationTypes()
        {
            InitializeComponent();
            _FillDataGridVeiwData();
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
            _FillDataGridVeiwData();
        }

        public void Edit(string Title)
        {
            this.lbTitle.Text = Title;
        }
    }
}
