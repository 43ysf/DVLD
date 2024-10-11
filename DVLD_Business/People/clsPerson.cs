using System;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using DVLD_Business;
using DVLD_DataAccess;

namespace DVLD_Business.People
{
    public class clsPerson
    {
        public int PersonID { set; get; }
        private enum enMode { AddNew =0, Update = 1 }

        private enMode _Mode = enMode.AddNew;
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public bool Gendor { set; get; }    

        public DateTime DateOfBirth { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }   
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }   
        public string ImagePath { set; get; }   

        
        public bool IsExist()
        {
            return clsPeople.IsExist(this.NationalNo);
        }
        public static bool IsExist(string No)
        {
            return clsPeople.IsExist(No);
        }

        public static bool IsExist(int ID)
        {
            return clsPeople.IsExist(ID);
        }

        private bool _AddNewPerson()
        {
            this.PersonID =  clsPeople.AddNewPerson( this.NationalNo,  FirstName,  this.SecondName,  this.ThirdName,  this.LastName,
                                        this.DateOfBirth,  this.Gendor,  this.Address,  this.Phone,  this.Email,  this.NationalityCountryID, this.ImagePath);
            return this.PersonID != -1;
        }

        private bool _UpdatePerson()
        {

            return clsPeople.Update(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
        }

        public static bool Delete(int ID)
        {
            return clsPeople.Delete(ID);
        }

        private clsPerson(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName, bool gendor, DateTime dateOfBirth, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            PersonID = personID;
            _Mode = enMode.Update;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            Gendor = gendor;
            DateOfBirth = dateOfBirth;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            ImagePath = imagePath;
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",  Address = "" , Phone = " ", Email = "", ImagePath = "";
            string NationalNo = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            bool Gendor = false;
            
            if (clsPeople.Find(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, Gendor, DateOfBirth, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }



        }
        public static clsPerson Find(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",  Address = "" , Phone = " ", Email = "", ImagePath = "";
            int  PersonID = -1;
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            bool Gendor = false;
            
            if (clsPeople.Find(ref PersonID,  NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, Gendor, DateOfBirth, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }



        }

        public clsPerson()
        {
            _Mode = enMode.AddNew;
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Gendor = false;
            this.DateOfBirth = DateTime.MinValue;
            this.Address = "";
            this.Phone = "";
            this.Email = "" ;
            this.NationalityCountryID = 0;
            this.ImagePath = "";


        }

        public bool Save()
        {
            switch( _Mode )
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePerson();

                default:
                    return false;
                   
            }
        }

        public static DataTable GetAllPeople()
        {
            return clsPeople.GetAllPeople();
        }

        public static string GetFullNamePerson(int ID)
        {
            return clsPeople.GetFullNameOfUser(ID);
        }



    }
}
