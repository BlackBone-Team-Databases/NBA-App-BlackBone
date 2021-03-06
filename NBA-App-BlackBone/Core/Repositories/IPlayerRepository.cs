﻿using NbaBlackBone.Models;
using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaBlackBone.Repositories
{
    public interface IPlayerRepository : IRepository<Player>
    {
        IEnumerable<Player> GetTopPlayers(int count);
    }
}
