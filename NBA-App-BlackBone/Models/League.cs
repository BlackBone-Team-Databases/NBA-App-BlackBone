using System;
using System.Collections.Generic;

namespace TeamWorkTEST.Models
{
    public class Leag
    {
        public Leag()
        {

        }
        public string ID { get; set; }

        public string League { get; set; }

        public virtual ICollection<Team> Team { get; set; }

        public string Url { get; set; }
    }
    
    
}
