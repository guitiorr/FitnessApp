using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Factories
{
    public class trainerFactory
    {
        public static Trainer create(String userId, String Username, String Password, String Email, int Age, String Gender, String FullName)
        {
            Trainer trainer = new Trainer();
            trainer.trainerId = userId;
            trainer.Username = Username;
            trainer.Password = Password;
            trainer.Email = Email;
            trainer.Age = Age;
            trainer.Gender = Gender;
            trainer.FullName = FullName;
            return trainer;
        }
    }
}