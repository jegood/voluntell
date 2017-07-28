using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

        public async Task<Guid> AddEventAsync(Event Data, CancellationToken token)
        {
            return await _dataAdapter.AddEventAsync(Data, token);
        }

        public async Task<ConnectionTree> GetConnectionsForEventAsync(Guid eventId, CancellationToken token)
        {
            await Task.Yield();
            throw new NotImplementedException();
            /// do lots of things here
        }

        public async Task<List<Volunteer>> GetVolunteersForEventAsync(Guid eventId, CancellationToken token)
        {
            return await _dataAdapter.GetVolunteersForEventAsync(eventId, token);
        }

        #endregion Event
    }
}