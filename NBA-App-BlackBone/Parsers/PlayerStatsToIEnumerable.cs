using NbaBlackBone.Models;
using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Parsers
{
    public class JsonParser
    {
        ICollection<IPlayerStatistic> playersStatsCollection;

        public JsonParser()
        {
            this.playersStatsCollection = new List<IPlayerStatistic>();
        }

        public void Cast()
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
                    Minutes = float.Parse(array[index, min]),
                    SimplePossFor = int.Parse(array[index, SpossF]),
                    SimplePointsFor = int.Parse(array[index, SpointsF]),
                    SimpleORebFor = int.Parse(array[index, SorebF])
                };

                playersStatsCollection.Add(playerStats);
                Console.WriteLine();
            }

            //foreach (var playerStats in playersStatsCollection)
            //{
            //    Console.WriteLine(playerStats.ToString());
            //}
        }
    }
}
