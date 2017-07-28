using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using VolunTell.Models;
using VolunTell.Services;

namespace VolunTell.Controllers
{
    public class EventController : ApiController
    {
        #region Fields

        private EventService _eventService;

        #endregion Fields

        #region Constructor
        public EventController(EventService eventService)
        {
            if (eventService == null)
            {
                throw new ArgumentNullException();
            }

            _eventService = eventService;
        }
        #endregion Constructor

        #region Event

        /// <summary>
        /// Adds a new event to the database.
        /// </summary>
        /// <param name="newEvent"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("events/add")]
        public async Task<Guid> AddEventAsync(Event newEvent, CancellationToken token)
        {
            return await _eventService.AddEventAsync(newEvent);
        }

        /// <summary>
        /// Returns a connection tree where each node just has UserId.
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/events/{eventId}/connectionTree")]
        public async Task<ConnectionTree> GetConnectionsAsync(Guid eventId, CancellationToken token)
        {
            // TODO add to event service
            var result = await _eventService.GetConnectionsForEventAsync(eventId);
            if (result == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return result;
        }

        /// <summary>
        /// Returns a list of volunteers for a given event.
        /// </summary>
        [HttpGet]
        [Route("/events/{eventId}/volunteers")]
        public async Task<List<Volunteer>> GetVolunteersForEventAsync(Guid eventId, CancellationToken token)
        {
            var result = await _eventService.GetVolunteersForEventAsync(eventId);
            if (result == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return result;
        }

        #endregion Event
    }
}