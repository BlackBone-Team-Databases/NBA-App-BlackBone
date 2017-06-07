using NbaBlackBone.Models;
using System;
using System.IO;
using System.Web.Script.Serialization;

namespace NbaBlackBone.Parsers
{
    //neshtata za MS SQL
    class JsonParse
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
    }
}
