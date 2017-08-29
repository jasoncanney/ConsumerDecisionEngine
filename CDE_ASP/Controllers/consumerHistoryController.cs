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
    public class consumerHistoryController : ApiController
    {
        // GET: api/consumerHistory
        public IEnumerable<string> Get()
        {
            return new string[] { "Not a use case for consumerHistory", "Not Implemented" };
        }

        // GET: api/consumerHistory/5
        public consumerHistory Get(int id)
        {
            consumerHistory con = new consumerHistory();
            consumerHistoryManager ConMgr = new consumerHistoryManager();
            con = ConMgr.Get(id);
            return con;
        }

        // POST: api/consumerHistory
        public HttpResponseMessage Post([FromBody]consumerHistory value)
        {
            consumerHistory consumerHistory = new GenAdxCDE.Source.Model.Domain.consumerHistory()
            {
                ConsumerID = value.ConsumerID,
                PreferenceID = value.PreferenceID,
                PreferenceDate = value.PreferenceDate,
                PreferenceChoice = value.PreferenceChoice,
                AdvertisementID = value.AdvertisementID,
                CouponID = value.CouponID
            };
            consumerHistoryManager cHistMgr = new consumerHistoryManager();
            cHistMgr.Create(consumerHistory);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("consumerHistory/{0}", value.ConsumerID));
            return response;

        }

        // PUT: api/consumerHistory/5
        public HttpResponseMessage Put(int id, [FromBody]consumerHistory value)
        {
            consumerHistory consumerHistory = new GenAdxCDE.Source.Model.Domain.consumerHistory()
            {
                ConsumerID = value.ConsumerID,
                PreferenceID = value.PreferenceID,
                PreferenceDate = value.PreferenceDate,
                PreferenceChoice = value.PreferenceChoice,
                AdvertisementID = value.AdvertisementID,
                CouponID = value.CouponID
            };
            consumerHistoryManager cHistMgr = new consumerHistoryManager();
            cHistMgr.Create(consumerHistory);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("consumer/{0}", value.ConsumerID));
            return response;

        }

        // DELETE: api/consumerHistory/5
        public HttpResponseMessage Delete(int id)
        {
            consumerHistory con = new consumerHistory();
            con.ConsumerID = id;
            consumerHistoryManager cHistMgr = new consumerHistoryManager();
            cHistMgr.Delete(con);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;


        }
    }
}
