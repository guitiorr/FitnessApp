﻿using FitnessApp.Factories;
using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Repositories
{
    
    public class trainerRepository
    {
        public static List<Trainer> trainers = null;
        public static FitnessAppDatabaseEntities db = DatabaseSingleton.getInstance();

        public List<Trainer> getTrainer()
        {
            return (from x in db.Trainers select x).ToList();
        }

        public String getIdFromUsername(String username)
        {
            return (from x in db.Trainers where x.Username.Equals(username) select x.trainerId).FirstOrDefault();
        }

        public String checkPassword(String id, String Password)
        {
            return (from x in db.Trainers where x.trainerId.Equals(id) && x.Password.Equals(Password) select x.Password).ToList().FirstOrDefault();
        }

        public String checkUsername(String Username)
        {
            return (from x in db.Trainers where x.Username.Equals(Username) select x.Username).FirstOrDefault();
        }

        public String checkEmail(String Email)
        {
            return (from x in db.Trainers where x.Email.Equals(Email) select x.Email).FirstOrDefault();
        }


        public void insertTrainer(String userId, String Username, String Password, String Email, int Age, String Gender, String FullName)
        {
            Trainer trainer = trainerFactory.create(userId, Username, Password, Email, Age, Gender, FullName);
            db.Trainers.Add(trainer);
            db.SaveChanges();
        }

        public String getLastId()
        {
            return (from x in db.Trainers select x.trainerId).ToList().LastOrDefault();
        }

    }
}