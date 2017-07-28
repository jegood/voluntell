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
    public class VolunteerService
    {
        private IVolunteerDataAdapter _dataAdapter;

        public VolunteerService(IVolunteerDataAdapter dataAdapter)
        {
            if (dataAdapter == null)
            {
                throw new ArgumentNullException(nameof(dataAdapter));
            }

            _dataAdapter = dataAdapter;
        }

        public async Task<Guid> AddVolunteerAsync(Volunteer volunteer, CancellationToken token)
        {
            if (volunteer == null)
            {
                throw new ArgumentNullException(nameof(volunteer));
            }

            if (volunteer.First == null)
            {
                throw new ArgumentNullException(nameof(volunteer.First));
            }

            if (volunteer.Last == null)
            {
                throw new ArgumentNullException(nameof(volunteer.Last));
            }

            if (volunteer.EmailAddress == null)
            {
                throw new ArgumentNullException(nameof(volunteer.EmailAddress));
            }

            if (volunteer.ReferralId == null)
            {
                throw new ArgumentNullException(nameof(volunteer.Last));
            }

            return await _dataAdapter.AddVolunteerAsync(volunteer, token);
        }
    }
}