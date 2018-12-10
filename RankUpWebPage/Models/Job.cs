using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RankUpWebPage.Models
{
    public class Job
    {
        public string Title { get; set; }
        public string JobDescription { get; set; }
        public float Salary { get; set; }
        public double WorkingHours { get; set; }
        public DateTime JobDate { get; set; }

        List<Skill> skills;
        List<string> attatchments;
        List<User> applicants;
        int[] skillsExp;

        public Job(string title, string jobDescription, float salary, double workingHours, DateTime jobDate, List<Skill> skills, List<string> attatchments, int[] skillsExp)
        {
            Title = title;
            JobDescription = jobDescription;
            Salary = salary;
            WorkingHours = workingHours;
            JobDate = jobDate;
            this.skills = skills;
            this.attatchments = attatchments;
            this.skillsExp = skillsExp;
        }
    }

}