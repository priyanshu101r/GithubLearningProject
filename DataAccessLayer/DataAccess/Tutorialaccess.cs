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
   public class Tutorialaccess
    {
        public Tutorialamodel gettutorial()
        {
            Tutorialamodel tutorialamodels = new Tutorialamodel();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["smartlearning"].ConnectionString))
            {
                List<subject> subjects = new List<subject>();
                subjects = db.Query<subject>("select * from tbl_tutorialsubject").ToList();
                List<topics> topics = new List<topics>();
                topics = db.Query<topics>("select * from tbl_topics1 where tsubj_id = 1").ToList();

                tutorialamodels.subjects = subjects;
                tutorialamodels.topics = topics;

            }


            return tutorialamodels;
        }

        public List<topics> gettopics(int id)
        {
            List<topics> topics = new List<topics>();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["smartlearning"].ConnectionString))
            {
                 topics = db.Query<topics>("select * from tbl_topics1 where tsubj_id = "+id+"").ToList();

            }
            return topics;
        }
        public content getcontent(int id)
        {
            content content = new content();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["smartlearning"].ConnectionString))
            {
                content = db.Query<content>("select topicdesc from tbl_topics1 where topic_id = "+id+"").FirstOrDefault();

            }
            return content;
        }

    }

}

