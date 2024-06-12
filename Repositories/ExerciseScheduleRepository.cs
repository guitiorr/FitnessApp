using FitnessApp.Factories;
using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Repositories
{
    public class ExerciseScheduleRepository
    {
        private static FitnessAppDatabaseEntities db = DatabaseSingleton.getInstance();


        public List<UserExerciseSchedule> getScheduleList()
        {
            return (from x in db.UserExerciseSchedules select x).ToList();
        }

        public List<UserExerciseSchedule> getScheduleListFilterUserID(string userId)
        {
            return (from x in db.UserExerciseSchedules where x.UserId.Equals(userId) select x).ToList();
        }

        public UserExerciseSchedule getScheduleFromUserID(string userId)
        {
            return (from x in db.UserExerciseSchedules where x.UserId.Equals(userId) select x).ToList().FirstOrDefault();
        }

        public UserExerciseSchedule getScheduleFromPlanID(string planID)
        {
            return (from x in db.UserExerciseSchedules where x.ExercisePlanID.Equals(planID) select x).ToList().FirstOrDefault();
        }

        public string getScheduleIDFromUserID(string userId)
        {
            return (from x in db.UserExerciseSchedules where x.UserId.Equals(userId) select x.ExercisePlanID).FirstOrDefault();
        }

        public void deleteScheduleFromUserID(string userId)
        {
            UserExerciseSchedule schedule = getScheduleFromUserID(userId);
            db.UserExerciseSchedules.Remove(schedule);
            db.SaveChanges();
        }

        public void deleteScheduleFromExercisePlanID(string exercisePlanID)
        {
            UserExerciseSchedule schedule = getScheduleFromPlanID(exercisePlanID);
            db.UserExerciseSchedules.Remove(schedule);
            db.SaveChanges();
        }

        public String getLastId()
        {
            return (from x in db.UserExerciseSchedules select x.ExercisePlanID).ToList().LastOrDefault();
        }

        public string findId(string id)
        {
            return (from x in db.UserExerciseSchedules where x.ExercisePlanID.Equals(id) select x.ExercisePlanID).FirstOrDefault();
        }

        public void insertSchedule(string ExercisePlanID, string userID, string exerciseID, int reps, int sets)
        {
            UserExerciseSchedule schedule = ExerciseScheduleFactory.create(ExercisePlanID, userID, exerciseID, reps, sets);
            db.UserExerciseSchedules.Add(schedule);
            db.SaveChangesAsync();
        }

    }
}