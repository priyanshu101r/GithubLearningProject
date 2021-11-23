using BussinessLogicLayer;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartLearningproject.Controllers
{
    public class TutorialController : Controller
    {
        // GET: Tutorial
        TutorialRepo repo = new TutorialRepo();
        public ActionResult tutorial(int id=0)
        {
            Tutorialamodel tutorialamodels = new Tutorialamodel();
            tutorialamodels = repo.GetTutorial();
            ViewBag.content = "<p>Hello student</p>";
            return View(tutorialamodels);
        }
        public ActionResult tutorialtopic(int id)
        {
            List<topics> topics = new List<topics>();
            topics = repo.tutorialtopics(id);
            Tutorialamodel tutorialamodel = new Tutorialamodel();
            tutorialamodel.topics = topics;
            return PartialView("_tutorialsidebar", tutorialamodel);
        }
       

        public ActionResult content(int id)
        {
            content content = new content();
            content = repo.GetContent(id);
            Tutorialamodel tutorialamodel = new Tutorialamodel();
            tutorialamodel.content = content;
            //ViewBag.content = "<p>Hello student</p>";
            return PartialView("_contentpartial", tutorialamodel);
        }

    }
}