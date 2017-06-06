using NBABlackBone.Models.Contracts;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NBABlackBone.Models
{
    public class PlayerStatistic : IPlayerStatistic
    {
        public PlayerStatistic()
        {

        }

        [ForeignKey("Player")]
        public int Id { get; set; }

        public int PPG { get; set; }

        public int PRG { get; set; }

        public int Blocks { get; set; }

        public virtual IPlayer Player { get; set; }

        public string Url { get; set; }
    }
}
