using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2ExerciseLogAPI.Core.Models;

namespace CS321_W4D2ExerciseLogAPI.Core.Services
{
    public class ActivityService : IActivityRepository {
        private IActivityRepository _activityRepo;

        public ActivityService(IActivityRepository activityRepo)
        {
            _activityRepo = activityRepo;
        }

        public Activity Add(Activity newActivity)
        {
            _activityRepo.ActivityService.Add(newActivityService);
            _activityRepo.SaveChanges();
            return newActivityService;
        }

        public Activity Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> GetAll()
        {
            return _activityRepo.activityService
                .Include(a => a.ActivityService)
                .ToList();
        }

        public void Remove(Activity todo)
        {
            var CurrentActivityService = _activityRepo.activityService.Find(activityService.Id);
            if (CurrentActivityService != null)
                _activityRepo.activity.Remove(activity);
            _activityRepo.SaveChanges();
        }

        public Activity Update(Activity updatedActivity)
        {
            var currentActivity = _activityRepo.activity.FirstOrDefault(b => b.Id == updatedActivty.Id);
            if (currentActivity == null) return null;
            _activityRepo.Entry(currentActivity).CurrentValues.SetValues(updatedActivty);
            _activityRepo.Update(currentActivity);
            _activityRepo.SaveChanges();
            return currentActivity;
        }
    }
    