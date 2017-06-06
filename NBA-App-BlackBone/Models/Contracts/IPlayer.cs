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

        PlayerStatistic PlayerStatistic { get; set; }

        Team Team { get; set; }

        string Url { get; set; }
    }
}
