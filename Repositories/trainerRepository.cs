using FitnessApp.Factories;
using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
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


        public void insertTrainer(String trainerId, String Username, String Password, String Email, int Age, String Gender, String FullName)
        {
            Trainer trainer = trainerFactory.create(trainerId, Username, Password, Email, Age, Gender, FullName);
            db.Trainers.Add(trainer);
            db.SaveChanges();
        }

        public String getLastId()
        {
            return (from x in db.Trainers select x.trainerId).ToList().LastOrDefault();
        }

        public String getEmailFromUsername(String username)
        {
            return (from x in db.Trainers where x.Username.Equals(username) select x.Email).FirstOrDefault();
        }

        public int getAgeFromUsername(String username)
        {
            return (from x in db.Trainers where x.Username.Equals(username) select x.Age).FirstOrDefault();
        }

        public double? getHeightFromUsername(String username)
        {
            return (from x in db.Trainers where x.Username.Equals(username) select x.Height).FirstOrDefault();
        }

        public double? getWeightFromUsername(String username)
        {
            return (from x in db.Trainers where x.Username.Equals(username) select x.Weight).FirstOrDefault();
        }

        private byte[] ConvertImageToBinary(string imagePath)
        {
            return File.ReadAllBytes(imagePath);
        }

        public void setDefaultImage()
        {
            string defaultImagePath = HttpContext.Current.Server.MapPath("~/Assets/Images/User/defaultProfile.png");
            byte[] defaultImage = ConvertImageToBinary(defaultImagePath);

            var trainersWithoutProfilePicture = from trainer in db.Trainers
                                             where trainer.ProfilePicture == null
                                             select trainer;

            foreach (var trainer in trainersWithoutProfilePicture)
            {
                trainer.ProfilePicture = defaultImage;
            }

            db.SaveChanges();
        }

        public string GetProfilePictureUrlFromId(string trainerId)
        {
            byte[] profilePicture = GetProfilePictureFromId(trainerId);
            if (profilePicture == null || profilePicture.Length == 0)
            {
                // Return a default image URL if no picture is found
                return HttpContext.Current.Server.MapPath("~/Assets/Images/User/defaultProfile.png");
            }

            string base64String = Convert.ToBase64String(profilePicture);
            return $"data:image/jpeg;base64,{base64String}";
        }

        public byte[] GetProfilePictureFromId(string trainerId)
        {
            return (from x in db.Trainers where x.trainerId.Equals(trainerId) select x.ProfilePicture).FirstOrDefault();
        }

        public Trainer getTrainerFromId(String Id)
        {
            return (from x in db.Trainers where x.trainerId.Equals(Id) select x).ToList().FirstOrDefault();
        }

        public void setAge(int age, String trainerId)
        {
            Trainer trainer = getTrainerFromId(trainerId);
            trainer.Age = age;
            db.SaveChanges();
        }

        public void setHeight(double height, String trainerId)
        {
            Trainer trainer = getTrainerFromId(trainerId);
            trainer.Height = height;
            db.SaveChanges();
        }

        public void setWeight(double weight, String trainerId)
        {
            Trainer trainer = getTrainerFromId(trainerId);
            trainer.Weight = weight;
            db.SaveChanges();
        }

        public void setProfilePicture(string trainerId, string fileName, string extension)
        {
            Trainer trainer = getTrainerFromId(trainerId);
            string imagePath = HttpContext.Current.Server.MapPath("~/Assets/Images/User/UploadPics/" + fileName + extension);

            byte[] imageByte = ConvertImageToBinary(imagePath);

            trainer.ProfilePicture = imageByte;

            db.SaveChanges();
        }

    }
}