using System;
using System.Collections.Generic;
using NbaBlackBone.Models;
using NbaBlackBone.Models.Enums;
using NbaBlackBone.Models.Contracts;

namespace NbaBlackBone
{

    public class Devision : IDevision
    {
        public Devision()
        {

        }

        public int Id { get; set; }

        public DevisionsEnum DevisionEnum { get; set; }

        public virtual IConference Conference { get; set; }

        public virtual ICollection<ITeam> Teams { get; set; }

        public string Url { get; set; }
    }
}
