using NbaBlackBone.Models;
using NbaBlackBone.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Core.Repositories
{
    public interface IConferenceRepository : IRepository<Conference>
    {
        IEnumerable<Conference> GetTopTeamByConference(int count);
    }
}
