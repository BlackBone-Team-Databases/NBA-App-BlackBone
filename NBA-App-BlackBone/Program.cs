using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (var db = new NbaContext())
            {
                db.Players.Add(new Models.Player { FirstName = "Pavel Ivanov" });
                db.SaveChanges();
            }*/
            int input = 6;
            bool res;
            while (input != 0)
            {
                Console.WriteLine("Choose from the options below");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Generete Report");
                Console.WriteLine("0. Exit");
                Console.WriteLine();

                res = int.TryParse(Console.ReadLine(), out input);
                if (res == false)
                {
                    input = 6;
                }

                switch (input)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Choose what to create:");
                        Console.WriteLine("1. Create Player");
                        Console.WriteLine("2. Create Team");
                        Console.WriteLine("3. Back");
                        Console.WriteLine();

                        res = int.TryParse(Console.ReadLine(), out input);
                        if (res == false)
                        {
                            input = 6;
                        }

                        if (input == 1)
                        {
                            // TODO
                            //CreatePlayerCommand()
                        }
                        else if (input == 2)
                        {
                            // TODO
                            //CreateTeamCommand()
                        }
                        else if (input == 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorect input value");
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Choose what to read:");
                        Console.WriteLine("1. Read Player");
                        Console.WriteLine("2. Read Team");
                        Console.WriteLine("3. Read Player Stats");
                        Console.WriteLine("4. Back");
                        Console.WriteLine();

                        res = int.TryParse(Console.ReadLine(), out input);
                        if (res == false)
                        {
                            input = 6;
                        }

                        if (input == 1)
                        {
                            // TODO
                            //ReadPlayerCommand()
                        }
                        else if (input == 2)
                        {
                            // TODO
                            //ReadTeamCommand()
                        }
                        else if (input == 3)
                        {
                            // TODO
                            //ReadPSCommand()
                        }
                        else if (input == 4)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorect input value");
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Choose what to update:");
                        Console.WriteLine("1. Update Player Info");
                        Console.WriteLine("2. Update Team Info");
                        Console.WriteLine("3. Update Player Stats");
                        Console.WriteLine("4. Back");
                        Console.WriteLine();

                        res = int.TryParse(Console.ReadLine(), out input);
                        if (res == false)
                        {
                            input = 6;
                        }

                        if (input == 1)
                        {
                            // TODO
                            //UpdatePlayerCommand()
                        }
                        else if (input == 2)
                        {
                            // TODO
                            //UpdateTeamCommand()
                        }
                        else if (input == 3)
                        {
                            // TODO
                            //UpdatePSCommand()
                        }
                        else if (input == 4)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorect input value");
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Choose what to delete:");
                        Console.WriteLine("1. Delete Player (will delete the player statistic also)");
                        Console.WriteLine("2. Delete Team");
                        Console.WriteLine("3. Back");
                        Console.WriteLine();

                        res = int.TryParse(Console.ReadLine(), out input);
                        if (res == false)
                        {
                            input = 6;
                        }

                        if (input == 1)
                        {
                            // TODO
                            //DeletePlayerCommand()
                        }
                        else if (input == 2)
                        {
                            // TODO
                            //DeleteTeamCommand()
                        }
                        else if (input == 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorect input value");
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        // TODO
                        //GenerateReportCommand()
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Incorect Input value");
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
