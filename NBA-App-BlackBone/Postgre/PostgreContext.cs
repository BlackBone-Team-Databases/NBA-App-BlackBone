using NBABlackBone.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Postgre
{
    public class PostgreContext : DbContext
    {
        public PostgreContext() 
            : base(nameOrConnectionString: "NbaPostgre")
        {

        }
        public DbSet<Schedule> Scedules { get; set; }

        public DbSet<TeamAttendance> Teams { get; set; }
    }

    //[Table("pets", Schema = "public")]
    //public class Pet
    //{
    //    [Key]
    //    [Column("id")]
    //    public int ID { get; set; }
    //    [Column("name")]
    //    public string Name { get; set; }
    //}

}
