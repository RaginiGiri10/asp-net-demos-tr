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
    public class EmployeeRepository
    {

        string connectionString = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
        public void AddEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "spAddEmployee";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    // open the sql connection.
                    connection.Open();

                    SqlParameter paramFirstName = new SqlParameter { ParameterName = "@firstName", SqlDbType = SqlDbType.VarChar, Value = employee.FirstName };
                    SqlParameter paramLastName = new SqlParameter { ParameterName = "@lastName", SqlDbType = SqlDbType.VarChar, Value = employee.LastName };
                    SqlParameter paramGender = new SqlParameter { ParameterName = "@gender", SqlDbType = SqlDbType.VarChar, Value = employee.Gender };
                    SqlParameter paramCountry = new SqlParameter { ParameterName = "@country", SqlDbType = SqlDbType.VarChar, Value = employee.Country };
                    //Adding parameter instance to sql command.
                    command.Parameters.Add(paramFirstName);
                    command.Parameters.Add(paramLastName);
                    command.Parameters.Add(paramGender);
                    command.Parameters.Add(paramCountry);
                    command.ExecuteNonQuery();

                }
            }
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "spViewAllEmployees";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.Id = Convert.ToInt32(reader["Id"]);
                        employee.FirstName = Convert.ToString(reader["FirstName"]);
                        employee.LastName = Convert.ToString(reader["LastName"]);
                        employee.Gender = Convert.ToString(reader["Gender"]);
                        employee.Country = Convert.ToString(reader["Country"]);
                        employeeList.Add(employee);
                    }
                }

            }
            return employeeList;
        }

        public void RemoveEmployee(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "spDeleteEmployee";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;                   
                    connection.Open();
                    SqlParameter paramId = new SqlParameter { ParameterName = "@id", SqlDbType = SqlDbType.Int, Value = id };                   
                    command.Parameters.Add(paramId);
                    command.ExecuteNonQuery();

                }
            }
        }
    }
}