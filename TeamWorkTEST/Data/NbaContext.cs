using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamWorkTEST.Models;

namespace TeamWorkTEST
{
    public class NbaContext : DbContext
    {
        public NbaContext():base("name = NbaContext")
        {

        }
        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }
    }
}
