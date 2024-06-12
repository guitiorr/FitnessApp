using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Factories
{
    public class ExerciseScheduleFactory
    {

        public static UserExerciseSchedule create(string ExercisePlanID, string userID, string exerciseID, int reps, int sets)
        {
            UserExerciseSchedule schedule = new UserExerciseSchedule();
            schedule.ExercisePlanID = ExercisePlanID;
            schedule.UserId = userID;
            schedule.ExerciseID = exerciseID;
            schedule.Reps = reps;
            schedule.Sets = sets;

            return schedule;
        }

    }
}