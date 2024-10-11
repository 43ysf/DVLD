using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business.Countries
{
    public  class clsCountry
    {
        public int CountryID { set; get; }
        public string CountryName { set; get; } 


        public static DataTable GitAllCountries()
        {
            return clsCountries.GetAllCountries();
        }

        public static string GetCountryByID(int id)
        {
            return clsCountries.GetCountryByID(id);
        }


    }
}
