using EmployeeMnagementTemplated.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeMnagementTemplated.ADO
{
    public class CountryRepository
    {
        string connectionString = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;

        public List<Country> GetCountries()
        {
            List<Country> countryList = new List<Country>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "spGetCountries";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Country country = new Country();
                        country.Id = Convert.ToInt32(reader["Id"]);
                       country.CountryName = Convert.ToString(reader["CountryName"]);
                        countryList.Add(country);
                    }
                }

            }
            return countryList;
        }
    }
}