using NbaBlackBone;
using NbaBlackBone.Models;
using NbaBlackBone.Models.Enums;
using NbaBlackBone.Persistance;
using NBABlackBone.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.MsSQL
{
    class FillMsSQL
    {
        public void Fill()
        {
            using (var unitOfWork = new UnitOfWork(new NbaContext()))
            {

                var TeamParser = new TeamsToIEnumerable();
                var PlayersParser = new PlayersToIEnumerable();
                var PlayerStatisticParser = new JsonParser();

                var Teams = TeamParser.Cast();
                var Players = PlayersParser.Cast();
                var PS = PlayerStatisticParser.Cast();

                for (int i = 0; i < Players.Count; i++)
                {
                    Players.ElementAt(i).PlayerStatistic = PS.ElementAt(i);
                    PS.ElementAt(i).Player = Players.ElementAt(i);

                }


                ICollection<League> Leagues = new List<League>();
                Leagues.Add(new League() { LeagueEnum = LeaguesEnum.NBA });
                Leagues.Add(new League() { LeagueEnum = LeaguesEnum.WNBA });

                ICollection<Conference> Conferences = new List<Conference>();
                Conferences.Add(new Conference() { ConferenceEnum = ConferencesEnum.Eastern });
                Conferences.Add(new Conference() { ConferenceEnum = ConferencesEnum.Western });



                ICollection<Devision> Devisions = new List<Devision>();
                Devisions.Add(new Devision() { DevisionEnum = DevisionsEnum.ATLANTIC });
                Devisions.Add(new Devision() { DevisionEnum = DevisionsEnum.CENTRAL });
                Devisions.Add(new Devision() { DevisionEnum = DevisionsEnum.TEAMSNORTHWEST });
                Devisions.Add(new Devision() { DevisionEnum = DevisionsEnum.TEAMSPACIFIC });
                Devisions.Add(new Devision() { DevisionEnum = DevisionsEnum.TEAMSSOUTHEAST });
                Devisions.Add(new Devision() { DevisionEnum = DevisionsEnum.TEAMSSOUTHWEST });


                unitOfWork.League.AddRange(Leagues);

                unitOfWork.Conference.AddRange(Conferences);

                unitOfWork.Devisions.AddRange(Devisions);

                unitOfWork.Players.AddRange(Players);

                unitOfWork.Teams.AddRange(Teams);

                unitOfWork.PlayerStatistic.AddRange(PS);

                unitOfWork.Complete();
            }
        }
    }
}
