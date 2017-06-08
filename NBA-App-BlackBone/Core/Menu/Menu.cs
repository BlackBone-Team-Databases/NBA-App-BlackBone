using NbaBlackBone.Core.Contracts;
using NbaBlackBone.Persistance;
using NBABlackBone.Core.Commands;
using System;

namespace NBABlackBone.Core.Menu
{
    public class Menu
    {
        private IReader reader;
        private IWriter writer;
        private ICommandFactory commandFactory;

        public Menu(IReader reader, IWriter writer, ICommandFactory commandFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandFactory = commandFactory;
        }

        public void Start()
        {
            int input = 6;
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



        private int Input()
        {
            int input = 6; // TODO: it should be 0 or something else
            bool result = int.TryParse(this.reader.ReadLine(), out input);
            if (!result)
            {
                this.writer.WriteLine("Incorect input value");
            }

            return input;
        }

        private void PrintDelimeter()
        {
            this.writer.EmptyLine();
            this.writer.WriteLine("======================================================");
            this.writer.EmptyLine();
        }

        private void CreateCommandMenu(int input)
        {
            //using ( var unitOfWork = new UnitOfWork(new NbaContext()))
            //{
                if (input == 1)
                {
                    commandFactory.CreatePlayerCommand();
                    // TODO : CreatePlayerCommand(reader, writer, unitOfWork);
                    //unitOfWork.Players.Add()
                }
                else if (input == 2)
                {
                    commandFactory.CreateTeamCommand();
                    // TODO : CreateTeamCommand(reader, writer, unitOfWork);
                }
                else if (input != 3)
                {
                    writer.WriteLine("Ivalid Value!");
                }
            //}
        }

        private void UpdateCommandMenu(int input)
        {
            if (input == 1)
            {
                // TODO : UpdatePlayerCommand();
            }
            else if (input == 2)
            {
                // TODO : UpdateTeamCommand();
            }
            else if (input == 3)
            {
                // TODO : UpdatePlayerStatisticCommand();
            }
            else if (input != 4)
            {
                writer.WriteLine("Ivalid Value!");
            }
        }


        private void ReadCommandMenu(int input)
        {
            if (input == 1)
            {
                // TODO : ReadPlayerCommand();
            }
            else if (input == 2)
            {
                // TODO : ReadTeamCommand();
            }
            else if (input == 3)
            {
                // TODO : ReadPlayerStatisticCommand();
            }
            else if (input != 4)
            {
                writer.WriteLine("Ivalid Value!");
            }
        }

        private void DeleteCommandMenu(int input)
        {
            if (input == 1)
            {
                // TODO : DeletePlayerCommand();
            }
            else if (input == 2)
            {
                // TODO : DeleteTeamCommand();
            }
            else if (input == 3)
            {
                writer.WriteLine("Ivalid Value!");
            }
        }
    }
}
