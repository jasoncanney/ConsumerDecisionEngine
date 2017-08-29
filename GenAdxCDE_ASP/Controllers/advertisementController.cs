using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GenAdxCDE.Source.Model.Domain;
using GenAdxCDE.Source.Model.Business;
using MySql.Data;
using System.Data;

namespace GenAdx_REST.Controllers
{
    public class advertisementController : ApiController
    {
        // GET: api/advertisement
        public IEnumerable<advertisement> Get()
        {
            adManager AdMgr = new adManager();
            // DataTable dt = new DataTable();
            DataTable dt = AdMgr.Find();

            var ad = new List<advertisement>();
            // IEnumerable<advertisement> ConvertToAdvertisement(DataTable dt)
            // {
            foreach (DataRow row in dt.Rows)
                {
                    var advertisement = new advertisement
                    {
                        adId = Convert.ToInt32(row["adId"]),
                        adTitle = row["adTitle"].ToString(),
                        adDemo01 = Convert.ToInt32(row["adDemo01"]),
                        adDemo02 = Convert.ToInt32(row["adDemo02"]),
                        adDemo03 = Convert.ToInt32(row["adDemo03"]),
                        adDemo04 = Convert.ToInt32(row["adDemo04"]),
                        adDescription = row["adDescription"].ToString(),
                        adOwner = row["adOwner"].ToString(),
                        adBrand = row["adBrand"].ToString(),
                        adPcc = row["adPCC"].ToString(),
                        adUrl = row["adURL"].ToString(),
                        adCampId = row["adCampID"].ToString()
                    };
                ad.Add(advertisement);

            }
            return ad.AsEnumerable();

            // }
        }

        // GET: api/advertisement/5
        public string Get(int id)
        {
            return "not a use case for this application";
        }

        // POST: api/advertisement
        public HttpResponseMessage Post([FromBody]advertisement value)
        {
            advertisement advertisement = new GenAdxCDE.Source.Model.Domain.advertisement()
            {
                adId = value.adId,
                adTitle = value.adTitle,
                adDemo01 = value.adDemo01,
                adDemo02 = value.adDemo02,
                adDemo03 = value.adDemo03,
                adDemo04 = value.adDemo04,
                adDescription = value.adDescription,
                adOwner = value.adOwner,
                adBrand = value.adBrand,
                adPcc = value.adPcc,
                adUrl = value.adUrl,
                adCampId = value.adCampId
            };

            adManager adMgr = new adManager();
            adMgr.Create(advertisement);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("advertisement/{0}", value.adId));
            return response;

        }

        // PUT: api/advertisement/5
        public HttpResponseMessage Put(int id, [FromBody]advertisement value)
        {
            advertisement advertisement = new GenAdxCDE.Source.Model.Domain.advertisement()
            {
                adId = value.adId,
                adTitle = value.adTitle,
                adDemo01 = value.adDemo01,
                adDemo02 = value.adDemo02,
                adDemo03 = value.adDemo03,
                adDemo04 = value.adDemo04,
                adDescription = value.adDescription,
                adOwner = value.adOwner,
                adBrand = value.adBrand,
                adPcc = value.adPcc,
                adUrl = value.adUrl,
                adCampId = value.adCampId
            };

            adManager adMgr = new adManager();
            adMgr.Create(advertisement);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, String.Format("advertisement/{0}", value.adId));
            return response;

        }

        // DELETE: api/advertisement/5
        public HttpResponseMessage Delete(int id)
        {
            advertisement ad = new advertisement();
            ad.adId = id;
            adManager AdMgr = new adManager();
            AdMgr.Delete(ad);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;

        }
    }
}
