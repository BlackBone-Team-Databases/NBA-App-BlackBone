using NBABlackBone.Core.Providers;
using NBABlackBone.Models;
using NBABlackBone.Parsers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace NBABlackBone
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new ConsoleReaderProvider();
            var writer = new ConsoleWriterProvider();

            /* using (var db = new NbaContext())
            {
                db.Players.Add(new Models.Player { FirstName = "Pavel Ivanov" });
                db.SaveChanges();


                var query = from b in db.Players
                            orderby b.FirstName
                            select b;
          
                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName);
                    Console.WriteLine(item.LastName);
                }

            }*/

            //var parser = new JsonParse();
            //parser.TeamParse(@"C:\Users\admin\Desktop\AllData20120510040\json\teamstats20120510040.json"); //teamStats i team sa w edno
            //parser.PlayerParse(@"C:\Users\admin\Desktop\AllData20120510040\json\players20120510040.json");
            //parser.PlayerStatsticParse(@"C:\Users\admin\Desktop\AllData20120510040\json\.json"); // player stats da se naprawi w json


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
                            //CreatePlayerCommand(this.reader, this.writer)
                        }
                        else if (input == 2)
                        {
                            // TODO
                            //CreateTeamCommand(this.reader, this.writer)
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
                            //ReadPlayerCommand(this.reader, this.writer)
                        }
                        else if (input == 2)
                        {
                            // TODO
                            //ReadTeamCommand(this.reader, this.writer)
                        }
                        else if (input == 3)
                        {
                            // TODO
                            //ReadPSCommand(this.reader, this.writer)
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
                            //UpdatePlayerCommand(this.reader, this.writer)
                        }
                        else if (input == 2)
                        {
                            // TODO
                            //UpdateTeamCommand(this.reader, this.writer)
                        }
                        else if (input == 3)
                        {
                            // TODO
                            //UpdatePSCommand(this.reader, this.writer)
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
                            //DeletePlayerCommand(this.reader, this.writer)
                        }
                        else if (input == 2)
                        {
                            // TODO
                            //DeleteTeamCommand(this.reader, this.writer)
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
