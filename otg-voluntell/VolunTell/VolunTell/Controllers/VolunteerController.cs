using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
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

        #region GET
        
        // This may not be needed
        //public Task<> Get

        #endregion GET

    }
}