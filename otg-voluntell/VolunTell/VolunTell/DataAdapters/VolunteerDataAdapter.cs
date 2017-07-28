using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using VolunTell.IDataAdapters;
using VolunTell.Models;

namespace VolunTell
{
    public class VolunteerDataAdapter : IVolunteerDataAdapter
    {
        public async Task<Guid> AddVolunteerAsync(Volunteer volunteer, CancellationToken token)
        {
            
            return volunteer.ReferralId;
        }
    }
}