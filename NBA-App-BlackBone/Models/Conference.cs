using System;
using System.Collections.Generic;
using NbaBlackBone.Models.Enums;
using NbaBlackBone.Models.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NbaBlackBone.Models
{
    public class Conference : IConference
    {
        public Conference()
        {

        }

        [Index("Id")]
        public int Id { get; set; }

        public ConferencesEnum ConferenceEnum { get; set; }

        public virtual League League { get; set; }

        public virtual ICollection<Devision> Devisions { get; set; }

        public string Url { get; set; }
    }
}
