using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD_Business;
using DVLD_Business.Countries;
using DVLD_Business.People;
using DVLD_Business.Users;


namespace DVLD.People
{
    public partial class ctrlPersonInfo : UserControl
    {
        public ctrlPersonInfo()
        {
            InitializeComponent();
            linkLabel1.Visible = false;
        }

        clsPerson Person = null;
        public  void FillPersonInfo(clsPerson person)
        {
            linkLabel1.Visible = true;
            this.Person = person;
            lblPersonID.Text = person.PersonID.ToString();
            lblName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
            lblNationalNo.Text = person.NationalNo.ToString();
            lblGendor.Text = person.Gendor ? "Female" : "Male";
            lblEmail.Text = person.Email;
            lblAddress.Text = person.Address;
            lblDateOfBirth.Text = person.DateOfBirth.ToShortDateString().ToString() ;
            lblPhone.Text = person.Phone;
            lblCountry.Text = clsCountry.GetCountryByID(person.NationalityCountryID);
            if (Person.ImagePath != null && Person.ImagePath != "")
            {
                //MessageBox.Show(Person.ImagePath.ToString());

                pbImage.Image = Image.FromFile(person.ImagePath);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmAddOrUpdate frm = new frmAddOrUpdate(Person);
            frm.ShowDialog();
            Person = clsPerson.Find(Person.PersonID);
            this.FillPersonInfo(Person) ;
        }
    }
}
