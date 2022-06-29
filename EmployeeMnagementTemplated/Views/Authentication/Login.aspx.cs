using EmployeeMnagementTemplated.ADO;
using EmployeeMnagementTemplated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeMnagementTemplated.Views.Authentication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblInvalidCredentials.Visible = false;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            AuthenticationRepository authenticationRepository = new AuthenticationRepository();

            EmployeeUser employeeUser = new EmployeeUser { UserName = txtUserName.Text, Password = txtPassword.Text };
            bool isAuthenticated = authenticationRepository.Login(employeeUser);

            if (isAuthenticated)
            {
                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, false);
            }
            else
            {
                lblInvalidCredentials.Visible = true;
                lblInvalidCredentials.Text = "Invalid Credentials";
            }


           
        }
    }
}