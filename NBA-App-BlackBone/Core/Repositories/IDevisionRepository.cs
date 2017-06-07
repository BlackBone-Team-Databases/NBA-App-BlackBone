using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaBlackBone.Repositories
{
    public interface IDevisionRepository : IRepository<IDevision>
    {
        IEnumerable<IDevision> GetTopTeamsByDevision(int count);
    }
}
