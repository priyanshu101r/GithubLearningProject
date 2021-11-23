using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DataAccess;
namespace BussinessLogicLayer
{
    public class QuizRepo
    {
      

        Quizdataaccess quizdataaccess = new Quizdataaccess();
        public List<Quizcmodel> Quiztest()
        {
            List<Quizcmodel> quizcmodels = new List<Quizcmodel>();
            quizcmodels = quizdataaccess.getquiz();
            return quizcmodels;
        }
        
    }

}
