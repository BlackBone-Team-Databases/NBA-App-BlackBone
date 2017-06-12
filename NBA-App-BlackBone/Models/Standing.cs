using NBABlackBone.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NbaBlackBone.Models;
using NbaBlackBone.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NBABlackBone.Models
{
    public class Standing : IStanding
    {
        public Standing()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public ConferencesEnum ConferenceEnum { get; set; }

        public virtual ICollection<StandingTeam> Teams { get; set; }
    }
}
