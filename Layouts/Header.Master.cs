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
            if (!IsPostBack)
            {
                if (Request.Cookies["userCookie"] != null) // User authenticated as regular user
                {
                    // User is authenticated, retrieve their username from the cookie
                    string username = Request.Cookies["userCookie"]["Username"];
                    LogStatusLbl.Text = "Logged in as " + username;
                    LogOutButton.Visible = true; ///Show logout button
                    LoginButton.Visible = false; //Hide login button
                    RegisterButton.Visible = false; //Hide register button
                }
                else //User not authenticated
                {
                    LoginButton.Visible = true; //Show login button
                    RegisterButton.Visible = true; //Show register button
                    LogOutButton.Visible = false; //Hide logout button
                    LogStatusLbl.Text = "Not logged in";
                }
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }

        protected void LogOutButton_Click(object sender, EventArgs e)
        {

            if (Request.Cookies["userCookie"] != null)
            {
                HttpCookie authCookie = new HttpCookie("userCookie");
                authCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(authCookie);
            }

            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}