using CS321_W4D2ExerciseLogAPI.Core.Models;
using CS321_W4D2ExerciseLogAPI.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{
    class ActivityTypeRepository : IActivityTypeRepository
    {
        private readonly AppDbContext _dbContext;

        public ActivityTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ActivityType Add(ActivityType newActivityType)
        {
            _dbContext.Add(newActivityType);
            _dbContext.SaveChanges();
            return newActivityType;
        }
        
        public ActivityType Get(int id)
        {

            return _dbContext.activityType.SingleOrDefault(a => a.Id == id);
             
             
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _dbContext.activityType.ToList();
              
              
        }

        public void Remove(ActivityType activityType)
        {
            var currentActivityType = _dbContext.activityType.Find(activityType.Id);
            if (currentActivityType != null)
                _dbContext.Remove(activityType);
            _dbContext.SaveChanges();
        }

        public ActivityType Update(ActivityType newActivityType)
        {

            var currentActivivtyType = _dbContext.activityType.FirstOrDefault(b => b.Id == newActivityType.Id);
            if (currentActivivtyType == null) return null;
            _dbContext.Entry(currentActivivtyType).CurrentValues.SetValues(newActivityType);
            _dbContext.Update(currentActivivtyType);
            _dbContext.SaveChanges();
            return currentActivivtyType;
        }
    }
}
