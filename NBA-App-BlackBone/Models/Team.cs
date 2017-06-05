using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NBABlackBone.Models
{
    public class Team
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

        public virtual Devision Devision { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public string Url { get; set; }

	}
}
