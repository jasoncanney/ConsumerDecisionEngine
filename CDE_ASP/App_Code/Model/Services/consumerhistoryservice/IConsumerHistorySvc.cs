using System;
using System.Collections.Generic;
using GenAdxCDE.Source.Model.Domain;
using System.Data;

namespace GenAdxCDE.Source.Model.Services.consumerhistoryservice
{
    /// <summary>
    /// This interface defines methods for persisting of consumerhistory.cs
    /// to and from a file system
    /// @author Jason L. Canney </summary>
    /// <param name="NAME"> is a string used to identify the service
    ///  </param>
    public interface IConsumerHistorySvc : IService
    {

        /// <summary>
        /// Persists a consumerHistory
        /// The storeConsumerHistory takes in a consumerhistory object as input and will pass it to the ConsumerHistorySvcImpl </summary>
        /// <param name="consumerhistory"> The consumerhistory to be persisted </param>
        /// <returns> boolean true/false </returns>
        /// <exception cref="ConsumerHistoryException">  </exception>

        void storeConsumerHistory(consumerHistory consumerHistory);

        /// <summary>
        /// Retrieves a consumerHistory
        /// The getConsumerHistory takes an ID as an argument and retrieves it through the ConsumerSvcImpl class </summary>
        /// <param name="none"> The unique identifier for the consumer to be retrieved </param>
        /// <returns> The collection </returns>
        /// <exception cref="ConsumerHistoryException"> </exception>
        /// <exception cref="ClassNotFoundException">  </exception>

        DataTable getConsumerHistory();

        /// <summary>
        /// Updates a consumer
        /// The updateConsumerHistory takes in a consumerHistory object as input and will pass it to the ConsumerHistorySvcImpl </summary>
        /// <param name="consumerHistory"> The consumerHistory to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="ConsumerException">  </exception>

        void updateConsumerHistory(consumerHistory consumerHistory);

        /// <summary>
        /// delete a consumerHistory
        /// The deleteConsumerHistory takes in a consumerHistory object as input and will pass it to the ConsumerHistorySvcImpl </summary>
        /// <param name="consumerHistory"> The consumerHistory to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="ConsumerException">  </exception>

        void deleteConsumerHistory(consumerHistory consumerHistory);
    }
}