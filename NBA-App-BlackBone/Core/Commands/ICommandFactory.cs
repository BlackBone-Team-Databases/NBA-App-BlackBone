using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Core.Commands
{
    public interface ICommandFactory
    {
        void CreatePlayerCommand();

        void CreateTeamCommand();
    }
}
