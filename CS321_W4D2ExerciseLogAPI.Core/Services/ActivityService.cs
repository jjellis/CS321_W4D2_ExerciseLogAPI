using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2ExerciseLogAPI.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace CS321_W4D2ExerciseLogAPI.Core.Services
{
    public class ActivityService : IActivityRepository {
        private readonly IActivityRepository _activityRepo;

        public ActivityService(IActivityRepository activityRepo)
        {
            _activityRepo = activityRepo;
        }

        public Activity Add(Activity newActivity)
        {
            _activityRepo.Add(newActivity);
            _activityRepo.SaveChanges();
            return newActivity;
        }

        public Activity Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> GetAll()
        {
            return _activityRepo
                .Include(a => a.ActivityService)
                .ToList();
        }

        public void Remove(Activity todo)
        {
            var CurrentActivityService = _activityRepo.Find(Activity.Id);
            if (CurrentActivityService != null)
                _activityRepo.Remove();
            _activityRepo.SaveChanges();
        }

        public Activity Update(Activity updatedActivity)
        {
            var currentActivity = _activityRepo.FirstOrDefault(b => b.Id == updatedActivty.Id);
            if (currentActivity == null) return null;
            _activityRepo.Entry(currentActivity).CurrentValues.SetValues(updatedActivity);
            _activityRepo.Update(currentActivity);
            _activityRepo.SaveChanges();
            return currentActivity;
        }
    }
    