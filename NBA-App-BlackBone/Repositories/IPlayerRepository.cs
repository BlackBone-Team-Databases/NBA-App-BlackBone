using NBABlackBone.Models;
using NBABlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Persistence
{
    public interface IPlayerRepository : IRepository<IPlayer>
    {
        IEnumerable<IPlayer> GetTopPlayers(int count);
    }
}
