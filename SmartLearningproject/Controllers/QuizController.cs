using BussinessLogicLayer;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartLearningproject.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        QuizRepo quizRepo = new QuizRepo();
        public ActionResult Quiztest()
        {
            return View();
        }
        [HttpGet]
        public JsonResult EmpDetails()
        {
            //Creating List    
            List<Quizcmodel> quizmodel = new List<Quizcmodel>();
            quizmodel = quizRepo.Quiztest();
            //return list as Json    
            return Json(quizmodel, JsonRequestBehavior.AllowGet);
        }
    }
}