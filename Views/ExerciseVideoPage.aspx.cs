using FitnessApp.Models;
using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.EnterpriseServices;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class ExerciseVideoPage : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                await LoadScheduleAsync();
                await LoadExerciseAsync();
            }



        }

        private async Task LoadScheduleAsync()
        {
            userRepository userRepo = new userRepository();
            ExerciseScheduleRepository scheduleRepo = new ExerciseScheduleRepository();
            ExerciseRepository exerciseRepo = new ExerciseRepository();

            string userId = await userRepo.GetIdFromUsernameAsync(Request.Cookies["userCookie"]["Username"]);

            List<UserExerciseSchedule> userExerciseSchedules = await scheduleRepo.GetScheduleListFilterUserIDAsync(userId);

            var tasks = userExerciseSchedules.Select(async schedule =>
            {
                schedule.ExerciseID = await exerciseRepo.GetExerciseNameFromIDAsync(schedule.ExerciseID);
            });

            await Task.WhenAll(tasks);

            repeatTodayExercise.DataSource = userExerciseSchedules;
            repeatTodayExercise.DataBind();
        }



        private async Task LoadExerciseAsync()
        {
            ExerciseRepository exerciseRepo = new ExerciseRepository();
            List<Exercise> exerciseList = await exerciseRepo.getExerciseListAsync();
            repeatBrowseExercise.DataSource = exerciseList;
            repeatBrowseExercise.DataBind();
        }



        protected void ChestButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Back/cable row.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Back/pullup.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Back/deadlift.gif";

            ExerciseLabel1.Text = "Pushups";
            ExerciseLabel2.Text = "Dumbell Press";
            ExerciseLabel3.Text = "Butterfly";

            MuscleTargetLabel1.Text = "All Chest";
            MuscleTargetLabel2.Text = "Middle & Lower Chest";
            MuscleTargetLabel3.Text = "Middle Chest";


        }

        protected void ShoulderButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Back/cable row.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Back/pullup.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Back/deadlift.gif";

            ExerciseLabel1.Text = "Shoulder Press";
            ExerciseLabel2.Text = "Face Pull";
            ExerciseLabel3.Text = "Lateral Raises";

            MuscleTargetLabel1.Text = "Front Delts";
            MuscleTargetLabel2.Text = "Rear Delts";
            MuscleTargetLabel3.Text = "Side Delts";
        }

        protected void BicepButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Back/cable row.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Back/pullup.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Back/deadlift.gif";

            ExerciseLabel1.Text = "Bicep Curl";
            ExerciseLabel2.Text = "Hammer Curl";
            ExerciseLabel3.Text = "Concentration Curls";

            MuscleTargetLabel1.Text = "All Biceps";
            MuscleTargetLabel2.Text = "Branchialis";
            MuscleTargetLabel3.Text = "Short Head";
        }

        protected void AbsButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Back/cable row.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Back/pullup.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Back/deadlift.gif";

            ExerciseLabel1.Text = "Crunches";
            ExerciseLabel2.Text = "Leg Raise";
            ExerciseLabel3.Text = "Russian Twist";

            MuscleTargetLabel1.Text = "All Abs";
            MuscleTargetLabel2.Text = "Lower Abs";
            MuscleTargetLabel3.Text = "Obliques";
        }

        protected void QuadsButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Back/cable row.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Back/pullup.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Back/deadlift.gif";

            ExerciseLabel1.Text = "Squat";
            ExerciseLabel2.Text = "Leg Press";
            ExerciseLabel3.Text = "Lunges";

            MuscleTargetLabel1.Text = "All Quads";
            MuscleTargetLabel2.Text = "All Quads";
            MuscleTargetLabel3.Text = "All Quads";
        }

        protected void ForearmsButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Back/cable row.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Back/pullup.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Back/deadlift.gif";

            ExerciseLabel1.Text = "Barbell Wrist Curl";
            ExerciseLabel2.Text = "Behind the Back Wrist Curl";
            ExerciseLabel3.Text = "Hammer Curl";

            MuscleTargetLabel1.Text = "Extensors";
            MuscleTargetLabel2.Text = "Flexors";
            MuscleTargetLabel3.Text = "Brachioradialis";
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Back/cable row.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Back/pullup.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Back/deadlift.gif";

            ExerciseLabel1.Text = "Cable Row";
            ExerciseLabel2.Text = "Chin up";
            ExerciseLabel3.Text = "Deadlift";

            MuscleTargetLabel1.Text = "Lats, Traps";
            MuscleTargetLabel2.Text = "Upper Back";
            MuscleTargetLabel3.Text = "Lower Back";
        }


        protected void repeatTodayExercise_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
                {
                    var imgPic = (Image)e.Item.FindControl("ExerciseImage");
                    var ExerciseNameLbl = (Label)e.Item.FindControl("DisplayExerciseLbl");

                    if (imgPic != null && ExerciseNameLbl != null)
                    {
                        Func<Task> setExerciseImageAsync = async () =>
                        {
                            ExerciseRepository exRepo = new ExerciseRepository();

                            string ExerciseName = ExerciseNameLbl.Text.Trim(); // Assuming FoodNameLbl holds the foodId
                            string ExerciseID = await exRepo.GetExerciseIDFromExerciseNameAsync(ExerciseName); // Assuming GetFoodIdFromFoodNameAsync is an asynchronous

                            string imageUrl = $"~/Assets/Images/Exercise/DumpALL/{ExerciseID}.png";
                            imgPic.ImageUrl = imageUrl;

                            // Debug: Add a label to show the image URL
                             var debugLabel = new Label();
                             debugLabel.Text = "Image URL: " + imageUrl;
                             e.Item.Controls.Add(debugLabel);
                        };

                        // Execute the async lambda function
                       _ = setExerciseImageAsync();
                    }
            }
        }

        protected async void RemoveBtn_Click(object sender, EventArgs e)
        {
            ExerciseScheduleRepository userExerciseScheduleRepo = new ExerciseScheduleRepository();
            userRepository userRepo = new userRepository();

            string userId = await userRepo.GetIdFromUsernameAsync(Request.Cookies["userCookie"]["Username"]);

            string scheduleId = await userExerciseScheduleRepo.getScheduleIDFromUserIDAsync(userId);

            await userExerciseScheduleRepo.deleteScheduleFromExercisePlanIDAsync(scheduleId);

            Response.Redirect(Request.RawUrl);
        }


        private string GenerateIdForUserExerciseSchedule()
        {
            ExerciseScheduleRepository exschRepo = new ExerciseScheduleRepository();
            var newId = "";
            var lastId = exschRepo.getLastId();
            var checkid = "";

            if (lastId == null)
            {
                return "XS001";
            }
            else
            {
                var idNumber = Convert.ToInt32(lastId.Substring(2)) + 1;
                newId = string.Format("XS{0:000}", idNumber);
                checkid = exschRepo.findId(newId);
                if (checkid != null)
                {
                    idNumber++;
                }
                newId = string.Format("XS{0:000}", idNumber);
                return newId;
            }
        }

        protected void AddExerciseBtn_Click(object sender, EventArgs e)
        {
            var userRepo = new userRepository();
            var exschRepo = new ExerciseScheduleRepository();
            var exRepo = new ExerciseRepository();

            // Find the Repeater Item that contains the button
            Button addBtn = (Button)sender;
            RepeaterItem item = (RepeaterItem)addBtn.NamingContainer;

            // Retrieve the exercise name
            Label ExerciseNameLbl = (Label)item.FindControl("ExerciseNameLbl");

            string exerciseName = ExerciseNameLbl.Text;
            string exerciseId = exRepo.getExerciseIDFromExerciseName(exerciseName);

            string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

            string scheduleId = GenerateIdForUserExerciseSchedule();

            int sets, reps;

            if (!int.TryParse(SetsTB.Text, out sets) || !int.TryParse(RepsTB.Text, out reps))
            {
                AlertLbl.Text = "Invalid input for reps or sets";
                return;
            }

            if (sets <= 0 || reps <= 0)
            {
                AlertLbl.Text = "Reps and sets should be greater than zero";
                return;
            }

            exschRepo.insertSchedule(scheduleId, userId, exerciseId, reps, sets);
            Response.Redirect("~/Views/ExerciseVideoPage.aspx");
        }




        protected void repeatBrowseExercise_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var exercise = (Exercise)e.Item.DataItem;
                var imgPic = (Image)e.Item.FindControl("ExerciseImage");

                if (imgPic != null)
                {
                    string ExerciseID = exercise.ExerciseID.Trim(); // Trim any leading or trailing spaces

                    string imageUrl = $"~/Assets/Images/Exercise/DumpALL/{ExerciseID}.png";
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