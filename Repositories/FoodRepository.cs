using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FitnessApp.Repositories
{
    public class FoodRepository
    {
        public static List<Food> foods = null;
        private static FitnessAppDatabaseEntities db = DatabaseSingleton.getInstance();

        public async Task<string> GetFoodIdFromFoodNameAsync(string foodName)
        {
            using (var context = new FitnessAppDatabaseEntities())
            {
                return await (from x in context.Foods
                              where x.FoodName.Equals(foodName)
                              select x.FoodId)
                              .FirstOrDefaultAsync() ?? "";
            }
        }

        public string getFoodIdFromFoodName(string foodName)
        {
            return (from x in db.Foods where x.FoodName.Equals(foodName) select x.FoodId).FirstOrDefault();
        }

        public List<Food> getFoods()
        {
            return (from x in db.Foods select x).ToList();
        }

        public async Task<List<Food>> GetFoodsAsync()
        {
            using (var context = new FitnessAppDatabaseEntities())
            {
                return await context.Foods.ToListAsync();
            }
        }


        public async Task<string> GetFoodNameFromIdAsync(string foodId)
        {
            using (var context = new FitnessAppDatabaseEntities())
            {
                return await context.Foods
                                    .Where(x => x.FoodId.Equals(foodId))
                                    .Select(x => x.FoodName)
                                    .FirstOrDefaultAsync();
            }
        }


        public string getFoodNameFromId(string foodId)
        {
            return (from x in db.Foods where x.FoodId.Equals(foodId) select x.FoodName).FirstOrDefault();
        }

        public Food getFoodById(string foodId)
        {
            return (from x in db.Foods where x.FoodId.Equals(foodId) select x).ToList().FirstOrDefault();
        }

    }
}