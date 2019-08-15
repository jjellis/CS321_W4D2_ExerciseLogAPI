using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2ExerciseLogAPI.Core.Services
{
    private IActivityRepository _activityRepo;

    public ActivityService(IActivityRepository ActivityRepo)
    {
        _activityRepo = activityRepo;
    }
    class ActivityService
    {

    }