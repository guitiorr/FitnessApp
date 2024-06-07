using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Repositories
{
    public class FoodRepository
    {
        public static List<Food> foods = null;
        private static FitnessAppDatabaseEntities db = DatabaseSingleton.getInstance();

        public string getFoodIdFromFoodName(string foodName)
        {
            return (from x in db.Foods where x.FoodName.Equals(foodName) select x.FoodId).FirstOrDefault();
        }

        public List<Food> getFoods()
        {
            return (from x in db.Foods select x).ToList();
        }

        public string getFoodNameFromId(string foodId)
        {
            return (from x in db.Foods where x.FoodId.Equals(foodId) select x.FoodName).ToString();
        }

        public Food getFoodById(string foodId)
        {
            return (from x in db.Foods where x.FoodId.Equals(foodId) select x).ToList().FirstOrDefault();
        }

    }
}