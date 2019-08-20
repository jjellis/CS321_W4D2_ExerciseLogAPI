using CS321_W4D2ExerciseLogAPI.Core.Models;
using CS321_W4D2ExerciseLogAPI.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS321_W4D2_ExerciseLogAPI.Infrastructure.Data
{

    class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User Add(User newUser)
        {
            _dbContext.users.Add(newUser);
            _dbContext.SaveChanges();
            return newUser;
        }

        public User Get(int id)
        {
            return _dbContext.users.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _dbContext.users
                .Include(a => a.user)
                .ToList();
        }

        public void Remove(User user)
        {
            var currentUser = _dbContext.users.Find(user.Id);
            if (currentUser != null)
                _dbContext.users.Remove(user);
            _dbContext.SaveChanges();
        }

        public User Update(User updatedUser)
        {
            var currentUser = _dbContext.users.FirstOrDefault(b => b.Id == updatedUser.Id);
            if (currentUser == null) return null;
            _dbContext.Entry(currentUser).CurrentValues.SetValues(updatedUser);
            _dbContext.Update(currentUser);
            _dbContext.SaveChanges();
            return currentUser;
        }
        
    }


}    
