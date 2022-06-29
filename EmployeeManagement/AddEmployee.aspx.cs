using EmployeeManagement.ADO;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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

                if (radioMale.Checked)
                {
                    employee.Gender = radioMale.Text;
                }
                else if (radioFemale.Checked)
                {
                    employee.Gender = radioFemale.Text;
                }


                EmployeeRepository employeeRepository = new EmployeeRepository();
                employeeRepository.AddEmployee(employee);
                ResetForm();
            }
           
        }

        private void ResetForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            radioMale.Checked = false;
            radioFemale.Checked = false;
          
        }
    }
}