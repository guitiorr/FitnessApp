using FitnessApp.Factories;
using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace FitnessApp.Repositories
{
    public class userFoodScheduleRepository
    {
        public static List<userFoodScheduleRepository> userFood = null;
        public static FitnessAppDatabaseEntities db = DatabaseSingleton.getInstance();

        public List<UserFoodSchedule> getSchedule()
        {
            return (from x in db.UserFoodSchedules select x).ToList();
        }

        public UserFoodSchedule getScheduleFromId(string MealPlanId)
        {
            return (from x in db.UserFoodSchedules where x.MealPlanId.Equals(MealPlanId) select x).ToList().FirstOrDefault();
        }

        public UserFoodSchedule getScheduleFromUserId(string userId)
        {
            return (from x in db.UserFoodSchedules where x.userId.Equals(userId) select x).ToList().FirstOrDefault();
        }

        public List<UserFoodSchedule> getScheduleListFromUserId(string userId)
        {
            return (from x in db.UserFoodSchedules where x.userId.Equals(userId) select x).ToList();
        }

        public String getLastId()
        {
            return (from x in db.UserFoodSchedules select x.MealPlanId).ToList().LastOrDefault();
        }

        public string GenerateIdForUserFoodSchedule()
        {
            var newId = "";
            var lastId = getLastId();

            if (lastId == null)
            {
                return "ML001";
            }
            else
            {
                var idNumber = Convert.ToInt32(lastId.Substring(2)) + 1;
                newId = string.Format("ML{0:000}", idNumber);
                return newId;
            }
        }
        public void insertSchedule(string userId, string foodId, string mealTime)
        {
            string id = GenerateIdForUserFoodSchedule();
            UserFoodSchedule foodSchedule = userFoodScheduleFactory.create(id, userId, foodId, mealTime);
            db.UserFoodSchedules.Add(foodSchedule);
            db.SaveChanges();
        }

        public string getFoodIdFromUserId(string userId)
        {
            return (from x in db.UserFoodSchedules where x.userId.Equals(userId) select x.foodId).FirstOrDefault();
        }

        public void deleteSchedule(string MealPlanId)
        {
            UserFoodSchedule schedule = getScheduleFromId(MealPlanId);
            db.UserFoodSchedules.Remove(schedule);
            db.SaveChanges();
        }

        public string getIdFromUserId(string userId)
        {
            return (from x in db.UserFoodSchedules where x.userId.Equals(userId) select x.MealPlanId).FirstOrDefault();
        }


    }
}