using System;
using System.Collections.Generic;
using NBABlackBone.Models.Enums;

namespace NBABlackBone.Models
{
    public class Conf
    {
        public Conf()
        {

        }
        public string Id { get; set; }

        public Conferences Conference { get; set; }

        public virtual Leag League { get; set; }

        public virtual ICollection<Div> Devisions { get; set; }

        public string Url { get; set; }
    }
}
