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
    public class myadsController : ApiController
    {
        // GET: api/myads
        public IEnumerable<myads> Get(int id)
        {
            myAdsManager myAdsMgr = new myAdsManager();
            // DataTable dt = new DataTable();
            DataTable dt = myAdsMgr.GetMyAds(id);

            var ad = new List<myads>();
            // IEnumerable<advertisement> ConvertToAdvertisement(DataTable dt)
            // {
            foreach (DataRow row in dt.Rows)
                {
                    var myads = new myads
                    {
                        ConsumerID = Convert.ToInt32(row["consumerID"]),
                        AdId = Convert.ToInt32(row["adId"]),
                        AdUrl = row["adURL"].ToString(),
                        AdPcc = row["adPCC"].ToString(),
                        AdTitle = row["adTitle"].ToString(),
                        AdDescription = row["adDescription"].ToString(),
                        AdOwner = row["adOwner"].ToString(),
                        CouponID = Convert.ToInt32(row["couponID"]),
                        CouponTitle = row["couponTitle"].ToString(),
                        CouponDescription = row["couponDescription"].ToString(),
                        CouponValue = row["couponValue"].ToString(),
                        AdCampId = row["adCampID"].ToString()
                    };

                ad.Add(myads);

            }
            return ad.AsEnumerable();

            // }
        }
    }
}
