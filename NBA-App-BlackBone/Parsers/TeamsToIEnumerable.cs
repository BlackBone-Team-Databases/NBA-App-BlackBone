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
    class TeamsToIEnumerable
    {
        ICollection<Team> TeamsCollection;

        public TeamsToIEnumerable()
        {
            this.TeamsCollection = new List<Team>();
        }

        public ICollection<Team> Cast()
        {
            string path = @"..\..\DataSource\teamstats20120510040.txt";
            var x = new TxtParse();
            string[,] array = x.Parse(path);

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
                var team = new Team();

                team.Name = array[index, name];
                team.Minutes = float.Parse(array[index, min], CultureInfo.InvariantCulture);
                team.OffRtg = float.Parse(array[index, offrtg], CultureInfo.InvariantCulture);
                team.DeffRtg = float.Parse(array[index, deffrtg], CultureInfo.InvariantCulture);
                team.OverallRtg = float.Parse(array[index, overalRtg], CultureInfo.InvariantCulture);
                

                TeamsCollection.Add(team);
            }

            return TeamsCollection;
        }
    }
}
