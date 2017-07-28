using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunTell.DataAdapterContracts
{
    public class EventVolunteer
    {
        /// <summary>
        /// The event id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The volunteer's first name.
        /// </summary>
        public string First { get; set; }

        /// <summary>
        /// The volunteer's last name.
        /// </summary>
        public string Last { get; set; }

        /// <summary>
        /// The volunteer's email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The volunteer's hours for this event.
        /// </summary>
        public int Hours { get; set; }

        /// <summary>
        /// The volunteer's total connections.
        /// </summary>
        public int Connections { get; set; }

        /// <summary>
        /// The volunteer's avalanche hours.
        /// </summary>
        public int AvalancheHours { get; set; }
    }
}