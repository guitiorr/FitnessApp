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
    public partial class MealPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadBreakfast();
                loadLunch();
                loadDinner();
            }
        }

        private void loadBreakfast()
        {
            FoodRepository foodRepo = new FoodRepository();
            List<Food> foods = foodRepo.getFoods();

            repeatBrowseMealBreakfast.DataSource = foods;
            repeatBrowseMealBreakfast.DataBind();
        }

        private void loadLunch()
        {
            FoodRepository foodRepo = new FoodRepository();
            List<Food> foods = foodRepo.getFoods();

            repeatBrowseMealLunch.DataSource = foods;
            repeatBrowseMealLunch.DataBind();
        }

        private void loadDinner()
        {
            FoodRepository foodRepo = new FoodRepository();
            List<Food> foods = foodRepo.getFoods();

            repeatBrowseMealDinner.DataSource = foods;
            repeatBrowseMealDinner.DataBind();
        }

        protected void repeatBrowseMealBreakfast_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var food = (Food)e.Item.DataItem;
                var imgPic = (Image)e.Item.FindControl("FoodImageBreakfast");

                if (imgPic != null)
                {
                    string foodId = food.FoodId.Trim(); // Trim any leading or trailing spaces

                    string imageUrl = $"~/Assets/Images/Food/{foodId}.png";
                    imgPic.ImageUrl = imageUrl;

                    // Debug: Add a label to show the image URL
                    //var debugLabel = new Label();
                    //debugLabel.Text = "Image URL: " + imageUrl;
                    //e.Item.Controls.Add(debugLabel);
                }
            }
        }

        protected void repeatBrowseMealLunch_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var food = (Food)e.Item.DataItem;
                var imgPic = (Image)e.Item.FindControl("FoodImageLunch");

                if (imgPic != null)
                {
                    string foodId = food.FoodId.Trim(); // Trim any leading or trailing spaces

                    string imageUrl = $"~/Assets/Images/Food/{foodId}.png";
                    imgPic.ImageUrl = imageUrl;

                    // Debug: Add a label to show the image URL
                    //var debugLabel = new Label();
                    //debugLabel.Text = "Image URL: " + imageUrl;
                    //e.Item.Controls.Add(debugLabel);
                }
            }
        }

        protected void repeatBrowseMealDinner_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var food = (Food)e.Item.DataItem;
                var imgPic = (Image)e.Item.FindControl("FoodImageDinner");

                if (imgPic != null)
                {
                    string foodId = food.FoodId.Trim(); // Trim any leading or trailing spaces

                    string imageUrl = $"~/Assets/Images/Food/{foodId}.png";
                    imgPic.ImageUrl = imageUrl;

                    // Debug: Add a label to show the image URL
                    //var debugLabel = new Label();
                    //debugLabel.Text = "Image URL: " + imageUrl;
                    //e.Item.Controls.Add(debugLabel);
                }
            }
        }
    }
}
