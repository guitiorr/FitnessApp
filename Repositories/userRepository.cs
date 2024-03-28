using FitnessApp.Factories;
using FitnessApp.Models;
using System;
using System.Collections.Generic;
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


        public void insertUser(String userId, String Username, String Password, String Email)
        {
            User user = userFactory.create(userId, Username, Password, Email);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public String getLastId()
        {
            return(from x in db.Users select x.userId).ToList().LastOrDefault();
        }

    }
}