using DataAccessLayer.DataAccess;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
   public class TutorialRepo
    {
        Tutorialaccess tutorialaccess = new Tutorialaccess();
        public Tutorialamodel GetTutorial()
        {
            
                Tutorialamodel tutorialamodels = new Tutorialamodel();
            tutorialamodels = tutorialaccess.gettutorial();
                return tutorialamodels;
           
        }
        public List<topics> tutorialtopics(int id=0)
        {
            List<topics> topics = new List<topics>();
            topics = tutorialaccess.gettopics(id);
            return topics;
        }
        public content GetContent(int id)
        {
            content content = new content();
            content = tutorialaccess.getcontent(id);
            return content;
        }
    }
}
