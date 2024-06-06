using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Factories
{
    public class userFoodScheduleFactory
    {

        public static UserFoodSchedule create(string MealPlanId, string userId, string foodId, string mealTime)
        {
            UserFoodSchedule userFood = new UserFoodSchedule();
            userFood.MealPlanId = MealPlanId;
            userFood.userId = userId;
            userFood.foodId = foodId;
            userFood.mealTime = mealTime;

            return userFood;
        }

    }
}