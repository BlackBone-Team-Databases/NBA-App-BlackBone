using NbaBlackBone.Core.Providers;
using NbaBlackBone.Parsers;
using NBABlackBone.Core.Commands;
using NBABlackBone.Core.Menu;
using NBABlackBone.Models;
using NBABlackBone.Parsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace NbaBlackBone
{
    public class Program
    {
        public static void Main()
        {
            //var parse = new Json();
            //ICollection<Schedule> standings = parse.ParseSchedule();


            var db = new DB();

            var pet = new Pet { ID = 1, Name = "Stevie" };
            db.Pets.Add(pet);
            db.SaveChanges();

            var pets = db.Pets;
            foreach (var p in pets)
            {
                Console.WriteLine(p.Name);
            }
            Console.Read();
        



        //var reader = new ConsoleReaderProvider();
        //    var writer = new ConsoleWriterProvider();
        //    var commandFactory = new CommandFactory(reader, writer);

        //    var menu = new Menu(reader, writer, commandFactory);
        //    menu.Start();
        }
    }

    [Table("pets", Schema = "public")]
    public class Pet
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("name")]
        public string Name { get; set; }
    }
    public class DB : DbContext
    {
        public DB() : base(nameOrConnectionString: "MonkeyFist") { }
        public DbSet<Pet> Pets { get; set; }
    }
}
