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
    public class PlayerStatsToIEnumerable
    {
        ICollection<IPlayerStatistic> playersStatsCollection;

        public PlayerStatsToIEnumerable()
        {
            this.playersStatsCollection = new List<IPlayerStatistic>();
        }

        public ICollection<IPlayerStatistic> Cast()
        {
            string path = @"..\..\DataSource\playerstats20120510040.txt";
            var x = new TxtParse();
            string[,] array = x.Parse(path);

            int min = 4;
            int SpossF = 5;
            int SpointsF = 7;
            int SorebF = 12;

            for (int index = 1; index < array.GetLength(0); index++)
            {
                if (string.IsNullOrEmpty(array[index, 0]))
                {
                    break;
                }
                var playerStats = new PlayerStatistic()
                {
                    Minutes = float.Parse(array[index, min], CultureInfo.InvariantCulture),
                    SimplePossFor = int.Parse(array[index, SpossF], CultureInfo.InvariantCulture),
                    SimplePointsFor = int.Parse(array[index, SpointsF], CultureInfo.InvariantCulture),
                    SimpleORebFor = int.Parse(array[index, SorebF], CultureInfo.InvariantCulture)
                };

                playersStatsCollection.Add(playerStats);
            }

            return playersStatsCollection;
        }
    }
}
