using System;
using System.Collections.Generic;
using NBABlackBone.Models.Enums;

namespace NBABlackBone.Models
{
    public class League
    {
        public League()
        {

        }
        public string Id { get; set; }

        public LeaguesEnum LeagueEnum { get; set; }

        public virtual ICollection<Conference> Conferences { get; set; }

        public string Url { get; set; }
    }
    
    
}
