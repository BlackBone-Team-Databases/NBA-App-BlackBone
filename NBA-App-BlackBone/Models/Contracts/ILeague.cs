﻿using NbaBlackBone.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaBlackBone.Models.Contracts
{
    public interface ILeague
    {
        string Id { get; set; }

        LeaguesEnum LeagueEnum { get; set; }

        ICollection<IConference> Conferences { get; set; }

        string Url { get; set; }
    }
}
