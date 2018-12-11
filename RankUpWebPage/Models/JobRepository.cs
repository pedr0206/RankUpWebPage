using RankUpWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RankUpWebPage.Data
{
    public class JobRepository
    {
        List<Job> JobList = new List<Job>();
        Job job;
        private string message = "You have Creatded a Job advertisement";

        public string AddJob(string title, string jobDescription, float salary, double workingHours, DateTime jobDate)
        {
            JobList.Add(new Job(title, jobDescription, salary, workingHours, jobDate));
            return message;
        }
    }
}