using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using VolunTell.Models;

namespace VolunTell.IDataAdapters
{
    public interface IOrganizationDataAdapter
    {
        /// <summary>
        /// Returns a list of organizations.
        /// </summary>
        /// <returns>A list of organizations.</returns>
        Task<List<Organization>> GetOrganizationsAsync(CancellationToken token);

        /// <summary>
        /// Returns a list of events for the given organization by name.
        /// </summary>
        /// <param name="organization"></param>
        /// <returns>A list of events for the given organization.</returns>
        Task<List<Event>> GetEventsForOrganizationByNameAsync(string organizationName, CancellationToken token);


        /// <summary>
        /// Returns a list of events for the given organization by Id.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        Task<List<Event>> GetEventsForOrganizationByIdAsync(Guid organizationId, CancellationToken token);

        /// <summary>
        /// Returns a list of volunteers across all events for this organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns>A list of volunteers across all events.</returns>
        Task<Volunteer> GetVolunteersForEventsAsync(Guid organizationId, CancellationToken token);
    }
}