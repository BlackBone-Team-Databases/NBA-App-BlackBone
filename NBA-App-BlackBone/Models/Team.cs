﻿using NbaBlackBone.Models.Contracts;
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
        
        public float Minutes { get; set; }
        
        public float OffRtg { get; set; }

        public float DeffRtg { get; set; }

        public float OverallRtg { get; set; }

        public virtual IDevision Devision { get; set; }

        public virtual ICollection<IPlayer> Players { get; set; }

        public string Url { get; set; }

        public override string ToString()
        {
            return string.Format($"Name: {Name}\nOffRtng: {OffRtg}\nDeffRtg: {DeffRtg}\nOverallRtg: {OverallRtg}\n");
        }
    }
}
