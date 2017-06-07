using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NbaBlackBone.Models
{
    public class Team : ITeam
    {
        public Team()
        {

        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        public int Minutes { get; set; }
        
        public string OffRtg { get; set; }

        public string DeffRtg { get; set; }

        public int OverallRtg { get; set; }

        public virtual IDevision Devision { get; set; }

        public virtual ICollection<IPlayer> Players { get; set; }

        public string Url { get; set; }

	}
}
