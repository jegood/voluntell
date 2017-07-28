using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VolunTell.IDataAdapters;
using VolunTell.Models;

namespace VolunTell
{
    public class EventDataAdapter : IEventDataAdapter
    {

        public async Task<List<Volunteer>> GetVolunteersForEventAsync(Guid eventId)
        {
            throw new NotImplementedException();
        }
    }
}