using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunTell.DataAdapterContracts
{
    public class OrganizationNameGETEvent
    {
        /// <summary>
        /// The unique identifier for this event.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of this event.
        /// </summary>
        public string Name { get; set; }
    }
}