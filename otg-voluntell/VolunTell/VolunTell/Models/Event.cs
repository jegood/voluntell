using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunTell.Models
{
    public class Event
    {
        /// <summary>
        /// The global identifier for this event.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of this event.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The email address corresponding to the volunteering user.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The total number of hours volunteered.
        /// </summary>
        public int Hours { get; set; }

        /// <summary>
        /// The total number of referred connections to this event.
        /// </summary>
        public int Connections { get; set; }

        /// <summary>
        /// The time of event registration.
        /// </summary>
        public DateTime RegistrationTime { get; set; }
    }
}