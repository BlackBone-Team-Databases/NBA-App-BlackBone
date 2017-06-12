using System;
using System.Collections.Generic;
using NbaBlackBone.Models.Enums;
using NbaBlackBone.Models.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NbaBlackBone.Models
{
    public class League : ILeague
    {
        public League()
        {

        }
        [Index("Id")]
        public int Id { get; set; }

        public LeaguesEnum LeagueEnum { get; set; }

        public virtual ICollection<Conference> Conferences { get; set; }

        public string Url { get; set; }
    }
    
    
}
