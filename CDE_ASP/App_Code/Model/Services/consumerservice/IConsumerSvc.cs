using System;
using System.Collections.Generic;
using GenAdxCDE.Source.Model.Domain;
using System.Data;

namespace GenAdxCDE.Source.Model.Services.consumerservice
{
    /// <summary>
    /// This interface defines methods for persisting of consumer.cs
    /// to and from a file system
    /// @author Jason L. Canney </summary>
    /// <param name="NAME"> is a string used to identify the service
    ///  </param>
    public interface IConsumerSvc : IService
    {

        /// <summary>
        /// Persists a consumer
        /// The storeConsumer takes in a consumer object as input and will pass it to the ConsumerSvcImpl </summary>
        /// <param name="consumer"> The application to be persisted </param>
        /// <returns> void </returns>
        /// <exception cref="ConsumerException">  </exception>

        void storeConsumer(consumer consumer);

        /// <summary>
        /// Retrieves a consumer
        /// The getConsumer takes an ID as an argument and retrieves it through the ConsumerSvcImpl class </summary>
        /// <param name="none"> The unique identifier for the consumer to be retrieved </param>
        /// <returns> The collection </returns>
        /// <exception cref="ConsumerException"> </exception>
        /// <exception cref="ClassNotFoundException">  </exception>

        DataTable getConsumer();

        /// <summary>
        /// Updates a consumer
        /// The updateConsumer takes in a consumer object as input and will pass it to the ConsumerSvcImpl </summary>
        /// <param name="consumer"> The consumer to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="ConsumerException">  </exception>

        void updateConsumer(consumer consumer);

        /// <summary>
        /// delete a consumer
        /// The deleteConsumer takes in a consumer object as input and will pass it to the ConsumerSvcImpl </summary>
        /// <param name="consumer"> The consumer to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="ConsumerException">  </exception>

        void deleteConsumer(consumer consumer);



        /*
		ISet<consumer> Consumer {get;}

	}

	public static class IConsumerSvc_Fields

	{
		public const string NAME = "IConsumerSvc";
	}
    */
    }
}