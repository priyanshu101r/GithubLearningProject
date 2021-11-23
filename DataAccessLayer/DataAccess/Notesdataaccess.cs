using Dapper;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccess
{
    public class Notesdataaccess
    {
        public int addnotes( AddNotes notes)
        {
            int affectedrow = 0;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["smartlearning"].ConnectionString))
            {
                affectedrow = db.Execute("Insert into tbl_notes (subjectname, shortsubjname,refPrograme,filepath) values (@subjectname, @shortsubjname,@refPrograme,@filepath)", new { subjectname= notes.subjectname, shortsubjname = notes.shortsubjname, refPrograme= notes.refPrograme, filepath = notes.filepath});
            }

            return affectedrow;
        }

        public List<AddNotes> getnotes()
        {
            List<AddNotes> notes = new List<AddNotes>();

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["smartlearning"].ConnectionString))
            {
                notes = db.Query<AddNotes>("select * from tbl_notes").ToList();
            }

            return notes;
        }
    }
}
