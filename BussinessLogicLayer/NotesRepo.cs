using DataAccessLayer.DataAccess;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
   public class NotesRepo
    {
      
        Notesdataaccess notesdataaccess = new Notesdataaccess();
       
        public int addnotes(AddNotes notes)
        {           
           int affected  = notesdataaccess.addnotes(notes);
            return affected;
        }

        public List<AddNotes> getnotes()
        {
            List <AddNotes> notes= new List<AddNotes>();
            notes = notesdataaccess.getnotes();
            return notes;
        }
    }
}
