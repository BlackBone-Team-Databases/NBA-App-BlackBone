using System;
using System.Collections.Generic;

namespace TeamWorkTEST.Models
{
    public class Confer
    {
        public Confer()
        {

        }
        public string ID { get; set; }

        public string Conference { get; set; }

        public virtual ICollection<Team> Team { get; set; }

        public string Url { get; set; }
    }
}
