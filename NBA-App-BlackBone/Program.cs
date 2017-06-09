using NbaBlackBone.Core.Providers;
using NbaBlackBone.Parsers;
using NBABlackBone.Core.Commands;
using NBABlackBone.Core.Menu;
using NBABlackBone.Parsers;

namespace NbaBlackBone
{
    class Program
    {
        static void Main()
        {

            Json.Parse();

            //var reader = new ConsoleReaderProvider();
            //var writer = new ConsoleWriterProvider();
            //var commandFactory = new CommandFactory(reader, writer);

            //var menu = new Menu(reader, writer, commandFactory);
            //menu.Start();
        }
    }
}
