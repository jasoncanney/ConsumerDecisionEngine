using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenAdxCDE.Source.Model.Services;
using System.Threading.Tasks;
using GenAdxCDE.Source.Model.Domain;
using GenAdxCDE.Source.Model.Services.adservice;
using System.Data;

namespace GenAdxCDE.Source.Model.Business
{
    public class adManager : ManagerSuperType
    {
        /// <summary>
        /// Business use case for "store advertisement"
        /// </summary>
        /// <param name="c"></param>
        public bool Create(advertisement a)
        {
            Factory factory = Factory.GetInstance();
            IAdSvc adSvc = (IAdSvc)factory.getService("IAdSvc");
            adSvc.storeAdvertisement(a);
            return true;

        }

        /// <summary>
        /// Business use case for "retrieve advertisement"
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable Find()
        {
            Factory factory = Factory.GetInstance();
            IAdSvc adSvc = (IAdSvc)factory.getService("IAdSvc");
            return adSvc.getAdvertisement();
        }

        /// <summary>
        /// Business use case for "update advertisement"
        /// </summary>
        /// <param name="c"></param>
        public bool Update(advertisement c)
        {
            Factory factory = Factory.GetInstance();
            IAdSvc adSvc = (IAdSvc)factory.getService("IAdSvc");
            adSvc.updateAdvertisement(c);
            return true;

        }

        /// <summary>
        /// Business use case for "delete advertisement"
        /// </summary>
        /// <param name="c"></param>
        public bool Delete(advertisement c)
        {
            Factory factory = Factory.GetInstance();
            IAdSvc adSvc = (IAdSvc)factory.getService("IAdSvc");
            adSvc.deleteAdvertisement(c);
            return true;
        }

    }
}
