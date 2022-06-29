using EmployeeMnagementTemplated.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace EmployeeMnagementTemplated.ADO
{
    public class AuthenticationRepository
    {
        string connectionString = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;

        public bool RegisterUser(EmployeeUser user)
        {
            int resultCode = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "spRegisterUser";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    // open the sql connection.
                    connection.Open();

                    SqlParameter paramUserName = new SqlParameter { ParameterName = "@userName", SqlDbType = SqlDbType.VarChar, Value = user.UserName };
                    string encryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(user.Password, "SHA1");

                    SqlParameter paramPassword = new SqlParameter { ParameterName = "@password", SqlDbType = SqlDbType.VarChar, Value = encryptedPassword };
                   
                    //Adding parameter instance to sql command.
                    command.Parameters.Add(paramUserName);
                    command.Parameters.Add(paramPassword);                   
                    resultCode =Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return resultCode == 1;
        }

        public bool Login(EmployeeUser user)
        {
            int resultCode = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "spAuthenticateUser";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    // open the sql connection.
                    connection.Open();

                    SqlParameter paramUserName = new SqlParameter { ParameterName = "@userName", SqlDbType = SqlDbType.VarChar, Value = user.UserName };
                    string encryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(user.Password, "SHA1");

                    SqlParameter paramPassword = new SqlParameter { ParameterName = "@password", SqlDbType = SqlDbType.VarChar, Value = encryptedPassword };

                    //Adding parameter instance to sql command.
                    command.Parameters.Add(paramUserName);
                    command.Parameters.Add(paramPassword);
                    resultCode = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return resultCode == 1;
        }
    }
}