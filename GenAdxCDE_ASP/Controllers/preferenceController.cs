using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GenAdxCDE.Source.Model.Domain;
using GenAdxCDE.Source.Model.Business;
using MySql.Data;

namespace GenAdx_REST.Controllers
{
    public class preferenceController : ApiController
    {
        // GET: api/preference
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/preference/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/preference
        public HttpResponseMessage Post([FromBody]preference value)
        {
            preference preference = new GenAdxCDE.Source.Model.Domain.preference()
            {
                PreferenceId = value.PreferenceId,
                PreferenceGsSegment = value.PreferenceGsSegment,
                PreferenceCaTypeCode = value.PreferenceCaTypeCode,
                PreferenceCaValueCode = value.PreferenceCaValueCode,
                PreferenceBrandOwner = value.PreferenceBrandOwner,
                PreferenceProductDesc = value.PreferenceProductDesc,
                PreferenceDate = value.PreferenceDate,
                ConsumerId = value.ConsumerId
            };
            preferenceManager pMgr = new preferenceManager();
            pMgr.Create(preference);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            // couponManager ConIDMgr = new couponManager();

            // response.Headers.Location = new Uri(Request.RequestUri , String.Format("{0}", ConIDMgr.whatIsConsumerID(value.ConsumerSocEmail)) );
            return response;

        }

        // PUT: api/preference/5
        public void Put(int id, [FromBody]preference value)
        {
        }

        // DELETE: api/preference/5
        public void Delete(int id)
        {
        }
    }
}
