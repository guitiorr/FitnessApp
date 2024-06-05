using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class ViewTrainerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                userRepository userRepo = new userRepository();
                trainerRepository trainerRepo = new trainerRepository();

                string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);
                string trainerId = userRepo.getTrainerIdFromId(userId);

                TrainerFullName.Text = trainerRepo.getFullNameFromid(trainerId);
                TrainerPic.ImageUrl = trainerRepo.GetProfilePictureUrlFromId(trainerId);
            }
        }
    }
}