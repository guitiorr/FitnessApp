using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Factories
{
    public class classFactory
    {
        public static Food create(string foodId, int Kcal, int Fat, int Carbs, int Sugar, byte[] FoodPicture, int Protein)
        {
            Food food = new Food();
            food.FoodId = foodId;
            food.Kcal = Kcal;
            food.Fat = Fat;
            food.Carbs = Carbs;
            food.Sugar = Sugar;
            food.FoodPicture = FoodPicture;
            food.Protein = Protein;
            return food;
        }


    }
}