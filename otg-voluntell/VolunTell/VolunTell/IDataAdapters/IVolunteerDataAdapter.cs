using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using VolunTell.Models;

namespace VolunTell.IDataAdapters
{
    public interface IVolunteerDataAdapter
    {
        /// <summary>
        /// Adds a new volunteer to the database
        /// </summary>
        /// <param name="volunteer">The volunteer to add</param>
        /// <returns>A unique event id for the volunteer</returns>
       Task<Guid> AddVolunteerAsync(Volunteer volunteer, CancellationToken token);
    }
}