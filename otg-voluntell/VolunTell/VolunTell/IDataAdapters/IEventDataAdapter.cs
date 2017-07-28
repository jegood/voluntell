using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VolunTell.Models;

namespace VolunTell.IDataAdapters
{
    public interface IEventDataAdapter
    {

        /// <summary>
        /// returns list of volunteers
        /// </summary>
        /// <param name="eventId">Id of event</param>
        public Task<List<Volunteer>> GetVolunteersForEventAsync(Guid eventId);

        /// <summary>
        /// Adds a new event and returns its respective guid
        /// </summary>
        /// <param name="Data">Event information</param>
        /// <returns>Guid for that form</returns>
        public Task<Guid> AddEventAsync(Event Data);

        
    }
}