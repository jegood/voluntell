using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VolunTell.IDataAdapters;
using VolunTell.Models;

namespace VolunTell.Services
{
    public class EventService
    {
        private IEventDataAdapter _dataAdapter;

        #region Constructor
        public EventService(IEventDataAdapter dataAdapter)
        {
            if (dataAdapter == null)
            {
                throw new ArgumentNullException(nameof(dataAdapter));
            }
            _dataAdapter = dataAdapter;
        }
        #endregion Constructor

        #region Event

        public async Task<Guid> AddEventAsync(Event Data)
        {
            return await _dataAdapter.AddEventAsync(Data);
        }

        public async Task<ConnectionTree> GetConnectionsForEventAsync(Guid eventId)
        {

        }

        public async Task<List<Volunteer>> GetVolunteersForEventAsync(Guid eventId)
        {
            return await _dataAdapter.GetVolunteersForEventAsync(eventId);
        }

        #endregion Event
    }
}