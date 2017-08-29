using System.Collections.Generic;
using GenAdxCDE.Source.Model.Domain;
using System;
using System.Data;

namespace GenAdxCDE.Source.Model.Services.preferenceservice
{
    /// <summary>
    /// This interface defines methods for storing and retrieving Preferences
    /// to and from a file system
    /// @author Jason Canney
    /// 
    /// </summary>
    public interface IPreferenceSvc : IService
    {

        /// <summary>
        /// Persists a Preference
        /// The storePreference interface uses the storePreference method in the PreferenceSvcImpl class to store the object </summary>
        /// <param name="preference"> The Preference to be persisted </param>
        /// <returns> boolean true/false </returns>
        /// <exception cref="PreferenceException">  </exception>
        void storePreference(preference preference);

        /// <summary>
        /// Retrieves a Preference </summary>
        /// <param name="Preference"> The unique Preference for the Preference to be retrieved </param>
        /// <returns> The Preference object matching Preference </returns>
        /// 
        DataTable getPreference();

        /// <summary>
        /// Updates a preference
        /// The updatePreference takes in a preference object as input and will pass it to the preferenceSvcImpl </summary>
        /// <param name="preference"> The preference to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="PreferenceException">  </exception>

        void updatePreference(preference preference);

        /// <summary>
        /// delete a preference
        /// The deletePreference takes in a preference object as input and will pass it to the preferenceSvcImpl </summary>
        /// <param name="preference"> The preference to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="PreferenceException">  </exception>

        void deletePreference(preference preference);

    }
}
