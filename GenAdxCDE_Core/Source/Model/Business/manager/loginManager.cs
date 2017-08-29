using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenAdxCDE.Source.Model.Services.loginservice;
using GenAdxCDE.Source.Model.Services;
using System.Threading.Tasks;
using GenAdxCDE.Source.Model.Domain;
using System.Collections;
using System.Data;

namespace GenAdxCDE.Source.Model.Business
{
    public class loginManager : ManagerSuperType
    {
        /// <summary>
        /// Business use case for "store login"
        /// </summary>
        /// <param name="c"></param>
        public bool Create(login c)
        {
            Factory factory = Factory.GetInstance();
            ILoginSvc consSvc = (ILoginSvc)factory.getService("ILoginSvc");
            consSvc.storeLogin(c);
            return true;
        }

        /// <summary>
        /// Business use case for "retrieve login"
        /// </summary>
        /// <returns></returns>
        public DataTable Find()
        {
            Factory factory = Factory.GetInstance();
            ILoginSvc consSvc = (ILoginSvc)factory.getService("ILoginSvc");
            return consSvc.findLogin();
        }

        /// <summary>
        /// Business use case for "retrieve userName"
        /// </summary>
        /// <returns></returns>
        public string whatIsLoginID(string username)
        {
            Factory factory = Factory.GetInstance();
            ILoginSvc consSvc = (ILoginSvc)factory.getService("ILoginSvc");
            return consSvc.whatIsLoginID(username);
        }

        /// <summary>
        /// Business use case for "retrieve single login"
        /// </summary>
        /// <returns>login</returns>
        public login Get(int id)
        {
            Factory factory = Factory.GetInstance();
            ILoginSvc consSvc = (ILoginSvc)factory.getService("ILoginSvc");
            return consSvc.getLogin(id);
        }

        /// <summary>
        /// Business use case for "verify login"
        /// </summary>S
        /// <param name="c"></param>
        public bool Verify(login c)
        {
            Factory factory = Factory.GetInstance();
            ILoginSvc consSvc = (ILoginSvc)factory.getService("ILoginSvc");
            return consSvc.verifyLogin(c);
            // return true;
        }


        /// <summary>
        /// Business use case for "update login"
        /// </summary>S
        /// <param name="c"></param>
        public bool Update(login c)
        {
            Factory factory = Factory.GetInstance();
            ILoginSvc consSvc = (ILoginSvc)factory.getService("ILoginSvc");
            consSvc.updateLogin(c);
            return true;

        }

        /// <summary>
        /// Business use case for "delete login"
        /// </summary>
        /// <param name="c"></param>
        public bool Delete(login c)
        {
            Factory factory = Factory.GetInstance();
            ILoginSvc consSvc = (ILoginSvc)factory.getService("ILoginSvc");
            consSvc.deleteLogin(c);
            return true;
        }


    }
}
