using System;
using System.Collections.Generic;
using NBABlackBone.Models.Enums;
using NBABlackBone.Models.Contracts;

namespace NBABlackBone.Models
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
