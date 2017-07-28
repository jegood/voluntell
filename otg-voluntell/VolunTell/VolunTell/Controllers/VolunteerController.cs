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
    public class VolunteerController : ApiController
    {
        private VolunteerService _volunteerService;

        public VolunteerController(VolunteerService volunteerService)
        {
            if (volunteerService == null)
            {
                throw new ArgumentNullException(nameof(volunteerService));
            }

            _volunteerService = volunteerService;
        }

        #region Volunteer
        
        /// <summary>
        /// Returns a unique event id for the given volunteer.
        /// </summary>
        /// <param name="volunteer"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("volunteers/add")]
        public async Task<Guid> AddVolunteerAsync(Volunteer volunteer, CancellationToken token)
        {
            return await _volunteerService.AddVolunteerAsync(volunteer, token);
        }

        #endregion Volunteer

    }
}