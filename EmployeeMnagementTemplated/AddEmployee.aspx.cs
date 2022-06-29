using EmployeeMnagementTemplated.ADO;
using EmployeeMnagementTemplated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeMnagementTemplated
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                LoadCountries();
                ResetForm();
            }
        }

        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                Employee employee = new Employee();
                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtLastName.Text;
                employee.Gender = radioGenderList.SelectedValue;
                employee.Country = ddlCountries.SelectedValue;
                EmployeeRepository employeeRepository = new EmployeeRepository();
                employeeRepository.AddEmployee(employee);
                ResetForm();
                Server.Transfer("ViewEmployees.aspx");
               // Response.Redirect("ViewEmployees.aspx");
            }
        }

        private void ResetForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            radioGenderList.ClearSelection();

        }

        private void LoadCountries()
        {
            CountryRepository countryRepository = new CountryRepository();
            var countryList = countryRepository.GetCountries();
            ddlCountries.DataSource = countryList;
            ddlCountries.DataTextField = "CountryName";
            ddlCountries.DataValueField = "CountryName";
            ddlCountries.DataBind();
        }
    }
}