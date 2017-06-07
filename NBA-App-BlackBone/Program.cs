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

            var menu = new Menu(reader, writer);
            menu.Start();
        }
    }
}
