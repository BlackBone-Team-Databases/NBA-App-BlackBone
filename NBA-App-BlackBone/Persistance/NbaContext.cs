using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NbaBlackBone.Models;
using NbaBlackBone.Models.Enums;
using NbaBlackBone.Models.Contracts;

namespace NbaBlackBone.Persistance
{
    public class NbaContext : DbContext
    {
        public NbaContext()
            : base("name = NbaContext")
        {

        }
        public IDbSet<IPlayer> Players { get; set; }

        public IDbSet<ITeam> Teams { get; set; }

        public IDbSet<IPlayerStatistic> PlayerStatistics { get; set; }
    }
}
