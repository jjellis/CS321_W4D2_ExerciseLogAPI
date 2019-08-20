using CS321_W4D2ExerciseLogAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2ExerciseLogAPI.Core.Services
{
    public interface IUserRepository
    {
        // Create
        User Add(User newUser);
        // Read
        User Get(int id);
        // Update
        User Update(User updatedUser);
        // Delete
        void Remove(User user);
        // List
        IEnumerable<User> GetAll();
    }
}
