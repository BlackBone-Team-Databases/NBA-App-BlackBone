using NBABlackBone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.SQLite
{
    class FillSQLite
    {
        public void Fill(ICollection<Standing> standings)
        {
            using (var db = new StandingsDbContext())
            {
                foreach (var item in standings)
                {
                    db.Standings.Add(item);
                }
                db.SaveChanges();
            }
        }
    }
}
