using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace DataAccessLayer.DataModel
{
    public  class AddNotes
    {
       public string subjectname { get; set; }
        public string shortsubjname { get; set; }
        public string refPrograme { get; set; }
        [DisplayName("UploadFile")]
        public string filepath  { get; set; }
        public HttpPostedFileBase subfile { get; set; }


    }
}
