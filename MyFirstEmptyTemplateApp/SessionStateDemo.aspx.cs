using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstEmptyTemplateApp
{
    public partial class SessionStateDemo : System.Web.UI.Page
    {
        int clickCount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Clicks"] == null)
                {
                    Session["Clicks"] = 0;
                }

                txtCounter.Text = Session["Clicks"].ToString();
            }
        }

        protected void btnCounter_Click(object sender, EventArgs e)
        {
            clickCount = Convert.ToInt32(Session["Clicks"]) + 1;
            txtCounter.Text = clickCount.ToString();
            Session["Clicks"] = clickCount;
        }
    }
}