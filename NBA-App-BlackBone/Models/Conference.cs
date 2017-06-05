using System;
using System.Collections.Generic;
using TeamWorkTEST.Models.Enums;

namespace TeamWorkTEST.Models
{
    public class Confer
    {
        public Confer()
        {

        }
        public string Id { get; set; }

        public Conferences Conference { get; set; }

        public virtual Leag League { get; set; }

        public virtual ICollection<Div> Devisions { get; set; }

        public string Url { get; set; }
    }
}
