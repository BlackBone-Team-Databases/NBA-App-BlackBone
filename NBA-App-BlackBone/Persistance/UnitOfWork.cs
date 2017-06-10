using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NbaBlackBone.Repositories;
using NBABlackBone.Core.Repositories;
using NBABlackBone.Persistance.Repositories;

namespace NbaBlackBone.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NbaContext context;

        public UnitOfWork(NbaContext context)
        {
            this.context = context;
            this.Players = new PlayerRepository(context);
            this.Teams = new TeamRepository(context);
            this.PlayerStatistic = new PlayerStatisticRepository(context);
            this.Devisions = new DevisionRepository(context);
            
        }

        public IDevisionRepository Devisions { get; private set; }

        public IPlayerRepository Players { get; private set; }

        public ITeamRepository Teams { get; private set; }

        public ILeagueRepository League { get; private set; }

        public IPlayerStatisticRepository PlayerStatistic { get; private set; }

        public object Update(object entry)
        {
            return context.Entry(entry).State= System.Data.Entity.EntityState.Modified;
        }

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
