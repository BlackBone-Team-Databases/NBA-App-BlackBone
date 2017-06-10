using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Models.Contracts
{
    public interface ITeamAttendance
    {
        string Name { get; set; }

        int Score { get; set; }
    }
}
