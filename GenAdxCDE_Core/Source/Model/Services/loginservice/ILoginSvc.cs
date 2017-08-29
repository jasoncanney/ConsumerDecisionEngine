using System;
using System.Collections.Generic;
using GenAdxCDE.Source.Model.Domain;
using System.Data;

namespace GenAdxCDE.Source.Model.Services.loginservice
{
    /// <summary>
    /// This interface defines methods for persisting of login.cs
    /// to and from a file system
    /// @author Jason L. Canney </summary>
    /// <param name="NAME"> is a string used to identify the service
    ///  </param>
    public interface ILoginSvc : IService
    {

        /// <summary>
        /// Persists a login
        /// The storeLogin takes in a login object as input and will pass it to the LoginSvcImpl </summary>
        /// <param name="login"> The login to be persisted </param>
        /// <returns> void </returns>
        /// <exception cref="LoginException">  </exception>

        void storeLogin(login login);

        /// <summary>
        /// Retrieves a login
        /// The findLogin takes a Login as an argument and retrieves it through the LoginSvcImpl class </summary>
        /// <param name="none"> The unique identifier for the login to be retrieved </param>
        /// <returns> The collection </returns>
        /// <exception cref="LoginException"> </exception>
        /// <exception cref="ClassNotFoundException">  </exception>

        DataTable findLogin();

        /// <summary>
        /// Retrieves a single login
        /// The getLogin takes login ID as an argument and retrieves it through the LoginSvcImpl class </summary>
        /// <param name="none"> The unique identifier for the login to be retrieved </param>
        /// <returns> The collection </returns>
        /// <exception cref="LoginException"> </exception>
        /// <exception cref="ClassNotFoundException">  </exception>

        login getLogin(int id);

        /// <summary>
        /// Verify a Login
        /// The verifyLogin takes in a login object as input and will pass it to the LoginSvcImpl </summary>
        /// <param name="login"> The password is verified </param>
        /// <returns> void </returns>
        /// <exception cref="LoginException">  </exception>

        bool verifyLogin(login login);


        /// <summary>
        ///  get single login 
        /// The whatIsLoginId takes in a login object as input and will pass it to the LoginSvcImpl </summary>
        /// <param name="login"> The login to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="LoginException">  </exception>

        string whatIsLoginID(string username);

        /// <summary>
        /// Updates a Login
        /// The updateLogin takes in a login object as input and will pass it to the LoginSvcImpl </summary>
        /// <param name="login"> The login to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="LoginException">  </exception>


        void updateLogin(login login);

        /// <summary>
        /// delete a login
        /// The deleteLogin takes in a login object as input and will pass it to the LoginSvcImpl </summary>
        /// <param name="login"> The login to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="LoginException">  </exception>

        void deleteLogin(login login);

    }
}