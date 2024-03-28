using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Repositories
{
    public class DatabaseSingleton
    {
        public static FitnessAppDatabaseEntities db = null;

        public static FitnessAppDatabaseEntities getInstance()
        {
            if(db == null)
            {
                db = new FitnessAppDatabaseEntities();
            }

            return db;
        }

    }
}