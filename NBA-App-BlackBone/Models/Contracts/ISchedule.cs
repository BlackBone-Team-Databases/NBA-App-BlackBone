using NBABlackBone.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Models.Contracts
{
    public interface ISchedule
    {
        Date Date { get; set; }

        ICollection<TeamAttendance> TeamAttendance { get; set; }

        string Arena { get; set; }
    }
}
