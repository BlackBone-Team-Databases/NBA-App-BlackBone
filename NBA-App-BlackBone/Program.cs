using NbaBlackBone.Core.Providers;
using NbaBlackBone.Models;
using NbaBlackBone.Parsers;
using NBABlackBone.Core.Menu;
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
            var reader = new ConsoleReaderProvider();
            var writer = new ConsoleWriterProvider();

            var x = new PlayerStatsToIEnumerable();
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


            //using (var db = new NbaContext())
            //{
            //    db.Players.Add(new Models.Player { FirstName = "Pavel Ivanov" });
            //    db.SaveChanges();


            //    var query = from b in db.Players
            //                orderby b.FirstName
            //                select b;

            //    Console.WriteLine("All blogs in the database:");
            //    foreach (var item in query)
            //    {
            //        Console.WriteLine(item.FirstName);
            //        Console.WriteLine(item.LastName);
            //    }

            //}

            //var parser = new JsonParse();
            //parser.TeamParse(@"C:\Users\admin\Desktop\AllData20120510040\json\teamstats20120510040.json"); //teamStats i team sa w edno
            //parser.PlayerParse(@"C:\Users\admin\Desktop\AllData20120510040\json\players20120510040.json");
            //parser.PlayerStatsticParse(@"C:\Users\admin\Desktop\AllData20120510040\json\.json"); // player stats da se naprawi w json

            //var parser = new XmlParse();
            //parser.Parse(@"c:\users\admin\desktop\alldata20120510040\xml\teamstats20120510040.xml");
            //Console.WriteLine(parser);

            var menu = new Menu(reader, writer);
            menu.Start();
        }
    }
}
