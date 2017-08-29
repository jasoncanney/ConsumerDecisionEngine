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
    public class consumerController : ApiController
    {
        // GET: api/consumer
        public IEnumerable<string> Get()
        {
            return new string[] { "Utilize numbered GET", "Request" };
        }

        // GET: api/consumer/5
        public consumer Get(int id)
        {
            consumer con = new consumer();
            consumerManager ConMgr = new consumerManager();
            con = ConMgr.Get(id);
            return con;
        }

        // POST: api/consumer
        public HttpResponseMessage Post([FromBody]consumer value)
        {
            consumer consumer = new GenAdxCDE.Source.Model.Domain.consumer()
            {
                ConsumerID = value.ConsumerID,
                ConsumerFirstName = value.ConsumerFirstName,
                ConsumerMiddleInitial = value.ConsumerMiddleInitial,
                ConsumerLastName = value.ConsumerLastName,
                ConsumerEmail = value.ConsumerEmail,
                ConsumerPhone = value.ConsumerPhone,
                ConsumerAddress = value.ConsumerAddress,
                ConsumerCity = value.ConsumerCity,
                ConsumerState = value.ConsumerState,
                ConsumerZip = value.ConsumerZip,
                ConsumerSocEmail = value.ConsumerSocEmail
            };
            consumerManager ConMgr = new consumerManager();
            ConMgr.Create(consumer);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            consumerManager ConIDMgr = new consumerManager();
            
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("{0}", ConIDMgr.whatIsConsumerID(value.ConsumerSocEmail)));
            return response;
        }

        // PUT: api/consumer/5
        public HttpResponseMessage Put(int id, [FromBody]consumer value)
        {
            consumer consumer = new GenAdxCDE.Source.Model.Domain.consumer()
            {
                ConsumerID = id,
                ConsumerFirstName = value.ConsumerFirstName,
                ConsumerMiddleInitial = value.ConsumerMiddleInitial,
                ConsumerLastName = value.ConsumerLastName,
                ConsumerEmail = value.ConsumerEmail,
                ConsumerPhone = value.ConsumerPhone,
                ConsumerAddress = value.ConsumerAddress,
                ConsumerCity = value.ConsumerCity,
                ConsumerState = value.ConsumerState,
                ConsumerZip = value.ConsumerZip,
                ConsumerSocEmail = value.ConsumerSocEmail
            };
            consumerManager ConMgr = new consumerManager();
            ConMgr.Update(consumer);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("consumer/{0}", value.ConsumerID));
            return response;

        }

        // DELETE: api/consumer/5
        public HttpResponseMessage Delete(int id)
        {
            consumer con = new consumer();
            con.ConsumerID = id;
            consumerManager ConMgr = new consumerManager();
            ConMgr.Delete(con);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;


        }
    }
}
