using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBABlackBone.Models;
using NBABlackBone.Models.Enums;

namespace NBABlackBone
{
    public class NbaContext : DbContext
    {
        public NbaContext():base("name = NbaContext")
        {

        }
        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Conf> Conferences { get; set; }
    }
}
