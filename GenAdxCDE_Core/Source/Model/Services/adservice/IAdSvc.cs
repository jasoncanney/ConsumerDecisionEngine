using System;
using System.Collections.Generic;
using GenAdxCDE.Source.Model.Domain;
using System.Data;

namespace GenAdxCDE.Source.Model.Services.adservice
{
    /// <summary>
    /// This interface defines methods for persisting of advertisement.cs
    /// to and from a file system
    /// @author Jason L. Canney </summary>
    /// <param name="NAME"> is a string used to identify the service
    ///  </param>
    public interface IAdSvc : IService
    {

        /// <summary>
        /// Persists a advertisement
        /// The storeAdvertisement takes in a advertisement object as input and will pass it to the AdSvcSQLImpl </summary>
        /// <param name="advertisement"> The application to be persisted </param>
        /// <returns> boolean true/false </returns>
        /// <exception cref="AdvertisementException">  </exception>

        void storeAdvertisement(advertisement advertisement);

        /// <summary>
        /// Retrieves a advertisement
        /// The getAdvertisement takes an ID as an argument and retrieves it through the AdvertisementSvcSQLImpl class </summary>
        /// <param name="none"> The unique identifier for the advertisement to be retrieved </param>
        /// <returns> The collection </returns>
        /// <exception cref="AdvertisementException"> </exception>
        /// <exception cref="ClassNotFoundException">  </exception>

        DataTable getAdvertisement();

        /// <summary>
        /// Updates a consumer
        /// The updateadvertisement takes in a advertisement object as input and will pass it to the advertisementSvcImpl </summary>
        /// <param name="advertisement"> The advertisement to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="ConsumerException">  </exception>

        void updateAdvertisement(advertisement advertisement);

        /// <summary>
        /// delete a consumer
        /// The deleteConsumer takes in a advertisement object as input and will pass it to the advertisementSvcImpl </summary>
        /// <param name="advertisement"> The advertisement to be deleted</param>
        /// <returns> void </returns>
        /// <exception cref="ConsumerException">  </exception>

        void deleteAdvertisement(advertisement advertisement);
    }
}