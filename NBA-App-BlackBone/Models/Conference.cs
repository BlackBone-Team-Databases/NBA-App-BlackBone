using System;
using System.Collections.Generic;
using NbaBlackBone.Models.Enums;
using NbaBlackBone.Models.Contracts;
using System.ComponentModel.DataAnnotations;

namespace NbaBlackBone.Models
{
    public class Conference : IConference
    {
        public Conference()
        {

        }
        [Required]
        public int Id { get; set; }

        public ConferencesEnum ConferenceEnum { get; set; }

        public virtual League League { get; set; }

        public virtual ICollection<Devision> Devisions { get; set; }

        public string Url { get; set; }
    }
}
