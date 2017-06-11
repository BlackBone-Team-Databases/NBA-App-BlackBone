using NbaBlackBone.Parsers;
using NBABlackBone.Models;
using NBABlackBone.Postgre;
using System.Collections.Generic;

namespace NbaBlackBone
{
    public class Program
    {
        public static void Main()
        {
            var parse = new Json();
            ICollection<Schedule> schedules = parse.ParseSchedule();


            var fillPostgre = new FillPostgre();
            fillPostgre.Fill(schedules);


        //var reader = new ConsoleReaderProvider();
        //    var writer = new ConsoleWriterProvider();
        //    var commandFactory = new CommandFactory(reader, writer);

        //    var menu = new Menu(reader, writer, commandFactory);
        //    menu.Start();
        }
    }
}
