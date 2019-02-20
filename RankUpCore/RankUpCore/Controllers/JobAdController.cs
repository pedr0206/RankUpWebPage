using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RankUpCore.Models;

namespace RankUpCore.Controllers
{
    public class JobAdController : Controller
    {
        JobRepository jobRepository = JobRepository.Instance;
        
        [HttpGet]
        public ActionResult Index()
        {
            Job job = new Job();
            return View(job);
        }

        [HttpPost]
        public ActionResult Index([FromForm]Job job)
        {
            if (ModelState.IsValid)
            {
                
                jobRepository.AddJob(job);

            }
            return RedirectToAction("AllJobs");
        }
        [HttpGet]
        public ActionResult AllJobs()
        {
            return View(jobRepository.GetAll());
        }
    }
}