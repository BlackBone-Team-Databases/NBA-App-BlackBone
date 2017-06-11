using NbaBlackBone.Models;
using NBABlackBone.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NbaBlackBone.Persistance;

namespace NBABlackBone.Persistance.Repositories
{
    public class LeagueRepository : Repository<League>, ILeagueRepository
    {
        public LeagueRepository(NbaContext context) : base(context)
        {
        }

        public NbaContext NbaContext
        {
            get { return context as NbaContext; }
        }
    }
}
