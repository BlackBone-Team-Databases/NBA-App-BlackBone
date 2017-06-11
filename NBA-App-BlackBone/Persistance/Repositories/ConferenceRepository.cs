using NbaBlackBone.Models;
using NbaBlackBone.Repositories;
using NBABlackBone.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NbaBlackBone.Persistance;

namespace NBABlackBone.Persistance.Repositories
{
    public class ConferenceRepository : Repository<Conference>, IConferenceRepository
    {
        public ConferenceRepository(NbaContext context) 
            : base(context)
        {
        }

        public IEnumerable<Conference> GetTopTeamByConference(int count)
        {
            throw new NotImplementedException();
        }

        public NbaContext NbaContext
        {
            get { return context as NbaContext; }
        }
    }
}
