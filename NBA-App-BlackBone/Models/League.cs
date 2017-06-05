using System;
using System.Collections.Generic;
using NBABlackBone.Models.Enums;

namespace NBABlackBone.Models
{
    public class Leag
    {
        public Leag()
        {

        }
        public string Id { get; set; }

        public Leagues League { get; set; }

        public virtual ICollection<Conf> Conferences { get; set; }

        public string Url { get; set; }
    }
    
    
}
