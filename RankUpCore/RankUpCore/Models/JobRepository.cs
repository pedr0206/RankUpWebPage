using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RankUpCore.Models
{
    public class JobRepository
    {
        List<Job> JobList = new List<Job>();
        Job job;
        private string message = "You have Creatded a Job advertisement";
        object myLock = new object();


        public string AddJob(Job job)
        {
            JobList.Add(new Job(job.Title, job.JobDescription,job.Salary,job.WorkingHours,job.JobDate));
            return message;
        }
        public List<Job> GetAll()
        {
            lock (myLock)
            {
                return JobList.ToList();
            }

        }
    }
}
