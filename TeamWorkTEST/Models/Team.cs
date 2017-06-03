using System;
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

        public virtual Leag League { get; set; }

        public virtual Confer Conference { get; set; }

        public string Url { get; set; }

	}
}
