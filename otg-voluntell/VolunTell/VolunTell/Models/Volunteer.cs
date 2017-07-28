using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunTell.Models
{
    public class Volunteer
    {
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
        /// Total number of volunterering hours.
        /// </summary>
        public int Hours { get; set; }

        /// <summary>
        /// The referrer form id.
        /// </summary>
        public Guid ReferralId { get; set; }
    }
}