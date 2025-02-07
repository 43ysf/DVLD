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
using DVLD_Business.Users;

namespace DVLD.People
{
    public partial class ctrlFindOrAddUser : UserControl
    {
        private int _PersonID = -1;
        clsPerson Person = null;

        public Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler  = OnPersonSelected;
            if (handler != null )
            {
                handler(PersonID);
            }
        }
        public ctrlFindOrAddUser()
        {
            InitializeComponent();
            cbFilterBy.SelectedIndex = 0;
            txtSearch.Focus(); 
            //txtSearch.KeyDown += new KeyEventHandler(txtSearch_KeyDown);
        }

        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;
        private void GetDataBack(object sender, int PersonID)
        {
            _PersonID = PersonID;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = cbFilterBy.SelectedItem.ToString();
            if(SelectedItem == "National No")
            {
                txtSearch.KeyPress -= new KeyPressEventHandler(txtFilter_KeyPress); 
            }
            else
            {
                txtSearch.KeyPress += new KeyPressEventHandler(txtFilter_KeyPress);
            }
        }
        private void _MssageBox(string Message, string Title)
        {
             MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string SelectedItem = cbFilterBy.SelectedItem.ToString();
            if (SelectedItem == "National No")
            {
                if (clsPerson.IsExist(txtSearch.Text))
                {
                    int PersonID = Convert.ToInt32(txtSearch.Text);
                    Person = clsPerson.Find(txtSearch.Text);

                    if (OnPersonSelected != null)
                        PersonSelected(PersonID);
                }
                else
                {
                    _MssageBox("This Person not found! ", "Erorr");
                    return;

                }


            }
            else
            {
                txtSearch.KeyPress += new KeyPressEventHandler(txtFilter_KeyPress);
                int r = 0;
                if (clsPerson.IsExist(int.Parse(txtSearch.Text)))
                {
                    Person = clsPerson.Find(int.Parse(txtSearch.Text));
                }
                else
                {
                    _MssageBox("This Person not found! ", "Erorr");
                    return;

                }
            }
            DataBack?.Invoke(this, Person.PersonID);
            _PersonID = Person.PersonID;
            ctrlPersonInfo1.FillPersonInfo(Person);
            //Find();
        }

        private void Find()
        {
            txtSearch.Text = _PersonID.ToString();
            //cbFilterBy.SelectedValue = "PersonID";
            Person = clsPerson.Find(_PersonID);
            ctrlPersonInfo1.FillPersonInfo(Person);
        }
        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // منع الإدخال إذا لم يكن رقمًا
            }
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddOrUpdate frm = new frmAddOrUpdate();
            frm.ShowDialog();
            _PersonID = frm._PersonID;
            Person =  clsPerson.Find(_PersonID);
            if (OnPersonSelected != null && Person != null)
                PersonSelected(_PersonID);
                

            if(Person != null)
            {
                ctrlPersonInfo1.FillPersonInfo(Person);
                DataBack?.Invoke(this, Person.PersonID);
            }

        }

        private void ctrlFindOrAddUser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnFind.PerformClick();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                e.SuppressKeyPress = true;
                btnFind.PerformClick();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdateMode(clsUser user)
        {
            this.gbFindOrAdd.Enabled = false;
            this.ctrlPersonInfo1.FillPersonInfo(user.Person);
        }
        private void gbFindOrAdd_Enter(object sender, EventArgs e)
        {

        }

        public void grbFindOrAddGrbEnable( int PersonID, bool Enable = false )
        {
            gbFindOrAdd.Enabled = Enable;   
            _PersonID = PersonID;
            MessageBox.Show(_PersonID.ToString());
            Find();
           

            //btnFind_Click();
        }
    }
}
