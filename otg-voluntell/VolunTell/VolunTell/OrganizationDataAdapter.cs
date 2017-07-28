﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VolunTell.Models;

namespace VolunTell
{
    public class OrganizationDataAdapter
    {
        /// <summary>
        /// Returns a list of organizations.
        /// </summary>
        /// <returns>A list of organizations.</returns>
        public async Task<List<Organization>> GetOrganizationsAsync()
        {
            throw new NotImplementedException();
            //return organizations;
        }

        // <summary>
        /// Returns a list of events for the given organization by name.
        /// </summary>
        /// <param name="organization"></param>
        /// <returns>A list of events for the given organization.</returns>
        public async Task<List<Event>> GetEventsForOrganizationByNameAsync(string organizationName)
        {
            throw new NotImplementedException();
            //return events;
        }

        /// <summary>
        /// Returns a list of events for the given organization by Id.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        public async Task<List<Event>> GetEventsForOrganizationByIdAsync(Guid organizationId)
        {
            throw new NotImplementedException();
            //return events;
        }

        /// <summary>
        /// Returns a list of volunteers across all events for this organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns>A list of volunteers across all events.</returns>
        public async Task<Volunteer> GetVolunteersForEventsAsync(Guid organizationId)
        {
            throw new NotImplementedException();
            // return volunteers;
        }
    }
}