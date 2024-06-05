using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["userCookie"] != null) //Regular user
                {
                    
                    String userId = Request.Cookies["userCookie"]["UserID"];

                    userRepository userRepo = new userRepository();

                    UsernameLbl.Text = userRepo.getUsernameFromId(userId);
                    EmailLbl.Text = userRepo.getEmailFromId(userId);

                    AgeLbl.Text = "Age: " + userRepo.getAgeFromId(userId).ToString();
                    //HeightLbl.Text = "Height: " + userRepo.getHeightFromId(userId).ToString();
                    //WeightLbl.Text = "Weight: " + userRepo.getWeightFromId(userId).ToString();

                    if(userRepo.getHeightFromId(userId).ToString() == "")
                    {
                        HeightLbl.Text = "Height: Not set";
                    }
                    else
                    {
                        HeightLbl.Text = "Height: " + userRepo.getHeightFromId(userId).ToString();
                    }
                    if (userRepo.getWeightFromId(userId).ToString() == "")
                    {
                        WeightLbl.Text = "Weight: Not set";
                    }
                    else
                    {
                        WeightLbl.Text = "Weight: " + userRepo.getWeightFromId(userId).ToString();
                    }


                    WeightGoalLbl.Text = "Weight goal: " + userRepo.getWeightGoalFromId(userId);
                    //ActiveLevelLbl.Text = "Active level: Not set";

                    ProfilePicture.ImageUrl = userRepo.GetProfilePictureUrlFromId(userId);


                }
                else if (Request.Cookies["trainerCookie"] != null) //Trainer
                {
                    String username = Request.Cookies["trainerCookie"]["Username"];

                    trainerRepository trainerRepo = new trainerRepository();
                    string trainerId = trainerRepo.getIdFromUsername(username);

                    UsernameLbl.Text = username;
                    EmailLbl.Text = trainerRepo.getEmailFromUsername(username);

                    AgeLbl.Text = "Age: " + trainerRepo.getAgeFromUsername(username).ToString();
                    //HeightLbl.Text = "Height: " + trainerRepo.getHeightFromUsername(username).ToString();
                    //WeightLbl.Text = "Weight: " + trainerRepo.getWeightFromUsername(username).ToString();

                    if (trainerRepo.getHeightFromUsername(username).ToString() == "")
                    {
                        HeightLbl.Text = "Height: Not set";
                    }
                    else
                    {
                        HeightLbl.Text = "Height: " + trainerRepo.getHeightFromUsername(username).ToString();
                    }
                    if (trainerRepo.getWeightFromUsername(username).ToString() == "")
                    {
                        WeightLbl.Text = "Height: Not set";
                    }
                    else
                    {
                        WeightLbl.Text = "Weight: " + trainerRepo.getWeightFromUsername(username).ToString();
                    }

                    if(trainerRepo.getPhoneFromId(trainerId) == null)
                    {
                        PhoneLbl.Text = "Phone: Not set";
                    }
                    else
                    {
                        PhoneLbl.Text = "Phone: " + trainerRepo.getPhoneFromId(trainerId).ToString();
                    }


                    ProfilePicture.ImageUrl = trainerRepo.GetProfilePictureUrlFromId(trainerId);


                    WeightGoalLbl.Visible = false; //hide weight goal
                    //ActiveLevelLbl.Visible = false; //Hide active level


                }

            }
        }

        protected void EditProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/EditProfilePage.aspx");
        }
    }
}