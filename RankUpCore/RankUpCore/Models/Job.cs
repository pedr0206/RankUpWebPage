using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RankUpCore.Models
{
    public class Job
    {
        [Required]//data annotation 
        public string Title { get; set; }
        [Required]
        public string JobDescription { get; set; }
        [Required]
        public float Salary { get; set; }
        [Required]
        public double WorkingHours { get; set; }
        [Required]
        public DateTime JobDate { get; set; }


        
        //List<string> attatchments;
        //List<User> applicants;
        //List<Skill> skills;
        //int[] skillsExp;



    }
}
