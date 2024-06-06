using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
                if (Request.Cookies["userCookie"] != null) //Authenticated as regular user
                {
                    string username = Request.Cookies["userCookie"]["Username"];
                    LogStatusLbl.Text = "Logged into " + username + "as user";
                    LogOutButton.Visible = true; //Show logout button
                    LoginButton.Visible = false; //Hide login button
                    RegisterButton.Visible = false; //Hide register button
                    MealButton.Visible = true; //Show Meal button
                    TrainerButton.Visible = true; //Show trainer button
                    ExerciseButton.Visible = true; //Show exercise button
                    ProfileButton.Visible = true; //Show profile button
                    StudentButton.Visible = false; //Hide student button

                    SetUserProfileImage();
                }
                else if (Request.Cookies["trainerCookie"] != null) //Authenticated as trainer
                {
                    string username = Request.Cookies["trainerCookie"]["Username"];
                    LogStatusLbl.Text = "Logged into " + username + " as trainer";
                    LogOutButton.Visible = true; ///Show logout button
                    LoginButton.Visible = false; //Hide login button
                    RegisterButton.Visible = false; //Hide register button
                    MealButton.Visible = false; //Hide Meal button
                    TrainerButton.Visible = false ; //Hide trainer button
                    ExerciseButton.Visible = false; //Hide exercise button
                    ProfileButton.Visible = true; //Show profile button
                    StudentButton.Visible = true; //Show student button 
                    SetTrainerProfileImage();
                }
                else //User not authenticated
                {
                    LoginButton.Visible = true; //Show login button
                    RegisterButton.Visible = true; //Show register button
                    LogOutButton.Visible = false; //Hide logout button
                    MealButton.Visible = false; //Hide Meal button
                    TrainerButton.Visible = false; //Hide trainer button
                    ExerciseButton.Visible = false; //Hide exercise button
                    ProfileButton.Visible = false; //Hide profile button
                    StudentButton.Visible = false; //Hide student button;
                    LogStatusLbl.Text = "You are not logged in";
                }
            }
        }

        private void SetUserProfileImage()
        {
            userRepository userRepo = new userRepository();
            string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);
            byte[] profilePicture = userRepo.GetProfilePictureFromId(userId);

            if (profilePicture != null)
            {
                string base64String = Convert.ToBase64String(profilePicture);
                ProfileButton.ImageUrl = "data:image/png;base64," + base64String;
            }
        }

        private void SetTrainerProfileImage()
        {
            trainerRepository trainerRepo = new trainerRepository();
            string trainerId = trainerRepo.getIdFromUsername(Request.Cookies["trainerCookie"]["Username"]);
            byte[] profilePicture = trainerRepo.GetProfilePictureFromId(trainerId);

            if (profilePicture != null)
            {
                string base64String = Convert.ToBase64String(profilePicture);
                ProfileButton.ImageUrl = "data:image/png;base64," + base64String;
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
            if (Request.Cookies["trainerCookie"] != null)
            {
                HttpCookie authCookie = new HttpCookie("trainerCookie");
                authCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(authCookie);
            }

            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void MealButton_Click(object sender, EventArgs e)
        {

        }

        protected void TrainerButton_Click(object sender, EventArgs e)
        {
            userRepository userRepo = new userRepository();
            string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);
            string trainerId = userRepo.getTrainerIdFromId(userId);

            if (trainerId == null)
            {
                Response.Redirect("~/Views/HireTrainerPage.aspx");
            }
            else if(trainerId != null)
            {
                Response.Redirect("~/Views/ViewTrainerPage.aspx");
            }

        }

        protected void ExerciseButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ExerciseVideoPage.aspx");
        }

        protected void ProfileButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void StudentButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ViewStudent.aspx");
        }
    }
}