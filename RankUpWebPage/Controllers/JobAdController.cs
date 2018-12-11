using RankUpWebPage.Data;
using RankUpWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RankUpWebPage.Controllers
{
    public class JobAdController : Controller
    {
        
        JobRepository jobRepository = new JobRepository();
        // GET: JobAd
        public ActionResult Index()
        {
            
            return View();
        }
        //[HttpGet]
        //public ActionResult CreateJob()
        //{
            
        //    return View();
        //}
        //[HttpPost]
        public ActionResult CreateJob(string title, string jobDescription, float salary, double workingHours, DateTime jobDate)
        {
            if (ModelState.IsValid)
            {
                jobRepository.AddJob(title, jobDescription, salary, workingHours, jobDate);
                
            }
            return View();
        }

        // GET: JobAd/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JobAd/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobAd/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: JobAd/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobAd/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: JobAd/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobAd/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
