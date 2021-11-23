using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataModel
{
    public class Quizcmodel
    {
        public int quizid { get; set; }
        public string quizname { get; set; }
        public int questionid { get; set; }
        public string questiontype { get; set; }
        public string questiondes { get; set; }
        public string choice1 { get; set; }
        public string choice2 { get; set; }
        public string choice3 { get; set; }
        public string choice4 { get; set; }
        public string correctans { get; set; }
           
    }
}