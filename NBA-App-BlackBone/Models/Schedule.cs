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
    [Table("Schedules", Schema = "public")]
    public class Schedule : ISchedule
    {
        public Schedule()
        {
            this.TeamAttendance = new HashSet<TeamAttendance>();
        }

        [Index("Id")]
        public int Id { get; set; }

        [Column("Date")]
        public Date Date { get; set; }

        
        [Column("Attendance")]
        public virtual ICollection<TeamAttendance> TeamAttendance { get; set; }

        [Column("Arena")]
        public string Arena { get; set; }
    }
}
