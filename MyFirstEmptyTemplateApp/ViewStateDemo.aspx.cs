using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstEmptyTemplateApp
{
    public partial class ViewStateDemo : System.Web.UI.Page
    {
        int clickCount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Clicks"] == null)
                {
                    ViewState["Clicks"] = 0;
                }

                txtCount.Text = ViewState["Clicks"].ToString();
            }
           
        }

        protected void btnCounter_Click(object sender, EventArgs e)
        {
         clickCount = Convert.ToInt32(ViewState["Clicks"]) + 1;           
         txtCount.Text = clickCount.ToString();
         ViewState["Clicks"] = clickCount;

        }

       
    }
}