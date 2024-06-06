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


    }
}