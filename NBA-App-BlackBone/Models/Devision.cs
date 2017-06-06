using System;
using System.Collections.Generic;
using NBABlackBone.Models;
using NBABlackBone.Models.Enums;
using NBABlackBone.Models.Contracts;

namespace NBABlackBone
{

    public class Devision : IDevision
    {
        public Devision()
        {

        }

        public int Id { get; set; }

        public DevisionsEnum DevisionEnum { get; set; }

        public virtual Conference Conference { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public string Url { get; set; }
    }
}
