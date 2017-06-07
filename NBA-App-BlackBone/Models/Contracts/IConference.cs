using NbaBlackBone.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaBlackBone.Models.Contracts
{
    public interface IConference
    {
        string Id { get; set; }

        ConferencesEnum ConferenceEnum { get; set; }

        ILeague League { get; set; }

        ICollection<IDevision> Devisions { get; set; }

        string Url { get; set; }
    }
}
