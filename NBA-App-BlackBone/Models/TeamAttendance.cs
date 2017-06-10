using NBABlackBone.Models.Contracts;
using NBABlackBone.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Models
{
    public class TeamAttendance : ITeamAttendance
    {
        public TeamAttendance()
        {

        }

        public string Name { get; set; }

        public int Score { get; set; }

        public HomeOrAway HomeOrAway { get; set; }
    }
}
