using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamWorkTEST.Models
{
    public class PlayerStatistic
    {
        public PlayerStatistic()
        {

        }

        [ForeignKey("Player")]
        public int Id { get; set; }

        public int PPG { get; set; }

        public int PRG { get; set; }

        public int Blocks { get; set; }

        public virtual Player Player { get; set; }

        public string Url { get; set; }
    }
}
