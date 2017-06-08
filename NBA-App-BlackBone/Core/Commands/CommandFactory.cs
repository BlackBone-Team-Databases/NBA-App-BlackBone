using NbaBlackBone.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Core.Commands
{
    public class CommandFactory : ICommandFactory
    {
        private IReader reader;
        private IWriter writer;

        public CommandFactory(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void CreatePlayerCommand()
        {
            Console.WriteLine("player");
        }

        public void CreateTeamCommand()
        {
            Console.WriteLine("team");
        }

    }
}
