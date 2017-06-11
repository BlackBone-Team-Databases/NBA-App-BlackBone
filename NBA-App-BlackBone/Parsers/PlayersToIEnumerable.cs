using NbaBlackBone.Models;
using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Parsers
{
    class PlayersToIEnumerable
    {
        ICollection<IPlayer> playersColection;

        public PlayersToIEnumerable()
        {
            this.playersColection = new HashSet<IPlayer>();
        }

        public ICollection<IPlayer> Cast()
        {
            var x = new TxtParse();
            string[,] array = x.Parse(@"..\..\DataSource\players20120510040.txt");

            int name = 1;
            int lastName = 2;
            int position = 6;



            for (int index = 2; index < array.GetLength(0); index++)
            {
                if (string.IsNullOrEmpty(array[index, 0]))
                {
                    break;
                }
                var player = new Player();

                player.FirstName = array[index, name];
                player.LastName = array[index, lastName];
                player.Position = float.Parse(array[index, position], CultureInfo.InvariantCulture);

               

                playersColection.Add(player);
            }

            return playersColection;
        }
    }
}
