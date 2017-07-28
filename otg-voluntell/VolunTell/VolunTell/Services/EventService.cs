using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VolunTell.Models;

namespace VolunTell.Services
{
    public class EventService
    {
        public EventService()
        {

        }

        #region Event

        public async Task<Guid> AddEventAsync(Event Data)
        {
            var result = 
        }

        public async Task<ConnectionTree> GetConnectionsForEventAsync(Guid eventId)
        {

        }

        public async Task<List<Volunteer>> GetVolunteersForEventAsync(Guid eventId)
        {

        }

        #endregion Event
    }
}