using NbaBlackBone;
using NbaBlackBone.Core.Contracts;
using NbaBlackBone.Models;
using NbaBlackBone.Models.Enums;
using NbaBlackBone.Parsers;
using NbaBlackBone.Persistance;
using NBABlackBone.Parsers;
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
                player.PlayerStatistic = playerStatistic;
                playerStatistic.Player = player;

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

        public void DeletePlayerCommand()
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
                    var playerStatistic = unitOfWork.PlayerStatistic.Get(id);

                    unitOfWork.Players.Remove(player);
                    unitOfWork.PlayerStatistic.Remove(playerStatistic);
                    unitOfWork.Complete();

                    this.writer.WriteLine("success");
                }

            }
        }

        public void DeleteTeamCommand()
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
                    
                    unitOfWork.Teams.Remove(team);
                    unitOfWork.Complete();

                    this.writer.WriteLine("success");
                }

            }
        }

        public void UpdatePlayerCommand()
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
                    string input;
                    this.writer.WriteLine("insert new FirstName (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if(input != "")
                    {
                        player.FirstName = input;
                    }

                    this.writer.WriteLine("insert new LastName (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        player.LastName = input;
                    }

                    this.writer.WriteLine("insert new Position (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        player.Position = int.Parse(input);
                    }

                    this.writer.WriteLine("insert new TeamId (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        player.Team = unitOfWork.Teams.Get(int.Parse(input));
                    }

                    unitOfWork.Update(player);
                    unitOfWork.Complete();

                    this.writer.WriteLine("success");
                }

            }
        }

        public void UpdateTeamCommand()
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
                    string input;
                    this.writer.WriteLine("insert new Name (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        team.Name = input;
                    }

                    this.writer.WriteLine("insert new Minutes (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        team.Minutes = float.Parse(input);
                    }

                    this.writer.WriteLine("insert new OffRtg (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        team.OffRtg = int.Parse(input);
                    }

                    this.writer.WriteLine("insert new DeffRtg (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        team.DeffRtg = int.Parse(input);
                    }

                    this.writer.WriteLine("insert new OveralRtg (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        team.OverallRtg = int.Parse(input);
                    }

                    this.writer.WriteLine("insert new DevisionId (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        team.Devision = unitOfWork.Devisions.Get(int.Parse(input));
                    }

                    unitOfWork.Update(team);
                    unitOfWork.Complete();

                    this.writer.WriteLine("success");
                }

            }
        }

        public void UpdatePlayerStatisticCommand()
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
                    var playerStatistic = unitOfWork.PlayerStatistic.Get(id);
                    string input;
                    this.writer.WriteLine("insert new Minutes (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        playerStatistic.Minutes = float.Parse(input);
                    }

                    this.writer.WriteLine("insert new SimplePointsFor (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        playerStatistic.SimplePointsFor = int.Parse(input);
                    }

                    this.writer.WriteLine("insert new SimplePossFor (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        playerStatistic.SimplePossFor = int.Parse(input);
                    }

                    this.writer.WriteLine("insert new SimpleORebFor (if you dont want to change it press enter):");
                    input = this.reader.ReadLine();
                    if (input != "")
                    {
                        playerStatistic.SimpleORebFor = int.Parse(input);
                    }



                    unitOfWork.Update(playerStatistic);
                    unitOfWork.Complete();

                    this.writer.WriteLine("success");
                }

            }
        }

        public void FillDataBase()
        {

            //var Parser = new TeamsToIEnumerable();
            //var Parser = new PlayersToIEnumerable();
            var parser = new JsonParser();
            var Collection = parser.Cast();

            foreach (var collection in Collection)
            {
                Console.WriteLine(collection.ToString());
            }

        }
    }    
}
