using DVLD_Business.People;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business.Users
{
    public class clsUser
    {
        public string UserName { get; set; }    
        public string Password { get; set; }
        public int UserID { get; set; } 
        public int PersonID { set; get; }   
        public bool IsActive { get; set; }
        public clsPerson Person { get; set; }
        private enum enMode { Empty = 0, AddNew = 1, Update = 2 }

        private enMode _Mode = enMode.Empty;
        public clsUser()
        {
            UserName = "";
            Password = "";
            UserID = -1;
            PersonID = -1;
            Person = new clsPerson();
            _Mode = enMode.AddNew;

        }

        private clsUser( string username, string password, int userID, int personID, bool IsActive)
        {
            this.UserID = userID;
            this.UserName = username;
            this.Password = password;
            this.IsActive = IsActive;
            this.PersonID = personID;
            this._Mode = enMode.Update;
            this.Person = clsPerson.Find(this.PersonID);
        }

        public bool IsEmpty()
        {
            return this._Mode == enMode.Empty;
        }
        public static bool IsExist(string username)
        {
            return clsUsers.IsUserExist(username);  
        }

        public static clsUser Find(string username, string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            bool IsActive = false;  
            if(clsUsers.Find(username, Password, ref UserID, ref PersonID, ref IsActive ))
            {
                return new clsUser(username, Password, UserID, PersonID, IsActive);
            }
            else
            {
                return null;    
            }

        
        }

        public static clsUser Find(int UserID)
        {
            string UserName = "";
            string Password = "";
            int PersonID = -1;
            bool IsActive = false;
            if (clsUsers.Find(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserName, Password, UserID, PersonID, IsActive);
            }
            else
                return null;

        }

        public static bool IsPersonIDExists(int personID)
        {
            return clsUsers.IsPersonIDExistInUsers(personID);
        }


        public static DataTable GetAllUsers()
        {
            return clsUsers.GitAllUsers();
        }

        public string GetFullName()
        {
            return clsUsers.GetFullNameOfUser(this.PersonID);
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUsers.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return UserID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUsers.UpdateUser(UserID, UserName, Password, this.IsActive);
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if(_AddNewUser())
                        {
                            this._Mode = enMode.Update;
                            return true;

                        }
                        break;

                    }
                case enMode.Update:
                    {
                        return _UpdateUser();
                    }
                default:
                    {
                        return false;
                    }
            }
            return false;
        }

        public static bool Delete(int UserID)
        {
            return clsUsers.Delete(UserID);

            
        }

        


    }
}
