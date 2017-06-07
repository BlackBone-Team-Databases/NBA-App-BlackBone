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
        public TeamRepository(NbaContext context) : base(context)
        {

        }

        public void Add(ITeam entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<ITeam> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITeam> Find(Expression<Func<ITeam, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITeam> GetTopTeams(int count)
        {
            throw new NotImplementedException();
        }

        public void Remove(ITeam entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ITeam> entities)
        {
            throw new NotImplementedException();
        }

        public ITeam SingleOrDefault(Expression<Func<ITeam, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        ITeam IRepository<ITeam>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ITeam> IRepository<ITeam>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
