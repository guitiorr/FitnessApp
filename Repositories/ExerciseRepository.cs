using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FitnessApp.Repositories
{
    public class ExerciseRepository
    {
        private static FitnessAppDatabaseEntities db = DatabaseSingleton.getInstance();


        public List<Exercise> getExerciseList()
        {
            return (from x in db.Exercises select x).ToList();
        }

        public async Task<List<Exercise>> getExerciseListAsync()
        {
            return await (from x in db.Exercises select x).ToListAsync();
        }

        public string getExerciseIDFromExerciseName(string name)
        {
            return (from x in db.Exercises where x.ExerciseName.Equals(name) select x.ExerciseID).FirstOrDefault();
        }

        public async Task<string> GetExerciseIDFromExerciseNameAsync(string name)
        {
            return await (from x in db.Exercises where x.ExerciseName.Equals(name) select x.ExerciseID).FirstOrDefaultAsync();
        }

        public string getExerciseNameFromID(string id)
        {
            return (from x in db.Exercises where x.ExerciseID.Equals(id) select x.ExerciseName).FirstOrDefault();
        }

        public async Task<string> GetExerciseNameFromIDAsync(string id)
        {
            return await (from x in db.Exercises where x.ExerciseID.Equals(id) select x.ExerciseName).FirstOrDefaultAsync();
        }



    }
}