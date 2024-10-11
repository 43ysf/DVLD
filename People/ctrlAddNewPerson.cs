using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DVLD_Business.People;
using DVLD_Business.Countries;
using System.Text.RegularExpressions;
using DVLD.Properties;
using System.IO;
using System.Threading;

namespace DVLD_Presentation.People
{
    public partial class ctrlAddNewPerson : UserControl
    {
        public ctrlAddNewPerson()
        {
            InitializeComponent();
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            //btnClose.Click += btnClose_Click;
            _LoadComboBoxData();

        }




        public delegate void DataBackHandler(object Sender, int PersonID);
        public event DataBackHandler DataBack;  
     
        private string _NatinalNo = null;

        public ctrlAddNewPerson(ref clsPerson person)
        {

            InitializeComponent();
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            //btnClose.Click += btnClose_Click;
            _LoadComboBoxData();
            _NatinalNo = person.NationalNo;

        }

        public void LoadData(clsPerson person)
        {
            txtNationalNo.Text = person.NationalNo;
            txtFirsName.Text = person.FirstName;
            txtSecondName.Text = person.SecondName;
            txtThirdName.Text = person.ThirdName;
            txtLastName.Text = person.LastName;
            txtAddress.Text = person.Address;
            txtPhone.Text = person.Phone;
            txtEmail.Text = person.Email;
            lblPersonID.Text = person.PersonID.ToString();
            if(person.ImagePath != null  && person.ImagePath != "")
            {

                  pbImage.Image = Image.FromFile(person.ImagePath);
                
            }
            if (person.Gendor)
            {
                rbFemale.Checked = true;
            }
            else
                rbMale.Checked = true;

            dtpDateOfBirth.Text = person.DateOfBirth.ToString();
            //cbCountry.Text = clsCountry.GetCountryByID(person.NationalityCountryID);
            cbCountry.SelectedValue = person.NationalityCountryID;
            txtAddress.Text = "yousif is the king";
            Person = person;
            _NatinalNo = person.NationalNo;
        }

        private void _LoadComboBoxData()
        {
            cbCountry.DataSource = clsCountry.GitAllCountries();
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
            cbCountry.SelectedValue = 83;
        }
        public clsPerson Person = new clsPerson();

        private bool _IsImageSet = false;
        private bool _IsError = false;
        private void ChangeProfileImage()
        {
            if (!_IsImageSet)
            {
                pbImage.Image = rbMale.Checked ? Resources.Businessman : Resources.Businesswoman;

            }
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            ChangeProfileImage();
        }

        private string _CreateGuid()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString(); 
        }
        private void llbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _IsImageSet = true;
            ofdSetImage.Multiselect = true;
            ofdSetImage.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (ofdSetImage.ShowDialog() == DialogResult.OK)
            {
                string PicturePath = @"C:\PeoplePictures\" + _CreateGuid() + ".jpg";
                try
                {
                    File.Copy(ofdSetImage.FileName, PicturePath, true);
                    //MessageBox.Show(ofdSetImage.FileName);
                    pbImage.Image = Image.FromFile(PicturePath);
                    Person.ImagePath = PicturePath;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void _DeletePicture(string  picturePath)
        {
            try
            {
                if(File.Exists(picturePath))
                {
                    File.Delete(picturePath);
                }
                else
                {
                    MessageBox.Show("File Not found");
                }

            }catch(IOException ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }
        private void llbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             string ImagePath = Person.ImagePath;
            ChangeProfileImage();
            Person.ImagePath = "";
            _IsImageSet = false;
            _DeletePicture(ImagePath);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!_IsValidName(txtFirsName.Text))
            {
                MessageBox.Show("invalid first Name");
                return;
            }
            if (!_IsvalidEmail(txtEmail.Text))
            {
                MessageBox.Show("Valid Email", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!_IsValidNationalNo(txtNationalNo.Text))
            {
                MessageBox.Show("National Number is exist already","Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_IsError)
            {

                Person.NationalNo = txtNationalNo.Text;
                Person.FirstName = txtFirsName.Text;
                Person.SecondName = txtSecondName.Text;
                Person.ThirdName = txtThirdName.Text;
                Person.LastName = txtLastName.Text;
                Person.DateOfBirth = dtpDateOfBirth.Value;
                Person.Gendor = rbMale.Checked ? false : true;
                Person.Address = txtAddress.Text;
                Person.Email = txtEmail.Text;
                Person.Phone = txtPhone.Text;
                Person.NationalityCountryID = (int)cbCountry.SelectedValue;
                
                if (Person.Save())
                {
                    
                    MessageBox.Show("Person Saved Successfully");
                    lblPersonID.Text = Person.PersonID.ToString();

                    DataBack?.Invoke(this, Person.PersonID);

                    Form ParentForm = this.FindForm();
                        
                    if (ParentForm != null)
                    {
                        ParentForm.Close();
                    }

                }






            }
            else
            {
                MessageBox.Show("There is smoething wrong !", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }

        private void ofdSetImage_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           Form ParentForm = this.FindForm();
            if(ParentForm != null)
            {
                
                ParentForm.Close();
            }
        }

        private void txtNationlNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNationlNo_Validating(object sender, CancelEventArgs e)
        {
            if (_NatinalNo == null)
            {
                //Person.NationalNo = txtNationalNo.Text.Trim();
                if (clsPerson.IsExist(txtNationalNo.Text.Trim()))
                {
                    epNationalNo.SetError(txtNationalNo, "National Numberr Already Exist");
                    // e.Cancel = true;
                    _IsError = true;


                }
                else
                {
                    epNationalNo.SetError(txtNationalNo, "");
                    _IsError = false;
                }
            }
            else
            {
                if (Person.NationalNo != _NatinalNo)
                {
                    if (Person.IsExist())
                    {
                        epNationalNo.SetError(txtNationalNo, "National Numberr Already Exist");
                        // e.Cancel = true;
                        _IsError = true;

                    }
                }
            }

        }

        private bool _IsvalidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool _IsValidNationalNo(string NationalNo)
        {
            if (NationalNo == null)
            {

                return !clsPerson.IsExist(NationalNo);
            }
            else
            {
                return true;
            }
        }

        private bool _IsValidName(string name)
        {
            if(name == null || name.Trim() .Length == 0)
            {
                return false;
            }
            return true;
        }

        private void txtFirsName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1 = new ErrorProvider();
            if(string.IsNullOrEmpty(txtFirsName.Text))
            {
                errorProvider1.SetError(txtFirsName, "First name shoud not be empty");
            }

        }
    }
    
}
