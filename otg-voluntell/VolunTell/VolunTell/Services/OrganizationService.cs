using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
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

        public async Task<List<Organization>> GetOrganizationsAsync()
        {
            return await _organizationDataAdapter.GetOrganizationAsync();
        }

        public async Task<List<Event>> GetEventsForOrganizationByNameAsync(string organizationName)
        {
            if (string.IsNullOrEmpty(organizationName))
            {
                throw new ArgumentNullException(nameof(organizationName));
            }

            return await _organizationDataAdapter.GetEventsForOrganizationByNameAsync(organizationName);
        }

        public async Task<List<Event>> GetEventsForOrganizationByIdAsync(Guid organizationId)
        {
            if (organizationId == null || organizationId == Guid.Empty)
            {
                throw new ArgumentException(nameof(organizationId));
            }

            return await _organizationDataAdapter.GetEventsForOrganizationIdAsync(organizationId);
        }

        public async Task<Volunteer> GetVolunteersForEventsAsync(Guid organizationId)
        {
            if (organizationId == null || organizationId == Guid.Empty)
            {
                throw new ArgumentException(nameof(organizationId));
            }

            return await _organizationDataAdapter.GetVolunteersForEventsAsync(organizationId);
        }
    }
}