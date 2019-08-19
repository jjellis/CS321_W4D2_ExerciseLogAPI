using CS321_W4D2ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2ExerciseLogAPI.Core.Services
{
    public interface IActivityRepository
    {
        Activity Add(Activity newActivity);
        // Read
        Activity Get(int id);
        // Update
        Activity Update(Activity updatedActivity);
        // Delete
        void Remove(Activity activity);
        // List
        IEnumerable<Activity> GetAll();
    }
}
