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
        public static void Parse()
        {
            string jsonPath = @"../../DataSource/standings-min.json";
            string json;
            using (StreamReader reader = new StreamReader(jsonPath))
            {
                json = reader.ReadToEnd();
            }

            var serializer = new JavaScriptSerializer();
            List<Standings> ser = (List<Standings>)serializer.Deserialize(json, typeof(List<Standings>));
            Console.WriteLine(ser);
        }
    }
}
