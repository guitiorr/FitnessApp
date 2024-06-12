using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public string getExerciseIDFromExerciseName(string name)
        {
            return (from x in db.Exercises where x.ExerciseName.Equals(name) select x.ExerciseID).FirstOrDefault();
        }



    }
}