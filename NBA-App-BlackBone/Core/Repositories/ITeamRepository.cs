using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaBlackBone.Repositories
{
    public interface ITeamRepository : IRepository<ITeam>
    {
        IEnumerable<ITeam> GetTopTeams(int count);
    }
}
