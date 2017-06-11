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

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("score")]
        public int Score { get; set; }

        [Column("HOR")]
        public HomeOrAway HomeOrAway { get; set; }
    }
}
