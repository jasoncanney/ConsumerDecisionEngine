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
    public class couponController : ApiController
    {
        // GET: api/coupon
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/coupon/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/coupon
        public HttpResponseMessage Post([FromBody]coupon value)
        {
            coupon coupon = new GenAdxCDE.Source.Model.Domain.coupon()
            {
                CouponID = value.CouponID,
                CouponTitle = value.CouponTitle,
                CouponDescription = value.CouponDescription,
                CouponValue = value.CouponValue,
                CouponStartActive = value.CouponStartActive,
                CouponEndActive = value.CouponEndActive,
                CouponLocationsZip = value.CouponLocationsZip
            };
            couponManager cMgr = new couponManager();
            cMgr.Create(coupon);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            // couponManager ConIDMgr = new couponManager();

            // response.Headers.Location = new Uri(Request.RequestUri , String.Format("{0}", ConIDMgr.whatIsConsumerID(value.ConsumerSocEmail)) );
            return response;
        }

        // PUT: api/coupon/5
        public void Put(int id, [FromBody]coupon value)
        {

        }

        // DELETE: api/coupon/5
        public void Delete(int id)
        {
        }
    }
}
