﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Layouts
{
    public partial class Header : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["userCookie"] != null) //Authenticated as regular user
                {
                    string username = Request.Cookies["userCookie"]["Username"];
                    LogStatusLbl.Text = "Logged into " + username + "as user";
                    LogOutButton.Visible = true; //Show logout button
                    LoginButton.Visible = false; //Hide login button
                    RegisterButton.Visible = false; //Hide register button
                    MealButton.Visible = true; //Show Meal button
                    TrainerButton.Visible = true; //Show trainer button
                    ExerciseButton.Visible = true; //Show exercise button
                }
                else if (Request.Cookies["trainerCookie"] != null) //Authenticated as trainer
                {
                    string username = Request.Cookies["trainerCookie"]["Username"];
                    LogStatusLbl.Text = "Logged into " + username + " as trainer";
                    LogOutButton.Visible = true; ///Show logout button
                    LoginButton.Visible = false; //Hide login button
                    RegisterButton.Visible = false; //Hide register button
                    MealButton.Visible = false; //Hide Meal button
                    TrainerButton.Visible = false ; //Hide trainer button
                    ExerciseButton.Visible = false; //Hide exercise button
                }
                else //User not authenticated
                {
                    LoginButton.Visible = true; //Show login button
                    RegisterButton.Visible = true; //Show register button
                    LogOutButton.Visible = false; //Hide logout button
                    MealButton.Visible = false; //Hide Meal button
                    TrainerButton.Visible = false; //Hide trainer button
                    ExerciseButton.Visible = false; //Hide exercise button
                    LogStatusLbl.Text = "You are not logged in";
                }
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }

        protected void LogOutButton_Click(object sender, EventArgs e)
        {

            if (Request.Cookies["userCookie"] != null)
            {
                HttpCookie authCookie = new HttpCookie("userCookie");
                authCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(authCookie);
            }
            if (Request.Cookies["trainerCookie"] != null)
            {
                HttpCookie authCookie = new HttpCookie("trainerCookie");
                authCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(authCookie);
            }

            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void MealButton_Click(object sender, EventArgs e)
        {

        }

        protected void TrainerButton_Click(object sender, EventArgs e)
        {

        }

        protected void ExerciseButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ExerciseVideoPage.aspx");
        }
    }
}