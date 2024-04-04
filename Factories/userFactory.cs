using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Factories
{
    public class userFactory
    {
        public static User create(String userId, String Username, String Password, String Email, int Age, String Gender, String FullName)
        {
            User user = new User();
            user.userId = userId;
            user.Username = Username;
            user.Password = Password;
            user.Email = Email;
            user.Age = Age;
            user.Gender = Gender;
            user.FullName = FullName;
            return user;
        }

    }
}