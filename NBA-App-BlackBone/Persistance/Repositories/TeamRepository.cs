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
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(NbaContext context) 
            : base(context)
        {

        }

        public IEnumerable<Team> GetTopTeams(int count)
        {
            throw new NotImplementedException();
        }

        public NbaContext NbaContext
        {
            get { return context as NbaContext; }
        }
    }
}
