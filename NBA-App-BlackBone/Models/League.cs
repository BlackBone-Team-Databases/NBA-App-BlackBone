using System;
using System.Collections.Generic;
using TeamWorkTEST.Models.Enums;

namespace TeamWorkTEST.Models
{
    public class Leag
    {
        public Leag()
        {

        }
        public string Id { get; set; }

        public Leagues League { get; set; }

        public virtual ICollection<Confer> Conferences { get; set; }

        public string Url { get; set; }
    }
    
    
}
