using NBABlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NbaBlackBone.Models;
using NbaBlackBone.Models.Enums;

namespace NBABlackBone.Models
{
    class Standings : IStandings
    {
        public int Id { get; set; }

        public ConferencesEnum ConferenceEnum { get; set; }

        public virtual ICollection<string> Teams { get; set; }
    }
}
