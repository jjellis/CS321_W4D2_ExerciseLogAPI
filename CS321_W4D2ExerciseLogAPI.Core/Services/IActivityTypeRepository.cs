using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2ExerciseLogAPI.Core.Models;

namespace CS321_W4D2ExerciseLogAPI.Core.Services
{
    public interface IActivityTypeRepository
    {
        ActivityType Add(ActivityType todo);
        // Read
        ActivityType Get(int id);
        // Update
        ActivityType Update(ActivityType todo);
        // Delete
        void Remove(ActivityType todo);
        // List
        IEnumerable<ActivityType> GetAll();
    }
}
