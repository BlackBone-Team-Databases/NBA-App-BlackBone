using NbaBlackBone.Models.Contracts;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NbaBlackBone.Models
{
    public class PlayerStatistic : IPlayerStatistic
    {
        public PlayerStatistic()
        {

        }

        [ForeignKey("Player")]
        public int Id { get; set; }

        public float Minutes { get; set; }

        public int SimplePossFor { get; set; }

        public int SimplePointsFor { get; set; }

        public int SimpleORebFor { get; set; }

        public virtual IPlayer Player { get; set; }

        public string Url { get; set; }

        public override string ToString()
        {
            return string.Format($"Minutes: {Minutes}\nPossesionFor: {SimplePossFor}\nPointsFor: {SimplePointsFor}\nReboundFor: {SimpleORebFor}\n");
        }
    }
}
