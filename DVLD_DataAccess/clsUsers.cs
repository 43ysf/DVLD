using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_DataAccess
{
    public static  class clsUsers
    {
        public static DataTable GitAllUsers()
        {
            string Query = "Select * From Users;";
            SqlCommand cmd = new SqlCommand(Query);
            return CRUD.GetAll(cmd);
        }

        public static int AddNewUser(int PersonID, string username, string password, bool IsActive)
        {
            string Query = "Insert into users  Values (@PersonID, @UserName, @Password, @IsActive); " +
                "SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(Query);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            //if (IsActive)
            //    cmd.Parameters.AddWithValue("@IsActive", 1);
            //else
            //    cmd.Parameters.AddWithValue("@IsActive", 0);

            return CRUD.AddNew(cmd);
        }

        public static bool IsUserExist(string username)
        {
            string Query = "Select* From Users Where UserName = @UserName;";
            SqlCommand cmd = new SqlCommand(Query);
            cmd.Parameters.AddWithValue("@UserName", username);  



            return CRUD.IsExist(cmd);
            
        }
        public static bool IsUserExist(int UserID)
        {
            string Query = "Select * From Users Where UserID = @UserID";
            SqlCommand command = new SqlCommand(Query);
            command.Parameters.AddWithValue("@UserID", UserID);
            return CRUD.IsExist(command);   
        }

        public static bool IsPersonIDExistInUsers(int PersonID)
        {
            string Query = "Select * From Users Where PersonID = @PesrsonID";
            SqlCommand command = new SqlCommand(Query);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            return CRUD.IsExist(command);

        }

        public static bool Find(string UserName, string Password, ref int UserID, ref int PersonID, ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            string Query = "Select * From Users Where UserName = @UserName and Password = @Password";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            bool IsFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive =(bool) reader["IsActive"];
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());   
            }
            finally 
            { 
                connection.Close();
            }


           

            return IsFound;
        }

        public static bool Find(int UserID, ref int PersonID, ref string UserName, ref string Passowrd, ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            string Query = "Select * From Users Where UserID = @UserID";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            bool IsFound = false;   
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserName = reader["UserName"].ToString();
                    Passowrd = reader["Password"].ToString();
                    IsActive = (bool)reader["IsActive"];
                    IsFound = true;
                }
                reader.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
            
        }

        public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive)
        {
            string Query = "Update Users Set UserName = @UserName, Password = @Password, IsActive = @IsActive where UserID = @UserID";
            SqlCommand cmd = new SqlCommand(Query);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            return CRUD.UpdateOrDelete(cmd);
        }

        public static bool Delete(int UserID)
        {
            string Query = "Delete From Users Where UserID = @UserID";
            SqlCommand cmd = new SqlCommand(Query);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            return CRUD.UpdateOrDelete(cmd) ;
        }

        public static string GetFullNameOfUser(int PersonID)
        {
            string Query = @"Select FullName From FullNames Where PersonID = @PersonID";
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            string FullName = "";
            try
            {
                connection.Open();
                object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    FullName = obj.ToString();
                }
                else
                {
                    FullName = "";
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return FullName;
        }


    }
}
