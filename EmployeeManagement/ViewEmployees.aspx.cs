using EmployeeManagement.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class ViewEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            var employees = employeeRepository.GetEmployees();

            gridEmployees.DataSource = employees;
            gridEmployees.DataBind();
        }

        protected void lnkSelect_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as LinkButton).CommandArgument);
        }
    }
}