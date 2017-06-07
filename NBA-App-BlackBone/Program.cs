﻿using NbaBlackBone.Core.Providers;
using NbaBlackBone.Models;
using NbaBlackBone.Parsers;
using NBABlackBone.Parsers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace NbaBlackBone
{
    class Program
    {
        static void Main()
        {
            //var reader = new ConsoleReaderProvider();
            //var writer = new ConsoleWriterProvider();

            var x = new PlayersToIEnumerable();
            x.Cast();
            //var x = new TxtParse();
            //x.Parse(@"..\..\DataSource\teamstats20120510040.txt");
            //x.Parse(@"C:\Users\boda66\Desktop\TeamWork\NBA-App-BlackBone\NBA-App-BlackBone\DataSource\players20120510040.txt");
            //x.Parse(@"C:\Users\boda66\Desktop\TeamWork\NBA-App-BlackBone\NBA-App-BlackBone\DataSource\playerstats20120510040.txt");

            //string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\admin\Desktop\AllData20120510040\xlsx\players20120510040.xlsx;";
            //using (OleDbConnection connection = new OleDbConnection(con))
            //{
            //    connection.Open();
            //    OleDbCommand command = new OleDbCommand("select * from [Sheet1$]", connection);
            //    using (OleDbDataReader dr = command.ExecuteReader())
            //    {
            //        while (dr.Read())
            //        {
            //            var row1Col0 = dr[0];
            //            Console.WriteLine(row1Col0);
            //        }
            //    }
            //}


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

            //var parser = new XmlParse();
            //parser.Parse(@"c:\users\admin\desktop\alldata20120510040\xml\teamstats20120510040.xml");
            //Console.WriteLine(parser);

            //int input = 6;
            //bool res;
            //while (input != 0)
            //{
            //    Console.WriteLine("Choose from the options below");
            //    Console.WriteLine("1. Create");
            //    Console.WriteLine("2. Read");
            //    Console.WriteLine("3. Update");
            //    Console.WriteLine("4. Delete");
            //    Console.WriteLine("5. Generete Report");
            //    Console.WriteLine("0. Exit");
            //    Console.WriteLine();

            //    res = int.TryParse(Console.ReadLine(), out input);
            //    if (res == false)
            //    {
            //        input = 6;
            //    }

            //    switch (input)
            //    {
            //        case 1:
            //            Console.WriteLine();
            //            Console.WriteLine("Choose what to create:");
            //            Console.WriteLine("1. Create Player");
            //            Console.WriteLine("2. Create Team");
            //            Console.WriteLine("3. Back");
            //            Console.WriteLine();

            //            res = int.TryParse(Console.ReadLine(), out input);
            //            if (res == false)
            //            {
            //                input = 6;
            //            }

            //            if (input == 1)
            //            {
            //                // TODO
            //                //CreatePlayerCommand(this.reader, this.writer)
            //            }
            //            else if (input == 2)
            //            {
            //                // TODO
            //                //CreateTeamCommand(this.reader, this.writer)
            //            }
            //            else if (input == 3)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Incorect input value");
            //                Console.WriteLine();
            //            }
            //            break;
            //        case 2:
            //            Console.WriteLine();
            //            Console.WriteLine("Choose what to read:");
            //            Console.WriteLine("1. Read Player");
            //            Console.WriteLine("2. Read Team");
            //            Console.WriteLine("3. Read Player Stats");
            //            Console.WriteLine("4. Back");
            //            Console.WriteLine();

            //            res = int.TryParse(Console.ReadLine(), out input);
            //            if (res == false)
            //            {
            //                input = 6;
            //            }

            //            if (input == 1)
            //            {
            //                // TODO
            //                //ReadPlayerCommand(this.reader, this.writer)
            //            }
            //            else if (input == 2)
            //            {
            //                // TODO
            //                //ReadTeamCommand(this.reader, this.writer)
            //            }
            //            else if (input == 3)
            //            {
            //                // TODO
            //                //ReadPSCommand(this.reader, this.writer)
            //            }
            //            else if (input == 4)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Incorect input value");
            //                Console.WriteLine();
            //            }
            //            break;
            //        case 3:
            //            Console.WriteLine();
            //            Console.WriteLine("Choose what to update:");
            //            Console.WriteLine("1. Update Player Info");
            //            Console.WriteLine("2. Update Team Info");
            //            Console.WriteLine("3. Update Player Stats");
            //            Console.WriteLine("4. Back");
            //            Console.WriteLine();

            //            res = int.TryParse(Console.ReadLine(), out input);
            //            if (res == false)
            //            {
            //                input = 6;
            //            }

            //            if (input == 1)
            //            {
            //                // TODO
            //                //UpdatePlayerCommand(this.reader, this.writer)
            //            }
            //            else if (input == 2)
            //            {
            //                // TODO
            //                //UpdateTeamCommand(this.reader, this.writer)
            //            }
            //            else if (input == 3)
            //            {
            //                // TODO
            //                //UpdatePSCommand(this.reader, this.writer)
            //            }
            //            else if (input == 4)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Incorect input value");
            //                Console.WriteLine();
            //            }
            //            break;
            //        case 4:
            //            Console.WriteLine();
            //            Console.WriteLine("Choose what to delete:");
            //            Console.WriteLine("1. Delete Player (will delete the player statistic also)");
            //            Console.WriteLine("2. Delete Team");
            //            Console.WriteLine("3. Back");
            //            Console.WriteLine();

            //            res = int.TryParse(Console.ReadLine(), out input);
            //            if (res == false)
            //            {
            //                input = 6;
            //            }

            //            if (input == 1)
            //            {
            //                // TODO
            //                //DeletePlayerCommand(this.reader, this.writer)
            //            }
            //            else if (input == 2)
            //            {
            //                // TODO
            //                //DeleteTeamCommand(this.reader, this.writer)
            //            }
            //            else if (input == 3)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Incorect input value");
            //                Console.WriteLine();
            //            }
            //            break;
            //        case 5:
            //            // TODO
            //            //GenerateReportCommand()
            //            break;
            //        case 0:
            //            return;
            //        default:
            //            Console.WriteLine();
            //            Console.WriteLine("Incorect Input value");
            //            Console.WriteLine();
            //            break;
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
