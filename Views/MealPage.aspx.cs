using FitnessApp.Models;
using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
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
                loadSchedule();
            }
        }

        public class MealDetail
        {
            public string FoodName { get; set; }
            public string MealTime { get; set; }
        }

        private void loadSchedule()
        {

            userRepository userRepo = new userRepository();
            FoodRepository foodRepo = new FoodRepository();
            userFoodScheduleRepository userFoodRepo = new userFoodScheduleRepository();

            List<UserFoodSchedule> schedule = userFoodRepo.getSchedule();
            List<MealDetail> mealDetails = new List<MealDetail>();

            string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

            foreach (var item in schedule)
            {
                //var food = foodRepo.getFoodNameFromId(userFoodRepo.getFoodIdFromUserId(userId));
                var food = foodRepo.getFoodById(userFoodRepo.getIdFromUserId(userId));
                if (food != null)
                {
                    mealDetails.Add(new MealDetail
                    {
                        FoodName = food.FoodId,
                        MealTime = item.mealTime
                    });
                }
            }

            repeatTodayMeal.DataSource = mealDetails;
            repeatTodayMeal.DataBind();
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

        protected void addBreakfastBtn_Click(object sender, EventArgs e)
        {
            FoodRepository foodRepo = new FoodRepository();
            userRepository userRepo = new userRepository();
            userFoodScheduleRepository userFoodRepo = new userFoodScheduleRepository();
            // Find the Repeater Item that contains the button
            Button addBtn = (Button)sender;
            RepeaterItem item = (RepeaterItem)addBtn.NamingContainer;

            // Retrieve the food name and food image
            Label foodNameLbl = (Label)item.FindControl("FoodNameLblBreakfast");
            Image foodImage = (Image)item.FindControl("FoodImageBreakfast");

            string foodName = foodNameLbl.Text;
            string foodImageUrl = foodImage.ImageUrl;
            string foodId = foodRepo.getFoodIdFromFoodName(foodName);

            // Debug: Display the food name and food image URL
            // You can replace this with your desired logic (e.g., adding to a cart)
            // var debugLabel = new Label();
            // debugLabel.Text = $"Food Name: {foodName}, Food Image URL: {foodImageUrl}";
            // item.Controls.Add(debugLabel);

            string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

            userFoodRepo.insertSchedule(userId, foodId, "Breakfast");
            Response.Redirect("~/Views/MealPage.aspx");
        }

        protected void addLunchBtn_Click(object sender, EventArgs e)
        {
            FoodRepository foodRepo = new FoodRepository();
            userRepository userRepo = new userRepository();
            userFoodScheduleRepository userFoodRepo = new userFoodScheduleRepository();
            // Find the Repeater Item that contains the button
            Button addBtn = (Button)sender;
            RepeaterItem item = (RepeaterItem)addBtn.NamingContainer;

            // Retrieve the food name and food image
            Label foodNameLbl = (Label)item.FindControl("FoodNameLblBreakfast");
            Image foodImage = (Image)item.FindControl("FoodImageBreakfast");

            string foodName = foodNameLbl.Text;
            string foodImageUrl = foodImage.ImageUrl;
            string foodId = foodRepo.getFoodIdFromFoodName(foodName);

            // Debug: Display the food name and food image URL
            // You can replace this with your desired logic (e.g., adding to a cart)
            // var debugLabel = new Label();
            // debugLabel.Text = $"Food Name: {foodName}, Food Image URL: {foodImageUrl}";
            // item.Controls.Add(debugLabel);

            string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

            userFoodRepo.insertSchedule(userId, foodId, "Lunch");
            Response.Redirect("~/Views/MealPage.aspx");
        }

        protected void addLunchDinner_Click(object sender, EventArgs e)
        {
            FoodRepository foodRepo = new FoodRepository();
            userRepository userRepo = new userRepository();
            userFoodScheduleRepository userFoodRepo = new userFoodScheduleRepository();
            // Find the Repeater Item that contains the button
            Button addBtn = (Button)sender;
            RepeaterItem item = (RepeaterItem)addBtn.NamingContainer;

            // Retrieve the food name and food image
            Label foodNameLbl = (Label)item.FindControl("FoodNameLblBreakfast");
            Image foodImage = (Image)item.FindControl("FoodImageBreakfast");

            string foodName = foodNameLbl.Text;
            string foodImageUrl = foodImage.ImageUrl;
            string foodId = foodRepo.getFoodIdFromFoodName(foodName);

            // Debug: Display the food name and food image URL
            // You can replace this with your desired logic (e.g., adding to a cart)
            // var debugLabel = new Label(); 
            // debugLabel.Text = $"Food Name: {foodName}, Food Image URL: {foodImageUrl}";
            // item.Controls.Add(debugLabel);

            string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

            userFoodRepo.insertSchedule(userId, foodId, "Dinner");
            Response.Redirect("~/Views/MealPage.aspx");
        }

        protected void repeatTodayMeal_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var imgPic = (Image)e.Item.FindControl("FoodImageDinner");
                userFoodScheduleRepository scheduleRepo = new userFoodScheduleRepository();
                userRepository userRepo = new userRepository();

                if (imgPic != null)
                {
                    string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);
                    string foodId = scheduleRepo.getFoodIdFromUserId(userId).Trim(); // Trim any leading or trailing spaces

                    string imageUrl = $"~/Assets/Images/Food/{foodId}.png";
                    imgPic.ImageUrl = imageUrl;

                    // Debug: Add a label to show the image URL
                    //var debugLabel = new Label();
                    //debugLabel.Text = "Image URL: " + imageUrl;
                    //e.Item.Controls.Add(debugLabel);
                }
            }
        }

        protected void RemoveBtn_Click(object sender, EventArgs e)
        {
            userFoodScheduleRepository userSchedule = new userFoodScheduleRepository();
            userRepository userRepo = new userRepository();

            string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

            string scheduleId = userSchedule.getIdFromUserId(userId);

            userSchedule.deleteSchedule(scheduleId);

            Response.Redirect("~/Views/MealPage.aspx");
        }
    }
}
