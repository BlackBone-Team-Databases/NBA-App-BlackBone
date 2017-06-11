using NbaBlackBone.Repositories;
using NBABlackBone.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaBlackBone
{
    public interface IUnitOfWork : IDisposable
    {
        ITeamRepository Teams { get; }

        IPlayerRepository Players { get; }

        IDevisionRepository Devisions { get; }

        IConferenceRepository Conference { get;  }

        int Complete();
    }
}
