using NbaBlackBone.Core.Providers;
using NbaBlackBone.Parsers;
using NBABlackBone.Core.Commands;
using NBABlackBone.Core.Menu;
using NBABlackBone.Models;
using NBABlackBone.Parsers;
using System.Collections.Generic;

namespace NbaBlackBone
{
    public class Program
    {
        public static void Main()
        {
            var parse = new Json();
            ICollection<Schedule> standings = parse.ParseSchedule();


            var reader = new ConsoleReaderProvider();
            var writer = new ConsoleWriterProvider();
            var commandFactory = new CommandFactory(reader, writer);

            var menu = new Menu(reader, writer, commandFactory);
            menu.Start();
        }
    }
}
