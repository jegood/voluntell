using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunTell.Models
{
    public class Organization
    {
        /// <summary>
        /// The organization's Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Name of this Organization.
        /// </summary>
        public string Name { get; set; }
    }
}