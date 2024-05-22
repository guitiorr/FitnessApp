using FitnessApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp.Views
{
    public partial class MembersPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected String getUserIdFromCookie()
        {
            return Request.Cookies["userCookie"]["UserID"];
        }

        protected void PurchaseMemberButton3_Click(object sender, EventArgs e)
        {
            userRepository userRepo = new userRepository();

            if (Request.Cookies["userCookie"] != null)
            {
                if(userRepo.GetMembershipLevelFromUserId(getUserIdFromCookie()) == null)
                { 
                    userRepo.addMembership(getUserIdFromCookie(), "Gold");
                }
            }

            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void PurchaseMemberButton2_Click(object sender, EventArgs e)
        {
            userRepository userRepo = new userRepository();

            if (Request.Cookies["userCookie"] != null)
            {
                if (userRepo.GetMembershipLevelFromUserId(getUserIdFromCookie()) == null)
                {
                    userRepo.addMembership(getUserIdFromCookie(), "Silver");
                }
            }

            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void PurchaseMemberButton1_Click(object sender, EventArgs e)
        {
            userRepository userRepo = new userRepository();

            if (Request.Cookies["userCookie"] != null)
            {
                if (userRepo.GetMembershipLevelFromUserId(getUserIdFromCookie()) == null)
                {
                    userRepo.addMembership(getUserIdFromCookie(), "Bronze");
                }
            }

            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}