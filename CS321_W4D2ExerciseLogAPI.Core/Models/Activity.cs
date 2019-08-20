using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2ExerciseLogAPI.Core.Models
{

    public class Activity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ActivityTypeId { get; set; }
        public DateTime Date { get; set; }
        public int Distance { get; set; }
        public int Duration { get; set; }
        public string Notes { get; set; }

        public ICollection<Activity> activity { get; set; }
    }
}
