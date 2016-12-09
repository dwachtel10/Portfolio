using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HR_Portal.BLL;
using HR_Portal.Data;
using HR_Portal.Data.Repositories;
using HR_Portal.Models;

namespace HR_Portal.web.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public ActionResult Openings()
        {
            Manager manager = new Manager();
            var model = manager.ListOpenings();
            return View(model.openings);
        }

        [HttpGet]
        public ActionResult AddOpening()
        {

            return View(new Opening());
        }

        [HttpPost]
        public ActionResult AddOpening(Opening opening)
        {
            OpeningTestRepo repo = new OpeningTestRepo();
            
            repo.AddOpening(opening);
            if (ModelState.IsValid)
                return RedirectToAction("Openings");
            else
                return View(opening);

        }

        [HttpGet]
        public ActionResult EditOpening(int JobID)
        {
            OpeningTestRepo repo = new OpeningTestRepo();
            var opening = repo.GetById(JobID);
            return View(opening);
        }

        [HttpPost]
        public ActionResult EditOpening(Opening opening)
        {
            OpeningTestRepo repo = new OpeningTestRepo();
            repo.EditOpening(opening);
            return RedirectToAction("Openings");
        }

        [HttpGet]
        public ActionResult DeleteOpening(int OpeningID)
        {
            
            OpeningTestRepo repo = new OpeningTestRepo();
            var opening = repo.GetById(OpeningID);
            return View(opening);
        }

        [HttpPost]
        public ActionResult DeleteOpening(Opening opening)
        {
            OpeningTestRepo repo = new OpeningTestRepo();
            repo.DeleteOpening(opening);
            return RedirectToAction("Openings");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult OpeningValidation(Opening opening)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return View("Confirmed", opening);
        //    }
        //    else
        //    {
                
        //            return View(opening);
                
        //    }
        //}
        
    }

}