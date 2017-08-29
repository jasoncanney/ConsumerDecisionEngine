﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenAdxCDE.Source.Model.Services.consumerhistoryservice;
using GenAdxCDE.Source.Model.Services;
using System.Threading.Tasks;
using GenAdxCDE.Source.Model.Domain;
using System.Data;

namespace GenAdxCDE.Source.Model.Business
{
    public class consumerHistoryManager : ManagerSuperType
    {
        /// <summary>
        /// Business use case for "store consumerHistory"
        /// </summary>
        /// <param name="c"></param>
        public bool Create(consumerHistory c)
        {
            Factory factory = Factory.GetInstance();
            IConsumerHistorySvc consSvc = (IConsumerHistorySvc)factory.getService("IConsumerHistorySvc");
            consSvc.storeConsumerHistory(c);
            return true;

        }

        /// <summary>
        /// Business use case for "retrieve consumer"
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable Find()
        {
            Factory factory = Factory.GetInstance();
            IConsumerHistorySvc consSvc = (IConsumerHistorySvc)factory.getService("IConsumerHistorySvc");
            return consSvc.getConsumerHistory();
        }

        /// <summary>
        /// Business use case for "update consumerHistory"
        /// </summary>
        /// <param name="c"></param>
        public bool Update(consumerHistory c)
        {
            Factory factory = Factory.GetInstance();
            IConsumerHistorySvc consSvc = (IConsumerHistorySvc)factory.getService("IConsumerHistorySvc");
            consSvc.updateConsumerHistory(c);
            return true;

        }

        /// <summary>
        /// Business use case for "delete consumerHistory"
        /// </summary>
        /// <param name="c"></param>
        public bool Delete(consumerHistory c)
        {
            Factory factory = Factory.GetInstance();
            IConsumerHistorySvc consSvc = (IConsumerHistorySvc)factory.getService("IConsumerHistorySvc");
            consSvc.deleteConsumerHistory(c);
            return true;
        }




    }
}
