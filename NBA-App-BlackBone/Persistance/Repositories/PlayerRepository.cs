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
    class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(NbaContext context) 
            : base(context)
        {

        }

        public IEnumerable<Player> GetTopPlayers(int count)
        {
            throw new NotImplementedException();
        }
    }
}
