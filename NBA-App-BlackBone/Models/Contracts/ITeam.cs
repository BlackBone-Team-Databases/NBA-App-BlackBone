using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Models.Contracts
{
    public interface ITeam
    {
        int Id { get; set; }

        string Name { get; set; }

        int Minutes { get; set; }

        string OffRtg { get; set; }

        string DeffRtg { get; set; }

        int OverallRtg { get; set; }

        IDevision Devision { get; set; }

        ICollection<IPlayer> Players { get; set; }

        string Url { get; set; }
    }
}
