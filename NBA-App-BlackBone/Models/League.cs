﻿using System;
using System.Collections.Generic;
using NBABlackBone.Models.Enums;
using NBABlackBone.Models.Contracts;

namespace NBABlackBone.Models
{
    public class League : ILeague
    {
        public League()
        {

        }
        public string Id { get; set; }

        public LeaguesEnum LeagueEnum { get; set; }

        public virtual ICollection<IConference> Conferences { get; set; }

        public string Url { get; set; }
    }
    
    
}
