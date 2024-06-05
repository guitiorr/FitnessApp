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
    public partial class HireTrainerPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTrainers();
            }
        }

        private void LoadTrainers()
        {
            trainerRepository trainerRepo = new trainerRepository();
            List<Trainer> trainers = trainerRepo.getTrainer();

            List <Trainer> top3Trainers = trainers.Take(3).ToList();

            RepeatRecommendedTrainer.DataSource = top3Trainers;
            RepeatRecommendedTrainer.DataBind();

            RepeatTrainerList.DataSource = trainers;
            RepeatTrainerList.DataBind();

        }

        protected void HireButton_Click1(object sender, EventArgs e)
        {

        }

        protected void RepeatRecommendedTrainer_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            trainerRepository trainerRepo = new trainerRepository();
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var trainer = (Trainer)e.Item.DataItem;
                var imgPic = (Image)e.Item.FindControl("RecommendedTrainerPic");

                if (imgPic != null)
                {
                    string trainerId = trainerRepo.getIdFromUsername(trainer.Username); // Assume 'Username' is a property of 'Trainer'
                    string imageUrl = GetImageUrl(trainerId);
                    imgPic.ImageUrl = imageUrl;
                }
            }
        }

        protected void RepeatTrainerList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            trainerRepository trainerRepo = new trainerRepository();
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var trainer = (Trainer)e.Item.DataItem;
                var imgPic = (Image)e.Item.FindControl("ListTrainerPic");

                if (imgPic != null)
                {
                    string trainerId = trainerRepo.getIdFromUsername(trainer.Username); // Assume 'Username' is a property of 'Trainer'
                    string imageUrl = GetImageUrl(trainerId);
                    imgPic.ImageUrl = imageUrl;
                }
            }
        }

        private string GetImageUrl(string trainerId)
        {
            trainerRepository trainerRepo = new trainerRepository();
            byte[] imageData = trainerRepo.GetProfilePictureFromId(trainerId);

            // Convert byte array to base64 string
            string base64String = Convert.ToBase64String(imageData);

            // Construct data URI
            string imageUrl = $"data:image/jpeg;base64,{base64String}";

            return imageUrl;
        }
    }
}