using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaBlackBone.Models.Contracts
{
    public interface IPlayerStatistic
    {
        int Id { get; set; }

        int PPG { get; set; }

        int PRG { get; set; }

        int Blocks { get; set; }

        IPlayer Player { get; set; }

        string Url { get; set; }
    }
}
