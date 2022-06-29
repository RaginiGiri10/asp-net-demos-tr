using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstEmptyTemplateApp
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
			txtFirstName.Text = "Test";
			lblFullName.Visible = false;
		}

        protected void btnDisplayFullName_Click(object sender, EventArgs e)
        {
			string firstName = txtFirstName.Text;
			string lastName = txtLastName.Text;
			lblFullName.Visible = true;
			lblFullName.Text = $"{firstName},{lastName}";

        }

      
    }
}