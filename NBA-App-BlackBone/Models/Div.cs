using System;
using System.Collections.Generic;
using NBABlackBone.Models;
using NBABlackBone.Models.Enums;

namespace NBABlackBone
{

    public class Div
    {
        public Div()
        {

        }

        public int Id { get; set; }

        public Devisions Devision { get; set; }

        public virtual Conf Conference { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public string Url { get; set; }
    }
}
