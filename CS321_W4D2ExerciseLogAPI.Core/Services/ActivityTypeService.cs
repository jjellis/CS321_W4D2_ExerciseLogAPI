using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2ExerciseLogAPI.Core.Models;

using System.Linq;

namespace CS321_W4D2ExerciseLogAPI.Core.Services
{
    public class ActivityTypeService : IActivityTypeRepository
    {
        private readonly IActivityTypeRepository _activityTypeRepo;

        public ActivityTypeService(IActivityTypeRepository activityTypeRepo)
        {
            _activityTypeRepo = activityTypeRepo;
        }

        public ActivityType Add(ActivityType newActivityType)
        {
                _activityTypeRepo.Add(newActivityType);
                _activityTypeRepo.SaveChanges();
                return newActivityType;
        }

        public ActivityType Get(int id)
        {
            return _activityTypeRepo.activityType.SingleOrDefault(a => a.Id == id);
            
             
        }

        public IEnumerable<ActivityType> GetAll()
        {
            return _activityTypeRepo.activtyType.ToList();
             
             
        }

        public void Remove(ActivityType activityType)
        {
            var currentActivityType = _activityTypeRepo.Find(activityType.Id);
            if (currentActivityType != null)
                _activityTypeRepo.Remove(activityType);
            _activityTypeRepo.SaveChanges();
        }

        public ActivityType Update(ActivityType updatedActivityType)
        {
            var currentActivivtyType = _activityTypeRepo.FirstOrDefault(b => b.Id == updatedActivityType.Id);
            if (currentActivivtyType == null) return null;
            _activityTypeRepo.Entry(currentActivivtyType).CurrentValues.SetValues(updatedActivityType);
            _activityTypeRepo.Update(currentActivivtyType);
            _activityTypeRepo.SaveChanges();
            return currentActivivtyType;
        }
    }
}
