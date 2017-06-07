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

        float Minutes { get; set; }

        int SimplePossFor { get; set; }

        int SimplePointsFor { get; set; }

        int SimpleORebFor { get; set; }

        IPlayer Player { get; set; }

        string Url { get; set; }
    }
}
