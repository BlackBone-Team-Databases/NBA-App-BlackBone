using System;
using System.Collections.Generic;
using NbaBlackBone.Models.Enums;
using NbaBlackBone.Models.Contracts;

namespace NbaBlackBone.Models
{
    public class League : ILeague
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
