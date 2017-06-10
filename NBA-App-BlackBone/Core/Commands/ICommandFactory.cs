using NbaBlackBone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Core.Commands
{
    public interface ICommandFactory
    {
        string CreatePlayerCommand();

        string CreateTeamCommand();

        void ReadAllPlayersCommand();

        void ReadPlayerByIDCommand();

        void ReadAllTeamsCommand();

        void ReadTeamByIDCommand();

        void ReadPlayerStatisticByIDCommand();

        void DeletePlayerCommand();

        void DeleteTeamCommand();

        void UpdatePlayerCommand();

        void UpdateTeamCommand();

        void UpdatePlayerStatisticCommand();
    }
}
