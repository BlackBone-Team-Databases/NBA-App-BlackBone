using NbaBlackBone;
using NbaBlackBone.Core.Contracts;
using NbaBlackBone.Models;
using NbaBlackBone.Persistance;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Core.Commands
{
    public class CommandFactory : ICommandFactory
    {
        private IReader reader;
        private IWriter writer;
        private UnitOfWork unitOfWork;

        public CommandFactory(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void CreatePlayerCommand()
        {
            using (var unitOfWork = new UnitOfWork(new NbaContext()))
            {
                this.unitOfWork = unitOfWork;
                var player = new Player() {Id= 1, FirstName = "PEtar", LastName = "Ushev", Position = 3 };
                //this.unitOfWork.Players.Add(player);
                unitOfWork.Players.Add(player);
                unitOfWork.Complete();
            }
        }

        public void CreateTeamCommand()
        {
            Console.WriteLine("team");
        }

    }
}
