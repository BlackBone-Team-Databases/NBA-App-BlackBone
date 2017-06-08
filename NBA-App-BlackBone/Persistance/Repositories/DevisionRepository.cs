using NbaBlackBone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NbaBlackBone.Repositories;
using NbaBlackBone.Persistance;

namespace NBABlackBone.Persistance.Repositories
{
    public class DevisionRepository : Repository<Devision>, IDevisionRepository
    {
        public DevisionRepository(NbaContext context) : base(context)
        {
        }

        public IEnumerable<Devision> GetTopTeamsByDevision(int count)
        {
            throw new NotImplementedException();
        }
    }
}
