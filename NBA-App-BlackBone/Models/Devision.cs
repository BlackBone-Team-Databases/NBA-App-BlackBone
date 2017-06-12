using System;
using System.Collections.Generic;
using NbaBlackBone.Models;
using NbaBlackBone.Models.Enums;
using NbaBlackBone.Models.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace NbaBlackBone
{

    public class Devision : IDevision
    {
        public Devision()
        {

        }

        [Index("Id")]
        public int Id { get; set; }

        public DevisionsEnum DevisionEnum { get; set; }

        public virtual Conference Conference { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public string Url { get; set; }
    }
}
