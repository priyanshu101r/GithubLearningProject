using BussinessLogicLayer;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartLearningproject.Controllers
{
    public class NotesController : Controller
    {
        // GET: Notes
        NotesRepo repo = new NotesRepo();

        public ActionResult notes()
        {
            //string[] filePaths = Directory.GetFiles(Server.MapPath("~/Files/"));

            //Copy File names to Model collection.
            List<AddNotes> notes = new List<AddNotes>();
            notes = repo.getnotes();
            

            return View(notes);
          
        }

        public ActionResult addNotes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addNotes(AddNotes addNotes)
        {

            string FileName = Path.GetFileNameWithoutExtension(addNotes.subfile.FileName);

            //To Get File Extension  
            string FileExtension = Path.GetExtension(addNotes.subfile.FileName);

            //Add Current Date To Attached File Name  
            FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + FileName.Trim() + FileExtension;

            //Get Upload path from Web.Config file AppSettings.  
            string UploadPath = ConfigurationManager.AppSettings["UserImagePath"].ToString();
            //string UploadPath = C:\Users\Admin\source\Repos\SmartLearningproject\SmartLearningproject\Notes;
            //Its Create complete path to store in server.  
            String fullfilepath = FileName;

            addNotes.filepath =fullfilepath;
            //To copy and save file into server.  
            addNotes.subfile.SaveAs(UploadPath + fullfilepath);
            int affected = repo.addnotes(addNotes);
            if (affected > 0)
            {
                ViewBag.message = "notes uploaded successfully";
                ViewBag.color = "#FF0000";
            }
            else
            if (affected > 0)
            {
                ViewBag.message = "notes not uploadded ";
                ViewBag.color = "#00FF00";
            }
            return View();
        }

        public FileResult DownloadFile(string fileName)
        {
            //Build the File Path.
            string path = Server.MapPath("~/Notes/") + fileName;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.
            return File(bytes, "application/octet-stream", fileName);
        }
    }
}