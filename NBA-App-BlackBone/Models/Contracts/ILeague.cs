using NBABlackBone.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Models.Contracts
{
    public interface ILeague
    {
        string Id { get; set; }

        LeaguesEnum LeagueEnum { get; set; }

        ICollection<Conference> Conferences { get; set; }

        string Url { get; set; }
    }
}
