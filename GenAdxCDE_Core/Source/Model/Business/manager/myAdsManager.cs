using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenAdxCDE.Source.Model.Services;
using System.Threading.Tasks;
using GenAdxCDE.Source.Model.Domain;
using GenAdxCDE.Source.Model.Services.myadservice;
using System.Data;

namespace GenAdxCDE.Source.Model.Business
{
    public class myAdsManager : ManagerSuperType
    {
        
        /// <summary>
        /// Business use case for "retrieve my Ads"
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetMyAds(int id)
        {
            Factory factory = Factory.GetInstance();
            ImyAdSvc myadSvc = (ImyAdSvc)factory.getService("ImyAdSvc");
            return myadSvc.getmyAds(id);
        }

    }
}
