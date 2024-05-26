using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                userRepository userRepo = new userRepository();
                trainerRepository trainerRepo = new trainerRepository();
                userRepo.setDefaultImage();
                trainerRepo.setDefaultImage();
                if (Request.Cookies["userCookie"] != null) //Authenticated as regular user
                {

                }
                else //User not authenticated
                {
                    
                }
            }
        }

        protected void becomeMemberButton_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["userCookie"] != null) //Authenticated as regular user
            {
                // Response.Redirect("~/Views/RegisterPage.aspx");
            }
            else if (Request.Cookies["trainerCookie"] != null) //Authenticated as trainer
            {

            }
            else //User not authenticated
            {
                Response.Redirect("~/Views/RegisterPage.aspx?role=user");
            }
        }

        protected void becomeTrainerButton_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["userCookie"] != null) //Authenticated as regular user
            {

            }
            else if (Request.Cookies["trainerCookie"] != null) //Authenticated as trainer
            {

            }
            else //User not authenticated
            {
                Response.Redirect("~/Views/RegisterPage.aspx?role=trainer");
            }
        }

    }
}