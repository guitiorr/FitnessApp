using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class ExerciseVideoPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ChestButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";

            ExerciseLabel1.Text = "Pushups";
            ExerciseLabel2.Text = "Dumbell Press";
            ExerciseLabel3.Text = "Butterfly";

            MuscleTargetLabel1.Text = "All Chest";
            MuscleTargetLabel2.Text = "Middle & Lower Chest";
            MuscleTargetLabel3.Text = "Middle Chest";


        }

        protected void ShoulderButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";

            ExerciseLabel1.Text = "Shoulder Press";
            ExerciseLabel2.Text = "Face Pull";
            ExerciseLabel3.Text = "Lateral Raises";

            MuscleTargetLabel1.Text = "Front Delts";
            MuscleTargetLabel2.Text = "Rear Delts";
            MuscleTargetLabel3.Text = "Side Delts";
        }

        protected void BicepButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";

            ExerciseLabel1.Text = "Bicep Curl";
            ExerciseLabel2.Text = "Hammer Curl";
            ExerciseLabel3.Text = "Concentration Curls";

            MuscleTargetLabel1.Text = "All Biceps";
            MuscleTargetLabel2.Text = "Branchialis";
            MuscleTargetLabel3.Text = "Short Head";
        }

        protected void AbsButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";

            ExerciseLabel1.Text = "Crunches";
            ExerciseLabel2.Text = "Leg Raise";
            ExerciseLabel3.Text = "Russian Twist";

            MuscleTargetLabel1.Text = "All Abs";
            MuscleTargetLabel2.Text = "Lower Abs";
            MuscleTargetLabel3.Text = "Obliques";
        }

        protected void QuadsButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";

            ExerciseLabel1.Text = "Squat";
            ExerciseLabel2.Text = "Leg Press";
            ExerciseLabel3.Text = "Lunges";

            MuscleTargetLabel1.Text = "All Quads";
            MuscleTargetLabel2.Text = "All Quads";
            MuscleTargetLabel3.Text = "All Quads";
        }

        protected void ForearmsButton_Click(object sender, EventArgs e)
        {
            GIFPlayer1.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer2.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";
            GIFPlayer3.ImageUrl = "~/Assets/GIF/ExercisePage/Chest/shrekdance.gif";

            ExerciseLabel1.Text = "Barbell Wrist Curl";
            ExerciseLabel2.Text = "Behind the Back Wrist Curl";
            ExerciseLabel3.Text = "Hammer Curl";

            MuscleTargetLabel1.Text = "Extensors";
            MuscleTargetLabel2.Text = "Flexors";
            MuscleTargetLabel3.Text = "Brachioradialis";
        }
    }
}