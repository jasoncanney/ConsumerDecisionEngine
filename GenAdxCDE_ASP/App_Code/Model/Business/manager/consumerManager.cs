using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenAdxCDE.Source.Model.Services.consumerservice;
using GenAdxCDE.Source.Model.Services;
using System.Threading.Tasks;
using GenAdxCDE.Source.Model.Domain;
using System.Collections;
using System.Data;

namespace GenAdxCDE.Source.Model.Business
{
    public class consumerManager : ManagerSuperType
    {
        /// <summary>
        /// Business use case for "store consumer"
        /// </summary>
        /// <param name="c"></param>
        public bool Create(consumer c)
        {
            Factory factory = Factory.GetInstance();
            IConsumerSvc consSvc = (IConsumerSvc)factory.getService("IConsumerSvc");
            consSvc.storeConsumer(c);
            return true;
        }

        /// <summary>
        /// Business use case for "retrieve consumer"
        /// </summary>
        /// <returns></returns>
        public DataTable Find()
        {
            Factory factory = Factory.GetInstance();
            IConsumerSvc consSvc = (IConsumerSvc)factory.getService("IConsumerSvc");
            return consSvc.getConsumer();
        }

        /// <summary>
        /// Business use case for "update consumer"
        /// </summary>
        /// <param name="c"></param>
        public bool Update(consumer c)
        {
            Factory factory = Factory.GetInstance();
            IConsumerSvc consSvc = (IConsumerSvc)factory.getService("IConsumerSvc");
            consSvc.updateConsumer(c);
            return true;

        }

        /// <summary>
        /// Business use case for "delete consumer"
        /// </summary>
        /// <param name="c"></param>
        public bool Delete(consumer c)
        {
            Factory factory = Factory.GetInstance();
            IConsumerSvc consSvc = (IConsumerSvc)factory.getService("IConsumerSvc");
            consSvc.deleteConsumer(c);
            return true;
        }


    }
}
