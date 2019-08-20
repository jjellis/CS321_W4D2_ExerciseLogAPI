using CS321_W4D2ExerciseLogAPI.Core.Models;
using CS321_W4D2ExerciseLogAPI.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    class ActivityRepository : IActivityRepository
    {
        private readonly AppDbContext _dbContext;

        public ActivityRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Activity Add(Activity newActivity)
        {
            _dbContext.Add(newActivity);
            _dbContext.SaveChanges();
            return newActivity;
        }

        public Activity Get(int id)
        {

            return _dbContext.activity.SingleOrDefault(a => a.Id == id);


        }

        public IEnumerable<Activity> GetAll()
        {
            return _dbContext.activity.ToList();


        }

        public void Remove(Activity activity)
        {
            var currentActivity = _dbContext.activity.Find(activity.Id);
            if (currentActivity != null)
                _dbContext.Remove(activity);
            _dbContext.SaveChanges();
        }

        public Activity Update(Activity newActivity)
        {

            var currentActivity = _dbContext.activity.FirstOrDefault(b => b.Id == newActivity.Id);
            if (currentActivity == null) return null;
            _dbContext.Entry(currentActivity).CurrentValues.SetValues(newActivity);
            _dbContext.Update(currentActivity);
            _dbContext.SaveChanges();
            return currentActivity;
        }
    }
}
