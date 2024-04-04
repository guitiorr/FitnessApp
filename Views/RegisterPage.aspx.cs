using FitnessApp.Repositories;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UsernameTB.Attributes["placeholder"] = "Enter a unique username";
                PasswordTB.Attributes["placeholder"] = "6-50 characters";
            }
        }

        public string GenerateIdForUser()
        {
            userRepository userRepo = new userRepository();
            var newId = "";
            var lastId = userRepo.getLastId();

            if (lastId == null)
            {
                return "US001";
            }
            else
            {
                var idNumber = Convert.ToInt32(lastId.Substring(2)) + 1;
                newId = string.Format("US{0:000}", idNumber);
                return newId;
            }
        }

        public string GenerateIdForTrainer()
        {
            trainerRepository trainerRepo = new trainerRepository();
            var newId = "";
            var lastId = trainerRepo.getLastId();

            if (lastId == null)
            {
                return "TR001";
            }
            else
            {
                var idNumber = Convert.ToInt32(lastId.Substring(2)) + 1;
                newId = string.Format("TR{0:000}", idNumber);
                return newId;
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            userRepository userRepo = new userRepository();
            trainerRepository trainerRepo = new trainerRepository();
            var registerPass = 1;

            ListItem selectedItem = RegisterAsDropdown.SelectedItem;
            string registerAs = selectedItem.Text;

            String Id;
            var username = UsernameTB.Text;
            String checkUsername;
            if (registerAs.Equals("User")) 
            {
                checkUsername = userRepo.checkUsername(username);
            }
            else
            {
                checkUsername = trainerRepo.checkUsername(username);
            }
            
            
            var email = EmailTB.Text;

            String checkEmail;

            if (registerAs.Equals("User"))
            {
                checkEmail = userRepo.checkEmail(email);
            }
            else
            {
                checkEmail = trainerRepo.checkEmail(email);
            }



            var password = PasswordTB.Text;
            var password2 = Password2TB.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                registerPass = 0;
                UsernameErrorLbl.Text = "Username must not be empty!";
            }
            else if (checkUsername != null)
            {
                registerPass = 0;
                UsernameErrorLbl.Text = "Username already registered";
            }
            else
            {
                UsernameErrorLbl.Text = "";
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                registerPass = 0;
                EmailErrorLbl.Text = "Email must not be empty!";
            }
            else if (checkEmail != null)
            {
                registerPass = 0;
                EmailErrorLbl.Text = "Email already registered";
            }
            else
            {
                EmailErrorLbl.Text = "";
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                registerPass = 0;
                PasswordErrorLbl.Text = "Password must not be empty";
            }
            else if (password.Length < 6 || password.Length > 50)
            {
                registerPass = 0;
                PasswordErrorLbl.Text = password.Length < 6 ? "Password too short" : "Password too long";
            }
            else
            {
                PasswordErrorLbl.Text = "";
            }

            if (password2 != password)
            {
                registerPass = 0;
                Password2ErrorLbl.Text = "Password doesn't match!";
            }
            else
            {
                Password2ErrorLbl.Text = "";
            }

            int age = Convert.ToInt32(AgeTB.Text);

            if(age < 18)
            {
                AgeErrorLbl.Text = "Age must be above 18!";
                registerPass = 0;
            }
            else
            {
                AgeErrorLbl.Text = "";
                registerPass = 1;
            }

            

            String gender = GenderDropdown.Text;

            String FullName = FullNameTB.Text;
            



            if (registerPass == 1 && registerAs.Equals("User"))
            {
                Id = GenerateIdForUser();
                userRepo.insertUser(Id, username, password, email, age, gender, FullName);
                Response.Redirect("~/Views/HomePage.aspx");
            }
            else if(registerPass == 1 && registerAs.Equals("Trainer"))
            {
                Id = GenerateIdForTrainer();
                trainerRepo.insertTrainer(Id, username, password, email, age, gender, FullName);
                Response.Redirect("~/Views/HomePage.aspx");
            }

        }
    }
}
