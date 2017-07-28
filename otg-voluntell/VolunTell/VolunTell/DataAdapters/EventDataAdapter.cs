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

        private SqlHelper _sqlHelper = new SqlHelper("Server=(local);Database=OTGBasic;Integrated Security=SSPI;");
        public async Task<Guid> AddEventAsync(Event Data, CancellationToken token)
        {

            return await _sqlHelper.GetScalarAsync<Guid>(token, (cmd) =>
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.USP_STORE_EVENT";
                cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 100).Value = Data.Name;
                cmd.Parameters.Add("@USERID", SqlDbType.NVarChar, 100).Value = Data.UserId;
                cmd.Parameters.Add("@ORGNAME", SqlDbType.NVarChar, 100).Value = Data.OrganizationId;
                cmd.Parameters.Add("@CONNECTIONS", SqlDbType.Int).Value = 0;
            });
        }

        public async Task<List<Volunteer>> GetVolunteersForEventAsync(Guid eventId, CancellationToken token)
        {
            return await _sqlHelper.GetResultAsync<List<Volunteer>>(token, (cmd) =>
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }, async (reader, cancelToken) =>
            {

                var list = new List<Volunteer>();
                while (await reader.ReadAsync(cancelToken))
                {
                    list.Add(new Volunteer()
                    {
                        /* change this eventually to represent data we are reading.
                        PackageName = reader.GetString(0),
                        Id = reader.GetInt32(1),
                        Enabled = reader.GetBoolean(2),
                        Sequence = reader.GetInt16(3),
                        TimeoutFullLoad = reader.GetInt16(4),
                        TimeoutIncrementalLoad = reader.GetInt16(5)*/
                    });
                }

                return list;
            });

        }
    }
}