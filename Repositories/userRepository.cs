﻿using FitnessApp.Factories;
using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Web;

namespace FitnessApp.Repositories
{

    public class userRepository
    {

        public static List<User> users = null;
        public static FitnessAppDatabaseEntities db = DatabaseSingleton.getInstance();

        public List<User> getUser()
        {
            return (from x in db.Users select x).ToList();
        }


        public String getIdFromUsername(String username)
        {
            return (from x in db.Users where x.Username.Equals(username) select x.userId).FirstOrDefault();
        }

        public String checkPassword(String id, String Password)
        {
            return (from x in db.Users where x.userId.Equals(id) && x.Password.Equals(Password) select x.Password).ToList().FirstOrDefault();
        }

        public String checkUsername(String Username)
        {
            return (from x in db.Users where x.Username.Equals(Username) select x.Username).FirstOrDefault();
        }

        public String checkEmail(String Email)
        {
            return (from x in db.Users where x.Email.Equals(Email) select x.Email).FirstOrDefault();
        }

        public void addMembership(String userId, String membership)
        {
            User user = getUserFromId(userId);

            if (user == null)
            {
                throw new Exception("User not found");
            }
            user.MemberLevel = membership;
            db.SaveChanges();
        }

        public String GetMembershipLevelFromUserId(string userId)
        {
            return (from x in db.Users where x.userId.Equals(userId) select x.MemberLevel).FirstOrDefault();
        }


        public User getUserFromId(String Id)
        {
            return (from x in db.Users where x.userId.Equals(Id) select x).ToList().FirstOrDefault();
        }

        public void insertUser(String userId, String Username, String Password, String Email, int Age, String Gender, String FullName)
        {
            User user = userFactory.create(userId, Username, Password, Email, Age, Gender, FullName);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public String getLastId()
        {
            return(from x in db.Users select x.userId).ToList().LastOrDefault();
        }

        public String getUsernameFromId(String Id)
        {
            return(from x in db.Users where x.userId.Equals(Id) select x.Username).FirstOrDefault();
        }

        public String getEmailFromId(String Id)
        {
            return (from x in db.Users where x.userId.Equals(Id) select x.Email).FirstOrDefault();
        }

        public int getAgeFromId(String Id)
        {
            return (from x in db.Users where x.userId.Equals(Id) select x.Age).FirstOrDefault();
        }

        public double? getHeightFromId(String Id)
        {
            return (from x in db.Users where x.userId.Equals(Id) select x.Height).FirstOrDefault();
        }

        public double? getWeightFromId(String Id)
        {
            return (from x in db.Users where x.userId.Equals(Id) select x.Weight).FirstOrDefault();
        }

        private byte[] ConvertImageToBinary(string imagePath)
        {
            return File.ReadAllBytes(imagePath);
        }

        public void setDefaultImage()
        {
            string defaultImagePath = HttpContext.Current.Server.MapPath("~/Assets/Images/User/defaultProfile.png");
            byte[] defaultImage = ConvertImageToBinary(defaultImagePath);

            var usersWithoutProfilePicture = from user in db.Users
                                             where user.ProfilePicture == null
                                             select user;

            foreach (var user in usersWithoutProfilePicture)
            {
                user.ProfilePicture = defaultImage;
            }

            db.SaveChanges();
        }

        public byte[] GetProfilePictureFromId(string userId)
        {
            return (from x in db.Users where x.userId.Equals(userId) select x.ProfilePicture).FirstOrDefault();
        }

    }
}