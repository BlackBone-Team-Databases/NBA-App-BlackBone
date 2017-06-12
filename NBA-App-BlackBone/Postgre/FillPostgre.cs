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

                db.SaveChanges();
            }
        }
}
}
