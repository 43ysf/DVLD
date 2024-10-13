using DVLD_Business.Manage_Test_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Manage_Test_type
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void _LoadDataToDataGrid()
        {
            DataTable dataTable = clsTestType.GetAllTestTypes();
            dataGridView1.Columns.Clear();
            //dataGridView1.Columns.Add("")
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

    }
}
