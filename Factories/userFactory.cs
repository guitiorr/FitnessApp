using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Factories
{
    public class userFactory
    {
        public static User create(String userId, String Username, String Password, String Email)
        {
            User user = new User();
            user.userId = userId;
            user.Username = Username;
            user.Password = Password;
            user.Email = Email;
            return user;
        }

    }
}