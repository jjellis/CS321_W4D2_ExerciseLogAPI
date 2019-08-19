using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2ExerciseLogAPI.Core.Models;

namespace CS321_W4D2ExerciseLogAPI.Core.Services
{
    public class ActivityTypeService : IActivityTypeRepository
    {
        private IActivityTypeRepository _activityTypeRepo;

        public ActivityTypeService(IActivityTypeRepository activityTypeRepo)
        {
            _activityTypeRepo = activityTypeRepo;
        }

        public ActivityType Add(ActivityType todo)
        {
            throw new NotImplementedException();
        }

        public ActivityType Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ActivityType> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(ActivityType todo)
        {
            throw new NotImplementedException();
        }

        public ActivityType Update(ActivityType todo)
        {
            throw new NotImplementedException();
        }
    }
}
