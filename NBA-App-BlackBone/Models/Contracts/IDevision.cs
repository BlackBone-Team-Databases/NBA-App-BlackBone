using NbaBlackBone.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaBlackBone.Models.Contracts
{
    public interface IDevision
    {
        int Id { get; set; }

        DevisionsEnum DevisionEnum { get; set; }

        Conference Conference { get; set; }

        ICollection<Team> Teams { get; set; }

        string Url { get; set; }
    }
}
