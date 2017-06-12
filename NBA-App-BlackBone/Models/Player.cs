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

        [Index("Id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [NotMapped]
        public string FirstLastName => $"{this.FirstName} {this.LastName}";

        public float Position { get; set; }

        public virtual PlayerStatistic PlayerStatistic { get; set; }

        public virtual Team Team { get; set; }

        public string Url { get; set; }

        public override string ToString()
        {
            return string.Format($"Name: {FirstLastName}\nTeam: {Team}\nPosition: {Position}\n");
        }
    }
}
