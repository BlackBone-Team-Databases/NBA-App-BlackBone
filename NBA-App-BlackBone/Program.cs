using NbaBlackBone.Core.Providers;
using NbaBlackBone.Parsers;
using NBABlackBone.Core.Commands;
using NBABlackBone.Core.Menu;
using NBABlackBone.Models;
using NBABlackBone.Parsers;
using System.Collections.Generic;

namespace NbaBlackBone
{
    class Program
    {
        static void Main()
        {
            var reader = new ConsoleReaderProvider();
            var writer = new ConsoleWriterProvider();
            var commandFactory = new CommandFactory(reader, writer);

            //var x = new PlayerStatsToIEnumerable();
            //x.Cast();

            var parse = new Json();
            ICollection<Standing> standings = parse.ParseStanding();

            //var menu = new Menu(reader, writer, commandFactory);
            //menu.Start();
        }
    }
}
