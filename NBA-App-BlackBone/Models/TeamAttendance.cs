using NBABlackBone.Models.Contracts;
using NBABlackBone.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Index("Id")]
        public int Id { get; set; }

        [Column("Team Name")]
        public string Name { get; set; }

        [Column("Score")]
        public int Score { get; set; }

        [Column("Home or Away")]
        public HomeOrAway HomeOrAway { get; set; }
    }
}
