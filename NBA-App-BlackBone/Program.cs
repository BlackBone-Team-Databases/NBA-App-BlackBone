using NbaBlackBone.Core.Providers;
using NBABlackBone.Core.Menu;
using NBABlackBone.Parsers;

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

            var menu = new Menu(reader, writer);
            menu.Start();
        }
    }
}
