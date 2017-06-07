using NbaBlackBone.Models;
using NbaBlackBone.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NbaBlackBone.Models.Contracts;
using System.Linq.Expressions;
using NbaBlackBone.Persistance;

namespace NBABlackBone.Persistance.Repositories
{
    class PlayerRepository : Repository<IPlayer>, IPlayerRepository
    {
        public PlayerRepository(NbaContext context) 
            : base(context)
        {

        }

        public IEnumerable<IPlayer> GetTopPlayers(int count)
        {
            //return PlutoContext.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
            return NbaContext.Players.OrderByDescending(p => p.PlayerStatistic.PPG).Take(count).ToList();
        }

        public NbaContext NbaContext
        {
            get { return context as NbaContext; }
        }
    }
}
