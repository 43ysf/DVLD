using DVLD_Business.People;
using DVLD_Presentation.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmAddOrUpdate : Form
    {
        public frmAddOrUpdate()
        {
            InitializeComponent();
            ctrlMyAdd.DataBack += GetData;
        }

        public void GetData(object sender, int PersonID)
        {
            _PersonID = PersonID;
        }

       public int _PersonID = -1;
        public frmAddOrUpdate(int PersonID)
        {
            clsPerson person = clsPerson.Find(PersonID);
            InitializeComponent();
            lblTitle.Text = "Update Person Info ";
            //ctrlAddOrUpdate = new ctrlAddNewPerson(person);
            ctrlMyAdd.LoadData(person);
        }

        public frmAddOrUpdate(clsPerson person)
        {
            InitializeComponent();
            lblTitle.Text = "Update Person Info ";
            //ctrlAddOrUpdate = new ctrlAddNewPerson(person);
            ctrlMyAdd.LoadData(person);
        }

        private void ctrlAddOrUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
