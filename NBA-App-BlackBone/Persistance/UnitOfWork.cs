using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NbaBlackBone.Repositories;

namespace NbaBlackBone.Persistance
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly NbaContext context;

        public UnitOfWork(NbaContext context)
        {
            this.context = context;
        }

        public IDevisionRepository Devisions { get; private set; }

        public IPlayerRepository Players { get; private set; }

        public ITeamRepository Teams { get; private set; }

        public int Complete()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
