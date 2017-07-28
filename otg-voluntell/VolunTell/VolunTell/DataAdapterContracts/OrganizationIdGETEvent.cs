using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunTell.DataAdapterContracts
{
    public class OrganizationIdGETEvent
    {
        /// <summary>
        /// The event Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the event.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The registration time for the event.
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}