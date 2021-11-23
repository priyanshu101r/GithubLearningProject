using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataModel
{
    public class Tutorialamodel
    {
        public List<subject> subjects { get; set; }
        public List<topics> topics { get; set; }
        public content content { get; set; }
    }


    public class subject
    {
        public int tsubj_id { get; set; }
        public string subname { get; set; }
    }


    public class topics
    {
        public int topic_id { get; set; }
        public string topicName { get; set; }
        public string topicdesc { get; set; }
        public string tsubj_id { get; set; }

    }
    public class content
    {
        public string topicdesc { get; set; }

    }
}

