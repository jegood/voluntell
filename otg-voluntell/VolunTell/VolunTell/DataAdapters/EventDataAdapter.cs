using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VolunTell.IDataAdapters;
using VolunTell.Models;
using Blackbaud.DataAccess.SqlUtility;
using System.Threading;
using System.Data;

namespace VolunTell
{
    public class EventDataAdapter : IEventDataAdapter
    {
        public async Task<Guid> AddEventAsync(Event Data, CancellationToken token)
        {

            return await SqlHelper.GetScalarAsync<Guid>(token, (cmd) =>
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "dbo.USP_STORE_EVENT";
                cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 100).Value = Data.Name;
                cmd.Parameters.Add("@USERID", SqlDbType.NVarChar, 100).Value = Data.UserId;
                cmd.Parameters.Add("@ORGNAME", SqlDbType.NVarChar, 100).Value = Data.OrganizationId;
                cmd.Parameters.Add("@CONNECTIONS", SqlDbType.Int).Value = 0;
            });
        }

        public async Task<List<Volunteer>> GetVolunteersForEventAsync(Guid eventId, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}