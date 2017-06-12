using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NbaBlackBone.Models
{
    public class Team : ITeam
    {
        public Team()
        {

        }

        [Index("Id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        public float Minutes { get; set; }
        
        public float OffRtg { get; set; }

        public float DeffRtg { get; set; }

        public float OverallRtg { get; set; }

        public virtual Devision Devision { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public string Url { get; set; }

        public override string ToString()
        {
            return string.Format($"Name: {Name}\nOffRtng: {OffRtg}\nDeffRtg: {DeffRtg}\nOverallRtg: {OverallRtg}\n");
        }
    }
}
