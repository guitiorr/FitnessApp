﻿using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            userRepository userRepo = new userRepository();
            trainerRepository trainerRepo = new trainerRepository();
            int loginPass = 1;

            String Username = usernameTB.Text;
            String Password = passwordTB.Text;
            String userId = userRepo.getIdFromUsername(Username);
            String trainerId = trainerRepo.getIdFromUsername(Username);

            if(userId == null && trainerId == null)
            {
                usernameErrorLbl.Text = "User not found!";
                loginPass = 0;
            }
            else
            {
                loginPass = 1;
                usernameErrorLbl.Text = "";
            }


            String checkPassword = userRepo.checkPassword(userId, Password);
            String checkPasswordTrainer = trainerRepo.checkPassword(trainerId, Password);

            if(checkPassword == null && checkPasswordTrainer == null)
            {
                passwordErrorLbl.Text = "Incorrect Password!";
                loginPass = 0;
            }
            else
            {
                loginPass = 1;
                passwordErrorLbl.Text = "";
            }

            if(loginPass == 1)
            {
                if (userId != null)
                {
                    HttpCookie authCookie = new HttpCookie("userCookie");
                    authCookie.Values["Username"] = Username;
                    authCookie.Values["UserID"] = userId;
                    authCookie.Expires = DateTime.Now.AddHours(1);

                    Response.Cookies.Add(authCookie);


                    String member = userRepo.GetMembershipLevelFromUserId(userId);

                    if(member == null)
                    {
                        Response.Redirect("~/Views/MembersPage.aspx");
                    }
                    else
                    {
                        Response.Redirect("~/Views/HomePage.aspx");
                    }
                }
                else if(trainerId != null)
                {
                    HttpCookie authCookie = new HttpCookie("trainerCookie");
                    authCookie.Values["Username"] = Username;
                    authCookie.Expires = DateTime.Now.AddHours(1);

                    Response.Cookies.Add(authCookie);

                    Response.Redirect("~/Views/HomePage.aspx");
                }


                // Response.Redirect("~/Views/HomePage.aspx");
            }


        }
    }
}