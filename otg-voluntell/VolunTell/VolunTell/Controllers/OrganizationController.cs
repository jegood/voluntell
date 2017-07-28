using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using VolunTell.DataAdapterContracts;
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
        public async Task<List<OrganizationGET>> GetOrganizationsAsync(CancellationToken token)
        {
            var result = await _organizationService.GetOrganizationsAsync(token);

            if (result == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }

            List<OrganizationGET> organizations = new List<OrganizationGET>();

            foreach(OrganizationGET getOrganization in result)
            {
                OrganizationGET newOrganization = new OrganizationGET();
                newOrganization.Name = getOrganization.Name;
                organizations.Add(newOrganization);
            }

            return organizations;
        }

        /// <summary>
        /// Returns a list of events for the given organization by name.
        /// </summary>
        /// <param name="organization"></param>
        /// <returns>A list of events for the given organization.</returns>
        [HttpGet]
        [Route("nonprofits/{nonprofitName}/events")]
        public async Task<List<OrganizationNameGETEvent>> GetEventsForOrganizationByNameAsync(string organizationName, CancellationToken token)
        {
            var result = await _organizationService.GetEventsForOrganizationByNameAsync(organizationName, token);

            if (result == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }

            List<OrganizationNameGETEvent> organizationEvents = new List<OrganizationNameGETEvent>();

            foreach(OrganizationNameGETEvent organizationEvent in result)
            {
                OrganizationNameGETEvent newEvent = new OrganizationNameGETEvent();
                newEvent.Id = organizationEvent.Id;
                newEvent.Name = organizationEvent.Name;
                organizationEvents.Add(newEvent);
            }

            return organizationEvents;
        }

        /// <summary>
        /// Returns a list of events for the given organization by Id.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("nonprofits/{nonprofitId}/events/")]
        public async Task<List<OrganizationIdGETEvent>> GetEventsForOrganizationByIdAsync(Guid organizationId, CancellationToken token)
        {
            var result = await _organizationService.GetEventsForOrganizationByIdAsync(organizationId, token);

            if (result == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }

            List<OrganizationIdGETEvent> organizationEvents = new List<OrganizationIdGETEvent>();

            foreach(OrganizationIdGETEvent organizationEvent in result)
            {
                OrganizationIdGETEvent getEvent = new OrganizationIdGETEvent();
                getEvent.Id = organizationEvent.Id;
                getEvent.Name = organizationEvent.Name;
                getEvent.DateTime = organizationEvent.DateTime;
                organizationEvents.Add(getEvent);
            }

            return organizationEvents;
        }

        /// <summary>
        /// Returns a list of volunteers across all events for this organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns>A list of volunteers across all events.</returns>
        [HttpGet]
        [Route("nonprofits/{nonprofitId}/volunteers")]
        public async Task<List<EventVolunteer>> GetVolunteersForEventsAsync(Guid organizationId, CancellationToken token)
        {
            var result = await _organizationService.GetVolunteersForEventsAsync(organizationId, token);

            if (result == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }

            List<EventVolunteer> eventVolunteers = new List<EventVolunteer>();

            foreach(EventVolunteer volunteer in result)
            {
                EventVolunteer eventVolunteer = new EventVolunteer();
                eventVolunteer.Id = volunteer.Id;
                eventVolunteer.First = volunteer.First;
                eventVolunteer.Last = volunteer.Last;
                eventVolunteer.EmailAddress = volunteer.EmailAddress;
                eventVolunteer.Hours = volunteer.Hours;
                eventVolunteer.Connections = volunteer.Connections;
                eventVolunteer.AvalancheHours = volunteer.AvalancheHours;
                eventVolunteers.Add(eventVolunteer);
            }
            
            return eventVolunteers;
        }
    }
}