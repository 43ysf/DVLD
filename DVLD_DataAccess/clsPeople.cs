using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsPeople
    {
        public static int AddNewPerson( string NationalNo,  string firstName,  string SecondName,  string ThirdName,  string LastName,  DateTime DateOfBirth,  bool Gendore, 
            string Address,  string Phone, string Email,  int NationalityID,  string ImagePath)
        {
            string Query = @"INSERT INTO [dbo].[People]
           ([NationalNo]
           ,[FirstName]
           ,[SecondName]
           ,[ThirdName]
           ,[LastName]
           ,[DateOfBirth]
           ,[Gendor]
           ,[Address]
           ,[Phone]
           ,[Email]
           ,[NationalityCountryID]
           ,[ImagePath])
     VALUES
           (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth) ;
            command.Parameters.AddWithValue("@Gendor", Gendore);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityID);
            if(ImagePath == null || ImagePath == "")
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            return CRUD.AddNew(command);

        }
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            string Query = "Select * From People";
            SqlCommand command = new SqlCommand(Query) ;
            return CRUD.GetAll(command);
        }


        public static bool Delete(int ID)
        {
            string Query = @"DELETE FROM [dbo].[People]
                                 WHERE PersonID = @ID;";
            SqlCommand command = new SqlCommand(Query);
            command.Parameters.AddWithValue("@ID", ID);
            return CRUD.UpdateOrDelete(command);
        }


        public static bool Update(int PersonID, string nationnalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, bool Gendor, string Address,
            string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            string Query = @"Update People Set
                           NationalNO = @NationalNo,
                           FirstName = @FirstName,
                           SecondName = @SecondName,
                           ThirdName = @ThirdName,
                           LastName = @LastName,
                           DateOfBirth = @DateOfBirth,
                           Gendor = @Gendor,
                           Address = @Address,
                           Phone = @Phone,
                           Email = @Email,
                           NationalityCountryID = @NationalityCountryID,
                           ImagePath = @ImagePath
                           Where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(Query);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNO", nationnalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != null || ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if(Email != null|| Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "" || ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath) ;

            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            


            return CRUD.UpdateOrDelete(command);

        }

        public static bool Find(int PersonID,ref string nationalNo,ref string FirstName, ref string SecondName,
           ref string ThirdName,ref string LastName, ref DateTime DateOfBirth, ref bool Gendor, ref string Address, ref
            string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            string Query = @"Select * From People Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    nationalNo = reader["NationalNo"].ToString();
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = reader["ThirdName"].ToString();
                    }
                    else
                        ThirdName = "";
                    LastName = reader["LastName"].ToString();
                    DateOfBirth = DateTime.Parse(reader["DateofBirth"].ToString()).Date;
                    Gendor = Convert.ToBoolean(reader["Gendor"]);
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();
                    Email = reader["Email"].ToString();
                    NationalityCountryID = int.Parse(reader["NationalityCountryID"].ToString());
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = reader["ImagePath"].ToString();
                    }
                    else
                        ImagePath = "";


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



            return isFound;
        }



        public static bool Find(ref int PersonID, string nationalNo,ref string FirstName, ref string SecondName,
           ref string ThirdName,ref string LastName, ref DateTime DateOfBirth, ref bool Gendor, ref string Address, ref
            string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            string Query = @"Select * From People Where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", nationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = reader["ThirdName"].ToString();
                    }
                    else
                    ThirdName = "";
                    LastName = reader["LastName"].ToString();
                    DateOfBirth = DateTime.Parse(reader["DateofBirth"].ToString()).Date;
                    Gendor = Convert.ToBoolean(reader["Gendor"]);
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();
                    Email = reader["Email"].ToString();
                    NationalityCountryID = int.Parse(reader["NationalityCountryID"].ToString());
                    if (reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = "";
                    }
                    else
                        ImagePath = reader["ImagePath"].ToString();


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



            return isFound;
        }



       


        public static bool IsExist(string NationalNo)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            string Query = "Select * From People Where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int r) )
                {
                    isFound = Convert.ToBoolean(r);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message) ;
                    
            }
            finally
            {
                connection.Close() ;
            }
            return isFound;
        }


        public static bool IsExist(int PersonID)
        {
            string Query = "Select * From People Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            return CRUD.IsExist(command);
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
            catch (Exception ex)
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
