using NbaBlackBone.Models;
using NbaBlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Parsers
{
    class TeamsToIEnumerable
    {
        ICollection<ITeam> TeamsCollection;

        public TeamsToIEnumerable()
        {
            this.TeamsCollection = new List<ITeam>();
        }

        public void Cast()
        {
            var x = new TxtParse();
            string[,] array = x.Parse(@"..\..\DataSource\teamstats20120510040.txt");

            int name = 0;
            int min = 1;
            int offrtg = 6;
            int deffrtg = 7;
            int overalRtg = 8;



            for (int index = 1; index < array.GetLength(0); index++)
            {
                if (string.IsNullOrEmpty(array[index, 0]))
                {
                    break;
                }
                var team = new Team()
                {
                    Name = array[index, name].ToString(),
                    Minutes = float.Parse(array[index, min]),
                    OffRtg = float.Parse(array[index, offrtg]),
                    DeffRtg = float.Parse(array[index, deffrtg]),
                    OverallRtg = float.Parse(array[index, overalRtg])
                };

                TeamsCollection.Add(team);
            }

            foreach (var player in TeamsCollection)
            {
              Console.WriteLine(player.ToString());
            }
        }
    }
}
