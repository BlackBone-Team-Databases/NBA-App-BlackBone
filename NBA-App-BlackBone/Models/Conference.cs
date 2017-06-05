using System;
using System.Collections.Generic;
using NBABlackBone.Models.Enums;

namespace NBABlackBone.Models
{
    public class Conference
    {
        public Conference()
        {

        }
        public string Id { get; set; }

        public ConferencesEnum ConferenceEnum { get; set; }

        public virtual League League { get; set; }

        public virtual ICollection<Devision> Devisions { get; set; }

        public string Url { get; set; }
    }
}
