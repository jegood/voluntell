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
    public class OrganizationController
    {

        #region Fields

        private OrganizationService _organizationService;
        
        #endregion Fields

        public OrganizationController(OrganizationService organizationService, CancellationToken token)
        {
            if (organizationService == null)
            {
                throw new ArgumentNullException(nameof(organizationService));
            }

            _organizationService = organizationService;
        }

        /// <summary>
        /// Returns a list of organizations.
        /// </summary>
        /// <returns>A list of organizations.</returns>
        [HttpGet]
        [Route("nonprofits")]
        public async Task<List<Organization>> GetOrganizationsAsync(CancellationToken token)
        {
            var result = await _organizationService.GetOrganizationsAsync(token);

            if (result == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }

            return result;
        }

        /// <summary>
        /// Returns a list of events for the given organization by name.
        /// </summary>
        /// <param name="organization"></param>
        /// <returns>A list of events for the given organization.</returns>
        [HttpGet]
        [Route("nonprofits/{nonprofitName}/events")]
        public async Task<List<Event>> GetEventsForOrganizationByNameAsync(string organizationName, CancellationToken token)
        {
            var result = await _organizationService.GetEventsForOrganizationByNameAsync(organizationName, token);

            if (result == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }

            return result;
        }

        /// <summary>
        /// Returns a list of events for the given organization by Id.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("nonprofits/{nonprofitId}/events/")]
        public async Task<List<Event>> GetEventsForOrganizationByIdAsync(Guid organizationId, CancellationToken token)
        {
            var result = await _organizationService.GetEventsForOrganizationByIdAsync(organizationId, token);

            if (result == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }

            return result;
        }

        /// <summary>
        /// Returns a list of volunteers across all events for this organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns>A list of volunteers across all events.</returns>
        [HttpGet]
        [Route("nonprofits/{nonprofitId}/volunteers")]
        public async Task<Volunteer> GetVolunteersForEventsAsync(Guid organizationId, CancellationToken token)
        {
            var result = await _organizationService.GetVolunteersForEventsAsync(organizationId, token);

            if (result == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }

            return result;
        }
    }
}