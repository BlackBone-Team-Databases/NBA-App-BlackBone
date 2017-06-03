using System;
namespace TeamWorkTEST.Models
{
    public class Player
    {
        public Player()
        {
            
        }

        public int Id { get; set; }

        public string PlayerName { get; set; }

        public string PlayerTrueName { get; set; }

        public string Position { get; set; }

        public virtual PlayerStatistic PlayerStatistic { get; set; }

        public virtual Team Team { get; set; }

        public string Url { get; set; }
    }
}
