using System;
using System.Collections.Generic;
using System.Text;


namespace CS321_W4D2ExerciseLogAPI.Core.Services
{

    private IUserRepository _userRepo;

    public UserService(IUserRepository userRepo)
    {
        _userRepo = userRepo;
    }
    class UserService
    {
    }
}
