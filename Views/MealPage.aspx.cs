using FitnessApp.Models;
using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class MealPage : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                await LoadScheduleAsync();
                await LoadLunchAsync();
                await LoadBreakfastAsync();
                await LoadDinnerAsync();
            }
        }

        public string GenerateIdForUserFoodSchedule()
        {
            userFoodScheduleRepository userFoodRepo = new userFoodScheduleRepository();
            var newId = "";
            var lastId = userFoodRepo.getLastId();
            var checkid = "";

            if (lastId == null)
            {
                return "SC001";
            }
            else
            {
                var idNumber = Convert.ToInt32(lastId.Substring(2)) + 1;
                newId = string.Format("SC{0:000}", idNumber);
                checkid = userFoodRepo.findId(newId);
                if (checkid != null)
                {
                    idNumber++;
                }
                newId = string.Format("SC{0:000}", idNumber);
                return newId;
            }
        }

        private async Task LoadScheduleAsync()
        {
            userRepository userRepo = new userRepository();
            FoodRepository foodRepo = new FoodRepository();
            userFoodScheduleRepository userFoodRepo = new userFoodScheduleRepository();

            string userId = await userRepo.GetIdFromUsernameAsync(Request.Cookies["userCookie"]["Username"]);

            List<UserFoodSchedule> scheduleList = await userFoodRepo.GetScheduleListFromUserIdAsync(userId);

            var tasks = scheduleList.Select(async schedule =>
            {
                schedule.foodId = await foodRepo.GetFoodNameFromIdAsync(schedule.foodId);
            });

            await Task.WhenAll(tasks);

            repeatTodayMeal.DataSource = scheduleList;
            repeatTodayMeal.DataBind();
        }


        private void loadSchedule()
        {
            userRepository userRepo = new userRepository();
            FoodRepository foodRepo = new FoodRepository();
            userFoodScheduleRepository userFoodRepo = new userFoodScheduleRepository();

            string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

            List<UserFoodSchedule> scheduleList = userFoodRepo.getScheduleListFromUserId(userId);

            // Manually override foodId with food name
            foreach (var schedule in scheduleList)
            {
                schedule.foodId = foodRepo.getFoodNameFromId(schedule.foodId); // Assuming getFoodNameFromId returns the food name
            }

            repeatTodayMeal.DataSource = scheduleList;
            repeatTodayMeal.DataBind();
        }


        private async Task LoadBreakfastAsync()
        {
            FoodRepository foodRepo = new FoodRepository();
            List<Food> foods = await foodRepo.GetFoodsAsync();

            repeatBrowseMealBreakfast.DataSource = foods;
            repeatBrowseMealBreakfast.DataBind();
        }

        private void LoadBreakfast()
        {
            FoodRepository foodRepo = new FoodRepository();
            List<Food> foods = foodRepo.getFoods();

            repeatBrowseMealBreakfast.DataSource = foods;
            repeatBrowseMealBreakfast.DataBind();
        }

        private async Task LoadLunchAsync()
        {
            FoodRepository foodRepo = new FoodRepository();
            List<Food> foods = await foodRepo.GetFoodsAsync();

            repeatBrowseMealLunch.DataSource = foods;
            repeatBrowseMealLunch.DataBind();
        }



        private void loadLunch()
        {
            FoodRepository foodRepo = new FoodRepository();
            List<Food> foods = foodRepo.getFoods();

            repeatBrowseMealLunch.DataSource = foods;
            repeatBrowseMealLunch.DataBind();
        }

        private async Task LoadDinnerAsync()
        {
            FoodRepository foodRepo = new FoodRepository();
            List<Food> foods = await foodRepo.GetFoodsAsync();

            repeatBrowseMealDinner.DataSource = foods;
            repeatBrowseMealDinner.DataBind();
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

            string scheduleId = GenerateIdForUserFoodSchedule();

            userFoodRepo.insertSchedule(scheduleId,userId, foodId, "Breakfast");
            //Response.Redirect("~/Views/MealPage.aspx");
            Response.Redirect(Request.RawUrl);
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
            Label foodNameLbl = (Label)item.FindControl("FoodNameLblLunch");
            Image foodImage = (Image)item.FindControl("FoodImageLunch");

            string foodName = foodNameLbl.Text;
            string foodImageUrl = foodImage.ImageUrl;
            string foodId = foodRepo.getFoodIdFromFoodName(foodName);

            // Debug: Display the food name and food image URL
            // You can replace this with your desired logic (e.g., adding to a cart)
            // var debugLabel = new Label();
            // debugLabel.Text = $"Food Name: {foodName}, Food Image URL: {foodImageUrl}";
            // item.Controls.Add(debugLabel);

            string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

            string scheduleId = GenerateIdForUserFoodSchedule();

            userFoodRepo.insertSchedule(scheduleId, userId, foodId, "Lunch");
            //Response.Redirect("~/Views/MealPage.aspx");
            Response.Redirect(Request.RawUrl);
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
            Label foodNameLbl = (Label)item.FindControl("FoodNameLblDinner");
            Image foodImage = (Image)item.FindControl("FoodImageDinner");

            string foodName = foodNameLbl.Text;
            string foodImageUrl = foodImage.ImageUrl;
            string foodId = foodRepo.getFoodIdFromFoodName(foodName);

            // Debug: Display the food name and food image URL
            // You can replace this with your desired logic (e.g., adding to a cart)
            // var debugLabel = new Label(); 
            // debugLabel.Text = $"Food Name: {foodName}, Food Image URL: {foodImageUrl}";
            // item.Controls.Add(debugLabel);

            string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

            string scheduleId = GenerateIdForUserFoodSchedule();

            userFoodRepo.insertSchedule(scheduleId, userId, foodId, "Dinner");
            //Response.Redirect("~/Views/MealPage.aspx");
            Response.Redirect(Request.RawUrl);
        }

        protected void repeatTodayMeal_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var imgPic = (Image)e.Item.FindControl("FoodImageToday");
                var foodNameLbl = (Label)e.Item.FindControl("FoodNameLbl");

                if (imgPic != null && foodNameLbl != null)
                {
                    Func<Task> setFoodImageAsync = async () =>
                    {
                        FoodRepository foodRepo = new FoodRepository();

                        string foodId = foodNameLbl.Text.Trim(); // Assuming FoodNameLbl holds the foodId
                        foodId = await foodRepo.GetFoodIdFromFoodNameAsync(foodId); // Assuming GetFoodIdFromFoodNameAsync is an asynchronous method
                        foodId = foodId.Trim();

                        string imageUrl = $"~/Assets/Images/Food/{foodId}.png";
                        imgPic.ImageUrl = imageUrl;

                        // Debug: Add a label to show the image URL
                        // var debugLabel = new Label();
                        // debugLabel.Text = "Image URL: " + imageUrl;
                        // e.Item.Controls.Add(debugLabel);
                    };

                    // Execute the async lambda function
                    _ = setFoodImageAsync();
                }
            }
        }





        /* protected void repeatTodayMeal_ItemDataBound(object sender, RepeaterItemEventArgs e)
         {
             if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
             {
                 var imgPic = (Image)e.Item.FindControl("FoodImageToday");
                 userFoodScheduleRepository scheduleRepo = new userFoodScheduleRepository();
                 userRepository userRepo = new userRepository();

                 if (imgPic != null)
                 {
                     string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);
                     string foodId = scheduleRepo.getFoodIdFromUserId(userId).Trim(); // Trim any leading or trailing spaces

                     string imageUrl = $"~/Assets/Images/Food/{foodId}.png";
                     imgPic.ImageUrl = imageUrl;

                     //Debug: Add a label to show the image URL
                     //var debugLabel = new Label();
                     //debugLabel.Text = "Image URL: " + imageUrl;
                     //e.Item.Controls.Add(debugLabel);
                 }
             }
         }*/

        protected async void RemoveBtn_Click(object sender, EventArgs e)
        {
            userFoodScheduleRepository userSchedule = new userFoodScheduleRepository();
            userRepository userRepo = new userRepository();

            string userId = await userRepo.GetIdFromUsernameAsync(Request.Cookies["userCookie"]["Username"]);

            string scheduleId = await userSchedule.GetIdFromUserIdAsync(userId);

            userSchedule.DeleteScheduleAsync(scheduleId);

            Response.Redirect(Request.RawUrl);
        }

    }
}
