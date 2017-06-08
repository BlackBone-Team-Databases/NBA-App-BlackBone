using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaBlackBone.Models.Contracts
{
    public interface ITeam
    {
        int Id { get; set; }

        string Name { get; set; }

        float Minutes { get; set; }

        float OffRtg { get; set; }

        float DeffRtg { get; set; }

        float OverallRtg { get; set; }

        Devision Devision { get; set; }

        ICollection<Player> Players { get; set; }

        string Url { get; set; }
    }
}
