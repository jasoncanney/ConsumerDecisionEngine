using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenAdxCDE.Source.Model.Services;
using GenAdxCDE.Source.Model.Services.preferenceservice;
using System.Threading.Tasks;
using GenAdxCDE.Source.Model.Domain;
using System.Data;

namespace GenAdxCDE.Source.Model.Business
{
    public class preferenceManager : ManagerSuperType
    {
        /// <summary>
        /// Business use case for "store preference"
        /// </summary>
        /// <param name="c"></param>
        public bool Create(preference c)
        {
            Factory factory = Factory.GetInstance();
            IPreferenceSvc prefsSvc = (IPreferenceSvc)factory.getService("IPreferenceSvc");
            prefsSvc.storePreference(c);
            return true;
        }

        /// <summary>
        /// Business use case for "retrieve preference"
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable Find()
        {
            Factory factory = Factory.GetInstance();
            IPreferenceSvc prefsSvc = (IPreferenceSvc)factory.getService("IPreferenceSvc");
            return prefsSvc.getPreference();
        }

        /// <summary>
        /// Business use case for "update coupon"
        /// </summary>
        /// <param name="c"></param>
        public bool Update(preference c)
        {
            Factory factory = Factory.GetInstance();
            IPreferenceSvc prefSvc = (IPreferenceSvc)factory.getService("IPreferenceSvc");
            prefSvc.updatePreference(c);
            return true;

        }

        /// <summary>
        /// Business use case for "delete coupon"
        /// </summary>
        /// <param name="c"></param>
        public bool Delete(preference c)
        {
            Factory factory = Factory.GetInstance();
            IPreferenceSvc prefSvc = (IPreferenceSvc)factory.getService("IPreferenceSvc");
            prefSvc.deletePreference(c);
            return true;
        }

    }
}
