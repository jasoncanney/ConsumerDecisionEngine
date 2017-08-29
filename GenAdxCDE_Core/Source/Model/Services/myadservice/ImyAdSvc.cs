using System;
using System.Collections.Generic;
using GenAdxCDE.Source.Model.Domain;
using System.Data;

namespace GenAdxCDE.Source.Model.Services.myadservice
{
    /// <summary>
    /// This interface defines methods for persisting of myads.cs
    /// to and from a file system
    /// @author Jason L. Canney </summary>
    /// <param name="NAME"> is a string used to identify the service
    ///  </param>
    public interface ImyAdSvc : IService
    {


        /// <summary>
        /// Retrieves a advertisement
        /// The getmyAds takes an ID as an argument and retrieves it through the myAdSvcSQLImpl class </summary>
        /// <param name="none"> The unique identifier for the myads datatable to be retrieved </param>
        /// <returns> The collection </returns>
        /// <exception cref="AdvertisementException"> </exception>
        /// <exception cref="ClassNotFoundException">  </exception>

        DataTable getmyAds(int id);

       
    }
}