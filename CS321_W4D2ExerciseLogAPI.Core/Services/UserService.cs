using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2ExerciseLogAPI.Core.Models;


namespace CS321_W4D2ExerciseLogAPI.Core.Services
{
    public class UserService : IUserRepository
    {
        private readonly UserRepository _userRepo;

        public UserService(UserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public User Add(User newUser)
        {
            _userRepo.users.Add(newUser);
            _userRepo.SaveChanges();
            return newUser;
        }

        public User Get(int id)
        {
            return _userRepo.users.FirstOrDefault(a => a.id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepo.users
                .Include(a => a.users)
                .ToList();
        }

        public void Remove(User user)
        {
            var currentUser = _userRepo.users.Find(user.Id);
            if (currentUser != null)
                _userRepo.users.Remove(user);
            _userRepo.SaveChanges();
        }

        public User Update(User updatedUser)
        {
            var currentUser = _userRepo.users.FirstOrDefault(b => b.Id == updatedUser.Id);
            if (currentUser == null) return null;
            _userRepo.Entry(currentUser).CurrentValues.SetValues(updatedUser);
            _userRepo.Update(currentUser);
            _userRepo.SaveChanges();
            return currentUser;
        }
    }

   
}
