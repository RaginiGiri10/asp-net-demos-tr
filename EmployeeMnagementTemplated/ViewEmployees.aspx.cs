using EmployeeMnagementTemplated.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeMnagementTemplated
{
    public partial class ViewEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                LoadEmployees();
            }

        }

        protected void lnkDelete_Click(object sender, EventArgs e)
        {
            string commandArgument = (sender as LinkButton).CommandArgument;
            int selectedId = Convert.ToInt32(commandArgument);
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.RemoveEmployee(selectedId);
            LoadEmployees();

        }

        private void LoadEmployees()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            var employees = employeeRepository.GetEmployees();
            gridEmployees.DataSource = employees;
            gridEmployees.DataBind();
        }
    }
}