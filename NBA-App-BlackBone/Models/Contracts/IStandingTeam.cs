using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Models.Contracts
{
    public interface IStandingTeam
    {
        int Id { get; set; }

        string Name { get; set; }
    }
}
