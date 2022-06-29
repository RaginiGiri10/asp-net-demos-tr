using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstEmptyTemplateApp
{
    public partial class RadioButtonDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblGender.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string genderText = "Selected gender is";
            if (radioMale.Checked)
            {
                lblGender.Text = $"{genderText} {radioMale.Text}";
            }
            else if(radioFemale.Checked)
            {
                lblGender.Text = $"{genderText} {radioFemale.Text}";
            }
            else
            {
                lblGender.Text = "Gender Not Selected";
            }

            lblGender.Visible = true;
        }

      
    }
}