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
   public  class Quizdataaccess
    {

        public Quizdataaccess()
        {
            
        }
        public List<Quizcmodel> getquiz()
        {
            List<Quizcmodel> quizcmodels = new List<Quizcmodel>(); 
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["smartlearning"].ConnectionString))
            {
                quizcmodels = db.Query<Quizcmodel>("select * from tbl_Quz quiz inner join tbl_Quizquestion question on quiz.quizid = question.quizid").ToList();
            }
            return quizcmodels;
        }

    }
}
