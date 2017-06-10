using NBABlackBone.Models.Contracts;
using NBABlackBone.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Models
{
    public class Schedule : ISchedule
    {
        public Date Date { get; set; }

        public ICollection<TeamAttendance> TeamAttendance { get; set; }

        public string Arena { get; set; }
    }
}
