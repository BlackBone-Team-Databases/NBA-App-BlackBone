using NBABlackBone.MigrationsSQLite;
using NBABlackBone.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.SQLite
{
    class StandingsDbContext : DbContext
    {
        public StandingsDbContext() : base("SqliteDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StandingsDbContext, ConfigurationAwesome>(true));
        }

        public IDbSet<Standing> Standings { get; set; }
    }
}
