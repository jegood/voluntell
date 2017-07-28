using Blackbaud.DataAccess.SqlUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using VolunTell.IDataAdapters;
using VolunTell.Models;

namespace VolunTell
{
    public class VolunteerDataAdapter : IVolunteerDataAdapter
    {
        private SqlHelper _sqlHelper = new SqlHelper("Server=(local);Database=OTGBasic;Integrated Security=SSPI;");

        public async Task<Guid> AddVolunteerAsync(Volunteer volunteer, CancellationToken token)
        {
            return await _sqlHelper.GetScalarAsync<Guid>(token, (cmd) =>
            {
                // Create parameter with Direction as Output (and correct name and type)
                SqlParameter outputIdParam = new SqlParameter("@NEWID", SqlDbType.BigInt)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.USP_STORE_REGISTRATION";
                cmd.Parameters.Add("@EVENTID", SqlDbType.NVarChar, 100).Value = volunteer.ReferralId;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 100).Value = volunteer.EmailAddress;
                cmd.Parameters.Add("@FIRSTNAME", SqlDbType.NVarChar, 100).Value = volunteer.First;
                cmd.Parameters.Add("@LASTNAME", SqlDbType.NVarChar, 100).Value = volunteer.Last;
                cmd.Parameters.Add("@HOURS", SqlDbType.Int).Value = volunteer.Hours;
                cmd.Parameters.Add(outputIdParam);
            });
        }
    }
}