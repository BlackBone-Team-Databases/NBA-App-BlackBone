using NbaBlackBone.Models;
using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaBlackBone.Repositories
{
    public interface ITeamRepository : IRepository<Team>
    {
        IEnumerable<Team> GetTopTeams(int count);
    }
}
