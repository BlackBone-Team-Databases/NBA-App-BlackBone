using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Models.Contracts
{
    public interface IPlayer
    {
        int Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string PlayerTrueName { get; set; }

        string Position { get; set; }

        IPlayerStatistic PlayerStatistic { get; set; }

        ITeam Team { get; set; }

        string Url { get; set; }
    }
}
