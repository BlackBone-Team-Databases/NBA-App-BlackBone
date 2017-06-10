using NbaBlackBone.Models;
using NBABlackBone.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace NbaBlackBone.Parsers
{
    //neshtata za MS SQL
    public class Json
    {
        public void TeamParse(string text)
        {
            string json;
            using (StreamReader r = new StreamReader(text))
            {
                json = r.ReadToEnd();
            }
            var serializer = new JavaScriptSerializer();

            var myteam = serializer.Deserialize<Team>(json);
        }

        public void PlayerParse(string text)
        {
            string json;
            using (StreamReader r = new StreamReader(text))
            {
                json = r.ReadToEnd();
            }
            var serializer = new JavaScriptSerializer();

            var myteam = serializer.Deserialize<Player>(json);
        }

        public void PlayerStatsticParse(string text)
        {
            string json;
            using (StreamReader r = new StreamReader(text))
            {
                json = r.ReadToEnd();
            }
            var serializer = new JavaScriptSerializer();

            var myteam = serializer.Deserialize<PlayerStatistic>(json);
        }

        public ICollection<Standing> ParseStanding()
        {
            string jsonPath = @"../../DataSource/standings-min1.json";
            string json;
            using (StreamReader reader = new StreamReader(jsonPath))
            {
                json = reader.ReadToEnd();
            }

            var serializer = new JavaScriptSerializer();
            var standingsCollection = (ICollection<Standing>)serializer.Deserialize(json, typeof(ICollection<Standing>));

            return standingsCollection;
        }
    }
}
