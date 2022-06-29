using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeMnagementTemplated
{
    public partial class PageLifeCycleDemo : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("PreInit Event" + "<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Init Event" + "<br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Init Complete Event" + "<br/>");
        }

        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Pre Load Event" + "<br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Load Event"+ "<br/>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Load Complete Event" + "<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Pre Render Event" + "<br/>");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Pre Render Complete Event" + "<br/>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
           // Response.Write("Unload Event" + "<br/>");
        }
    }
}