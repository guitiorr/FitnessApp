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
                    HeightLbl.Text = "Height: " + userRepo.getHeightFromId(userId).ToString();
                    WeightLbl.Text = "Weight: " + userRepo.getWeightFromId(userId).ToString();

                    if(HeightLbl.Text == null)
                    {
                        HeightLbl.Text = "Height: Not set";
                    }
                    if (WeightLbl.Text == null)
                    {
                        WeightLbl.Text = "Weight: Not set";
                    }


                    WeightGoalLbl.Text = "Weight goal: Not set";
                    //ActiveLevelLbl.Text = "Active level: Not set";


                }
                else if (Request.Cookies["trainerCookie"] != null) //Trainer
                {

                    String username = Request.Cookies["trainerCookie"]["Username"];

                    trainerRepository trainerRepo = new trainerRepository();

                    UsernameLbl.Text = username;
                    EmailLbl.Text = trainerRepo.getEmailFromUsername(username);

                    AgeLbl.Text = trainerRepo.getAgeFromUsername(username).ToString();
                    HeightLbl.Text = trainerRepo.getHeightFromUsername(username).ToString();
                    WeightLbl.Text = trainerRepo.getWeightFromUsername(username).ToString();

                    if (HeightLbl.Text == null)
                    {
                        HeightLbl.Text = "Not set";
                    }
                    if (WeightLbl.Text == null)
                    {
                        WeightLbl.Text = "Not set";
                    }

                    PhoneLbl.Text = "Not set";


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