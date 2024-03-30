using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            userRepository userRepo = new userRepository();
            int loginPass = 1;

            String Username = usernameTB.Text;
            String Password = passwordTB.Text;
            String userId = userRepo.getIdFromUsername(Username);

            if(userId == null )
            {
                usernameErrorLbl.Text = "Username not found!";
                loginPass = 0;
            }
            else
            {
                loginPass = 1;
                usernameErrorLbl.Text = "";
            }


            String checkPassword = userRepo.checkPassword(userId, Password);

            if(checkPassword == null)
            {
                passwordErrorLbl.Text = "Incorrect Password!";
                loginPass = 0;
            }
            else
            {
                loginPass = 1;
                passwordErrorLbl.Text = "";
            }

            if(loginPass == 1)
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }


        }
    }
}