using NBABlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Models
{
    public class Date : IDate
    {
        public Date()
        {

        }

        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }
    }
}
