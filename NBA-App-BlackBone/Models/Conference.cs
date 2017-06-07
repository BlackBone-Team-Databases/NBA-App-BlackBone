using System;
using System.Collections.Generic;
using NbaBlackBone.Models.Enums;
using NbaBlackBone.Models.Contracts;

namespace NbaBlackBone.Models
{
    public class Conference : IConference
    {
        public Conference()
        {

        }
        public string Id { get; set; }

        public ConferencesEnum ConferenceEnum { get; set; }

        public virtual ILeague League { get; set; }

        public virtual ICollection<IDevision> Devisions { get; set; }

        public string Url { get; set; }
    }
}
