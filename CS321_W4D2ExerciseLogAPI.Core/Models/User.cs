using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2ExerciseLogAPI.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> user { get; set; }
    }
}
