using NBABlackBone.Models;
using NBABlackBone.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Postgre
{
    public class FillPostgre
    {
        public void Fill(ICollection<Schedule> schedules)
        {

            using (var db = new PostgreContext())
            {

                foreach (var item in schedules)
                {
                    db.Scedules.Add(item);
                }

                //var sched = new Schedule();
                //sched.Arena = "Orcle";

                //sched.Date = new Date();
                //sched.Date.Day = 4;
                //sched.Date.Month = 6;
                //sched.Date.Year = 2017;

                //var teamAttend = new TeamAttendance();
                //teamAttend.Name = "Cleveland";
                //teamAttend.HomeOrAway = HomeOrAway.Away;
                //teamAttend.Score = 144;
                //sched.TeamAttendance.Add(teamAttend);

                //db.Scedules.Add(sched);


                db.SaveChanges();
            }
        }
}
}
