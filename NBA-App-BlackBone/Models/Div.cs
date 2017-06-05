using System;
using System.Collections.Generic;
using TeamWorkTEST.Models;
using TeamWorkTEST.Models.Enums;

namespace TeamWorkTEST
{

    public class Div
    {
        public Div()
        {

        }

        public int Id { get; set; }

        public Devisions Devision { get; set; }

        public virtual Confer Conference { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public string Url { get; set; }
    }
}
