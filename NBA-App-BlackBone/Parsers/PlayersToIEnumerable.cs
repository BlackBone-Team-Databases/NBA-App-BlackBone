using NbaBlackBone.Models;
using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
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
            this.playersColection = new List<IPlayer>();
        }

        public void Cast()
        {
            var x = new TxtParse();
            string[,] array = x.Parse(@"..\..\DataSource\players20120510040.txt");

            int name = 1;
            int lastName = 2;
            int position = 6;



            for (int index = 0; index < array.GetLength(0); index++)
            {
                if (string.IsNullOrEmpty(array[index, 0]))
                {
                    break;
                }
                var player = new Player()
                {
                    FirstName = array[index, name],
                    LastName = array[index, lastName],
                    Position = array[index, position]

                };

                playersColection.Add(player);
            }

            //foreach (var player in playersColection)
            //{
            //    Console.WriteLine(player.ToString());
            //}
        }
    }
}
