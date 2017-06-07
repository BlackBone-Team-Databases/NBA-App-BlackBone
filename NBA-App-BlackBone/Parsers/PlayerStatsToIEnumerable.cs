using NbaBlackBone.Models;
using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Parsers
{
    class PlayerStatsToIEnumerable
    {
        ICollection<IPlayerStatistic> playersStatsCollection;

        public PlayerStatsToIEnumerable()
        {
            this.playersStatsCollection = new List<IPlayerStatistic>();
        }

        public void Cast()
        {
            string path = @"..\..\DataSource\playerstats20120510040.txt";
            var x = new TxtParse();
            string[,] array = x.Parse(path);

            int min = 3;
            int SpossF = 4;
            int SpointsF = 6;
            int SorebF = 11;

            for (int index = 1; index < array.GetLength(0); index++)
            {
                if (string.IsNullOrEmpty(array[index, 0]))
                {
                    break;
                }
                var playerStats = new PlayerStatistic()
                {
                    Minutes = float.Parse(array[index, min]),
                    SimplePossFor = int.Parse(array[index, SpossF]),
                    SimplePointsFor = int.Parse(array[index, SpointsF]),
                    SimpleORebFor = int.Parse(array[index, SorebF])
                };

                playersStatsCollection.Add(playerStats);
            }

            foreach (var playerStats in playersStatsCollection)
            {
                Console.WriteLine(playerStats.ToString());
            }
        }
    }
}
