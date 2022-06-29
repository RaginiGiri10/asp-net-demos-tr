using EmployeeMnagementTemplated.ADO;
using EmployeeMnagementTemplated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeMnagementTemplated.Views.Authentication
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                lblUserExists.Visible = false;           
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            AuthenticationRepository authenticationRepository = new AuthenticationRepository();

            EmployeeUser employeeUser = new EmployeeUser();
            employeeUser.UserName = txtUserName.Text;
            employeeUser.Password = txtPassword.Text;
           bool isRegistered = authenticationRepository.RegisterUser(employeeUser);

            if (!isRegistered)
            {
                lblUserExists.Visible = true;
                lblUserExists.Text = $"User {txtUserName.Text} already exists!!!";
            }
        }
    }
}