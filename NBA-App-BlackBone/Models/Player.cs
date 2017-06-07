using NbaBlackBone.Models.Contracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NbaBlackBone.Models
{
    public class Player : IPlayer
    {
        public Player()
        {
            
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [NotMapped]
        public string FirstLastName => $"{this.FirstName} {this.LastName}";

        public string PlayerTrueName { get; set; }

        public string Position { get; set; }

        public virtual IPlayerStatistic PlayerStatistic { get; set; }

        public virtual ITeam Team { get; set; }

        public string Url { get; set; }
    }
}
