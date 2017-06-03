using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWorkTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NbaContext())
            {
                db.Players.Add(new Models.Player { Name = "Pavel Ivanov" });
                db.SaveChanges();
            }
        }
    }
}
