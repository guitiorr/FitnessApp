using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Layouts
{
    public partial class Header : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }
    }
}