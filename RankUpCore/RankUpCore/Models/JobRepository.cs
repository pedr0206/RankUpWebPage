using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RankUpCore.Models
{
    public class JobRepository
    {
        private static JobRepository instance = null;
        static List<Job> JobList = new List<Job>();
        private static readonly object ourLock = new object();

        JobRepository()
        {
        }

        public static JobRepository Instance
        {
            get
            {
                lock (ourLock)
                {
                    if (instance == null)
                    {
                        Populate();
                        instance = new JobRepository();
                        
                    }
                    return instance;
                }
            }
        }
        public void AddJob(Job job1)
        {

            Job job = new Job() { Title = job1.Title, JobDescription = job1.JobDescription, Salary = job1.Salary, WorkingHours = job1.WorkingHours, JobDate = job1.JobDate };

            lock (ourLock)
            {
                JobList.Add(job);
            }
        }
        public List<Job> GetAll()
        {
            lock (ourLock)
            {
                return JobList.ToList();
            }

        }
        static void Populate()
        {

            Job job1 = new Job() { Title = "CleaningJob", JobDescription = "Cleaning job very simple just clean the place", Salary = 30000000, WorkingHours = 3, JobDate = DateTime.Now };
            Job job2 = new Job() { Title = "Kidnap", JobDescription = "Very simple Kidnap the target", Salary = 30000000, WorkingHours = 10, JobDate = DateTime.Now };
            Job job3 = new Job() { Title = "Plumber", JobDescription = "Fix Stuff", Salary = 3000, WorkingHours = 30, JobDate = DateTime.Now };
            Job job4 = new Job() { Title = "HotDog Stand", JobDescription = "Be polite and seel a ton of hotdogs", Salary = 99999999999, WorkingHours = 60, JobDate = DateTime.Now };

            JobList.Add(job1);
            JobList.Add(job2);
            JobList.Add(job3);
            JobList.Add(job4);

        }


    }
}
