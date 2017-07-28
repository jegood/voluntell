using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using VolunTell.DataAdapterContracts;
using VolunTell.Models;

namespace VolunTell.Services
{
    public class OrganizationService
    {

        private OrganizationDataAdapter _organizationDataAdapter;

        public OrganizationService(OrganizationDataAdapter organizationDataAdapter)
        {
            if (organizationDataAdapter == null)
            {
                throw new ArgumentNullException(nameof(organizationDataAdapter));
            }

            _organizationDataAdapter = organizationDataAdapter;
        }

        public async Task<List<OrganizationGET>> GetOrganizationsAsync(CancellationToken token)
        {
            return await _organizationDataAdapter.GetOrganizationsAsync(token);
        }

        public async Task<List<OrganizationNameGETEvent>> GetEventsForOrganizationByNameAsync(string organizationName, CancellationToken token)
        {
            if (string.IsNullOrEmpty(organizationName))
            {
                throw new ArgumentNullException(nameof(organizationName));
            }

            return await _organizationDataAdapter.GetEventsForOrganizationByNameAsync(organizationName, token);
        }

        public async Task<List<OrganizationIdGETEvent>> GetEventsForOrganizationByIdAsync(Guid organizationId, CancellationToken token)
        {
            if (organizationId == null || organizationId == Guid.Empty)
            {
                throw new ArgumentException(nameof(organizationId));
            }

            return await _organizationDataAdapter.GetEventsForOrganizationByIdAsync(organizationId, token);
        }

        public async Task<List<EventVolunteer>> GetVolunteersForEventsAsync(Guid organizationId, CancellationToken token)
        {
            if (organizationId == null || organizationId == Guid.Empty)
            {
                throw new ArgumentException(nameof(organizationId));
            }

            return await _organizationDataAdapter.GetVolunteersForEventsAsync(organizationId, token);
        }
    }
}