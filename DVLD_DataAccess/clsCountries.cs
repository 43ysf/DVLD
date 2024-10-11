using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public static class clsCountries
    {
        public static DataTable GetAllCountries()
        {
            string Query = @"Select * From Countries;";
            SqlCommand command = new SqlCommand(Query);
            return CRUD.GetAll(command);
        }
        public static string GetCountryByID(int id)
        {
            SqlConnection connection = new SqlConnection(clsSettings.connectionString);
            string Query = @"Select CountryName From Countries Where CountryID = @CountryID";
            SqlCommand command = new SqlCommand(Query, connection) ;
            command.Parameters.AddWithValue("@CountryID", id);
            string CountryName = "";
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    CountryName = result.ToString();
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
            return CountryName;
        }
    }
}
