using FitnessApp.Models;
using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class ViewStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                trainerRepository trainerRepo = new trainerRepository();
                userRepository userRepo = new userRepository();
                string trainerId = trainerRepo.getIdFromUsername(Request.Cookies["trainerCookie"]["Username"]);
                List<User> users = userRepo.getUserListFromTrainerId(trainerId);
                

                repeatStudentList.DataSource = users;
                repeatStudentList.DataBind();
            }
        }

        private string GetImageUrl(string userId)
        {
            userRepository userRepo = new userRepository();
            byte[] imageData = userRepo.GetProfilePictureFromId(userId);

            // Convert byte array to base64 string
            string base64String = Convert.ToBase64String(imageData);

            // Construct data URI
            string imageUrl = $"data:image/jpeg;base64,{base64String}";

            return imageUrl;
        }

        protected void repeatStudentList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            userRepository userRepo = new userRepository();
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var user = (User)e.Item.DataItem;
                var clientPic = (Image)e.Item.FindControl("ClientImg"); // Updated ID to match ASPX

                if (clientPic != null)
                {
                    string userId = userRepo.getIdFromUsername(user.Username);
                    string imageUrl = GetImageUrl(userId);
                    clientPic.ImageUrl = imageUrl;
                }
            }
        }
    }
}