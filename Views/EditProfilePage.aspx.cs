using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class EditProfilePage : System.Web.UI.Page
    {
        private string fileExtension = ".png";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["userCookie"] != null) //User
                {
                    userRepository userRepo = new userRepository();
                    string username = Request.Cookies["userCookie"]["Username"];
                    string userId = userRepo.getIdFromUsername(username);

                    PhoneLbl.Visible = false; // hide phone
                    PhoneTB.Visible = false; // hide phone

                    ProfilePictureImage.ImageUrl = userRepo.GetProfilePictureUrlFromId(userId);
                    AgeTB.Text = userRepo.getAgeFromId(userId).ToString();
                    HeightTB.Text = userRepo.getHeightFromId(userId).ToString();
                    WeightTB.Text = userRepo.getWeightFromId(userId).ToString();
                    WeightGoalTB.Text = userRepo.getWeightGoalFromId(userId).ToString();


                }
                else if (Request.Cookies["trainerCookie"] != null) //Trainer
                {
                    trainerRepository trainerRepo = new trainerRepository();
                    string username = Request.Cookies["trainerCookie"]["Username"];
                    string trainerId = trainerRepo.getIdFromUsername(username);

                    ProfilePictureImage.ImageUrl = trainerRepo.GetProfilePictureUrlFromId(trainerId);
                    AgeTB.Text = trainerRepo.getAgeFromUsername(username).ToString();
                    HeightTB.Text = trainerRepo.getHeightFromUsername(username).ToString();
                    WeightTB.Text = trainerRepo.getWeightFromUsername(username).ToString();
                    WeightGoalTB.Visible = false; // hide weight goal
                    WeightGoalLbl.Visible = false; // hide weight goal
                    PhoneTB.Text = trainerRepo.getPhoneFromId(trainerId);

                }
                else // Not authenticated
                {

                }


            }
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            userRepository userRepo = new userRepository();
            trainerRepository trainerRepo = new trainerRepository();
            int pass = 0;

            int age = 0;
            if (string.IsNullOrEmpty(AgeTB.Text))
            {
                // Handle case where age input field is empty
                AgeErrorLbl.Text = "Please enter your age.";
                pass = 0;
            }
            else
            {
                age = Convert.ToInt32(AgeTB.Text);
                if (age < 18)
                {
                    AgeErrorLbl.Text = "Age must be above 18!";
                    pass = 0;
                }
                else
                {
                    AgeErrorLbl.Text = "";
                    pass = 1;
                }
            }

            double height = Convert.ToDouble(HeightTB.Text);
            if (string.IsNullOrEmpty(HeightTB.Text))
            {
                // Handle case where age input field is empty
                HeightErrorLbl.Text = "Field must not be empty";
                pass = 0;
            }
            else if (height <= 0)
            {
                HeightErrorLbl.Text = "Invalid number";
                pass = 0;
            }
            else
            {
                HeightErrorLbl.Text = "";
                pass = 1;
            }

            double weight = Convert.ToDouble(WeightTB.Text);
            if (string.IsNullOrEmpty(WeightTB.Text))
            {
                // Handle case where age input field is empty
                WeightErrorLbl.Text = "Field must not be empty";
                pass = 0;
            }
            else if (weight <=0)
            {
                WeightErrorLbl.Text = "Invalid number";
                pass = 0;
            }
            else
            {
                weight = Convert.ToDouble(WeightTB.Text);
                WeightErrorLbl.Text = "";
                pass = 1;
            }

            if (ProfilePictureErrorLbl.Text.Equals("Upload status: No file selected.") || ProfilePictureErrorLbl.Text.Equals("Upload status: Only image files (JPG, JPEG, PNG, GIF) are allowed."))
            {
                pass = 0;
            }
            else
            {
                pass = 1;
            }




            if (Request.Cookies["userCookie"] != null) //User
            {
                double weightGoal = Convert.ToDouble(WeightGoalTB.Text);
                if (string.IsNullOrEmpty(WeightGoalTB.Text))
                {
                    // Handle case where age input field is empty
                    WeightGoalTB.Text = "Field must not be empty";
                    pass = 0;
                }
                else if(weightGoal <= 0)
                {
                    WeightGoalErrorLbl.Text = "Invalid number";
                    pass = 0;
                }
                else
                {
                    weightGoal = Convert.ToDouble(WeightGoalTB.Text);
                    WeightGoalTB.Text = "";
                    pass = 1;
                }


                if(pass == 1)
                {
                    string userId = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);
                    userRepo.setAge(age, userId);
                    userRepo.setHeight(height, userId);
                    userRepo.setWeight(weight, userId);
                    userRepo.setWeightGoal(weightGoal, userId);

                    string FileName = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]).ToString() + "ProfilePicture";
                    userRepo.setProfilePicture(userId, FileName, fileExtension);
                    Response.Redirect("~/Views/ProfilePage.aspx");
                }

            }



            else if (Request.Cookies["trainerCookie"] != null) //Trainer
            {
                string trainerId = trainerRepo.getIdFromUsername(Request.Cookies["trainerCookie"]["Username"]);

                string phoneNumber = null;
                if (string.IsNullOrEmpty(PhoneTB.Text))
                {
                    // Handle case where age input field is empty
                    PhoneErrorLbl.Text = "Field must not be empty";
                    pass = 0;
                }
                else if (PhoneTB.Text.Length != 15)
                {
                    PhoneErrorLbl.Text = "Invalid phone number length (15)";
                    pass = 0;
                }
                else
                {
                    phoneNumber = PhoneTB.Text;
                    WeightGoalTB.Text = "";
                    pass = 1;
                }


                if (pass == 1)
                {
                    
                    trainerRepo.setAge(age, trainerId);
                    trainerRepo.setHeight(height, trainerId);
                    trainerRepo.setWeight(weight, trainerId);
                    trainerRepo.setPhone(phoneNumber, trainerId);

                    string FileName = userRepo.getIdFromUsername(Request.Cookies["trainerCookie"]["Username"]).ToString() + "ProfilePicture";
                    trainerRepo.setProfilePicture(trainerId, FileName, fileExtension);
                    Response.Redirect("~/Views/ProfilePage.aspx");
                }
            }

            else
            {

            }
        }

        protected void ChangeProfilePictureBtn_Click(object sender, EventArgs e)
        {
            userRepository userRepo = new userRepository();
            trainerRepository trainerRepo = new trainerRepository();

            if (ProfilePictureUpload.HasFile)
            {
                //fileExtension = Path.GetExtension(ProfilePictureUpload.FileName).ToLower();
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };

                if (Array.Exists(allowedExtensions, ext => ext == fileExtension))
                {
                    try
                    {
                        // Generate a new file name (e.g., using a GUID or timestamp)
                        string newFileName = null;
                        if (Request.Cookies["userCookie"] != null)
                        {
                            newFileName = userRepo.getIdFromUsername(Request.Cookies["userCookie"]["Username"]).ToString() + "ProfilePicture";
                        }
                        else if (Request.Cookies["trainerCookie"] != null)
                        {
                            newFileName = userRepo.getIdFromUsername(Request.Cookies["trainerCookie"]["Username"]).ToString() + "ProfilePicture";
                        }

                        // Save the file to the server (for example, in a "uploads" directory)
                        string savePath = HttpContext.Current.Server.MapPath("~/Assets/Images/User/UploadPics/") + newFileName + fileExtension;
                        ProfilePictureUpload.SaveAs(savePath);

                        // Optionally, update the user's profile picture in your database here with the new file name

                        ProfilePictureErrorLbl.Text = "Upload status: File uploaded!";
                        ProfilePictureImage.ImageUrl = "~/Assets/Images/User/UploadPics/" + newFileName + fileExtension;
                    }
                    catch (Exception ex)
                    {
                        Response.Write("Upload status: The file could not be uploaded. The following error occurred: " + ex.Message);
                    }
                }
                else
                {
                    ProfilePictureErrorLbl.Text = "Upload status: Only image files (JPG, JPEG, PNG, GIF) are allowed.";
                }
            }
            else
            {
                ProfilePictureErrorLbl.Text = "Upload status: No file selected.";
            }
        }

    }
}