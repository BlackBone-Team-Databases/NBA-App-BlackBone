using System;
using System.Collections.Generic;

namespace TeamWorkTEST.Models
{
    public class Team
    {
        public Team()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string OffRtg { get; set; }

        public string DeffRtg { get; set; }

        public virtual Div Devision { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public string Url { get; set; }

	}
}
