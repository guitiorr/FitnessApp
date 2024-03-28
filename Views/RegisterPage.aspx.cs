using FitnessApp.Repositories;
using System;
using System.Web.UI;

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

        public string GenerateId()
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

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            userRepository userRepo = new userRepository();
            var registerPass = 1;

            var userId = GenerateId();
            var username = UsernameTB.Text;
            var checkUsername = userRepo.checkUsername(username);
            var email = EmailTB.Text;
            var checkEmail = userRepo.checkEmail(email);
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

            if (registerPass == 1)
            {
                userRepo.insertUser(userId, username, password, email);
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }
    }
}
