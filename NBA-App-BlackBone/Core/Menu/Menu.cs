using NbaBlackBone.Core.Contracts;
using NbaBlackBone.Persistance;
using NBABlackBone.Core.Commands;
using System;

namespace NBABlackBone.Core.Menu
{
    public class Menu
    {
        protected IReader reader;
        protected IWriter writer;
        protected ICommandFactory commandFactory;

        public Menu(IReader reader, IWriter writer, ICommandFactory commandFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandFactory = commandFactory;
        }

        public void Start()
        {
            int input = 7;
            while (input != 0)
            {
                PrintMenu.MainMenu();

                input = Input();

                PrintDelimeter();

                switch (input)
                {
                    case 1:
                        PrintMenu.CreateMenu();
                        input = Input();
                        CreateCommandMenu(input);
                        break;
                    case 2:
                        PrintMenu.ReadMenu();
                        input = Input();
                        ReadCommandMenu(input);
                        break;
                    case 3:
                        PrintMenu.UpdateMenu();
                        input = Input();
                        UpdateCommandMenu(input);
                        break;
                    case 4:
                        PrintMenu.DeleteMenu();
                        input = Input();
                        DeleteCommandMenu(input);
                        break;
                    case 5:
                        // TODO : GenerateReportCommand()
                        break;
                    case 6:
                        commandFactory.FillDataBase();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:

                        this.writer.WriteLine("Incorect Input value");
                        break;
                }

                PrintDelimeter();
            }
        }



        protected int Input()
        {
            int input = 7; // TODO: it should be 0 or something else
            bool result = int.TryParse(this.reader.ReadLine(), out input);
            if (!result)
            {
                this.writer.WriteLine("Incorect input value");
            }

            return input;
        }

        protected void PrintDelimeter()
        {
            this.writer.EmptyLine();
            this.writer.WriteLine("======================================================");
            this.writer.EmptyLine();
        }

        protected void CreateCommandMenu(int input)
        {
            
            if (input == 1)
            {
                this.writer.WriteLine(commandFactory.CreatePlayerCommand());
            }
            else if (input == 2)
            {
            this.writer.WriteLine(commandFactory.CreateTeamCommand());
            }
            else if (input != 3)
            {
                writer.WriteLine("Ivalid Value!");
            }
            
        }

        protected void UpdateCommandMenu(int input)
        {
            if (input == 1)
            {
                commandFactory.UpdatePlayerCommand();
            }
            else if (input == 2)
            {
                commandFactory.UpdateTeamCommand();
            }
            else if (input == 3)
            {
                commandFactory.UpdatePlayerStatisticCommand();
            }
            else if (input != 4)
            {
                writer.WriteLine("Ivalid Value!");
            }
        }


        protected void ReadCommandMenu(int input)
        {
            if (input == 1)
            {
                commandFactory.ReadAllPlayersCommand();
            }
            else if (input == 2)
            {
                commandFactory.ReadPlayerByIDCommand();
            }
            else if (input == 3)
            {
                commandFactory.ReadAllTeamsCommand();
            }
            else if (input == 4)
            {
                commandFactory.ReadTeamByIDCommand();
            }
            else if (input == 5)
            {
                commandFactory.ReadPlayerStatisticByIDCommand();
            }
            else if (input != 6)
            {
                writer.WriteLine("Ivalid Value!");
            }
        }

        protected void DeleteCommandMenu(int input)
        {
            if (input == 1)
            {
                commandFactory.DeletePlayerCommand();
            }
            else if (input == 2)
            {
                commandFactory.DeleteTeamCommand();
            }
            else if (input != 3)
            {
                writer.WriteLine("Ivalid Value!");
            }
        }
    }
}
