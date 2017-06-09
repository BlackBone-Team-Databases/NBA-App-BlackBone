using NbaBlackBone;
using NbaBlackBone.Core.Contracts;
using NbaBlackBone.Models;
using NbaBlackBone.Models.Enums;
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

        public string CreatePlayerCommand()
        {
            using (var unitOfWork = new UnitOfWork(new NbaContext()))
            {
                this.unitOfWork = unitOfWork;
                var player = new Player();
                var playerStatistic = new PlayerStatistic();

                this.writer.WriteLine("Insert player First Name:");
                player.FirstName = this.reader.ReadLine();
                this.writer.WriteLine("Insert player Last Name:");
                player.LastName = this.reader.ReadLine();
                this.writer.WriteLine("Insert player Position:");
                float position;
                bool result = float.TryParse(this.reader.ReadLine(), out position);
                if (!result)
                {
                    return "incorect value";
                }
                player.Position = position;

                unitOfWork.Players.Add(player);
                unitOfWork.PlayerStatistic.Add(playerStatistic);
                unitOfWork.Complete();
                return "success";
            }
        }

        public string CreateTeamCommand()
        {
            using (var unitOfWork = new UnitOfWork(new NbaContext()))
            {
                this.unitOfWork = unitOfWork;
                var team = new Team();
                

                this.writer.WriteLine("Insert team Name:");
                team.Name = this.reader.ReadLine();
                
                unitOfWork.Teams.Add(team);
                unitOfWork.Complete();
                return "success";
            }
        }

        public void ReadAllPlayersCommand()
        {
            using (var unitOfWork = new UnitOfWork(new NbaContext()))
            {
                this.unitOfWork = unitOfWork;

                var players = unitOfWork.Players.GetAll();

                foreach (var player in players)
                {
                    this.writer.WriteLine(player.ToString());
                }
            }
        }

        public void ReadPlayerByIDCommand()
        {
            using (var unitOfWork = new UnitOfWork(new NbaContext()))
            {
                this.unitOfWork = unitOfWork;

                this.writer.WriteLine("inseart Id:");

                int id;
                bool result = int.TryParse(this.reader.ReadLine(), out id);
                if (!result)
                {
                    this.writer.WriteLine("invalid value");
                }
                else
                {
                    var player = unitOfWork.Players.Get(id);

                    this.writer.WriteLine(player.ToString());
                }
                
            }
        }

        public void ReadAllTeamsCommand()
        {
            using (var unitOfWork = new UnitOfWork(new NbaContext()))
            {
                this.unitOfWork = unitOfWork;

                var teams = unitOfWork.Teams.GetAll();

                foreach (var team in teams)
                {
                    this.writer.WriteLine(team.ToString());
                }
            }
        }

        public void ReadTeamByIDCommand()
        {
            using (var unitOfWork = new UnitOfWork(new NbaContext()))
            {
                this.unitOfWork = unitOfWork;

                this.writer.WriteLine("inseart Id:");

                int id;
                bool result = int.TryParse(this.reader.ReadLine(), out id);
                if (!result)
                {
                    this.writer.WriteLine("invalid value");
                }
                else
                {
                    var team = unitOfWork.Teams.Get(id);

                    this.writer.WriteLine(team.ToString());
                }

            }
        }

        public void ReadPlayerStatisticByIDCommand()
        {
            using (var unitOfWork = new UnitOfWork(new NbaContext()))
            {
                this.unitOfWork = unitOfWork;

                this.writer.WriteLine("inseart Id:");

                int id;
                bool result = int.TryParse(this.reader.ReadLine(), out id);
                if (!result)
                {
                    this.writer.WriteLine("invalid value");
                }
                else
                {
                    var PS = unitOfWork.PlayerStatistic.Get(id);

                    this.writer.WriteLine(PS.ToString());
                }

            }
        }
    }    
}
