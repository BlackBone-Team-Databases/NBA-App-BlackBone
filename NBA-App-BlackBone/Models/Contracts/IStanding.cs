﻿using NbaBlackBone.Models;
using NbaBlackBone.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Models.Contracts
{
    public interface IStanding
    {
        int Id { get; set; }

        ConferencesEnum ConferenceEnum { get; set; }

        ICollection<StandingTeam> Teams { get; set; }
    }
}
