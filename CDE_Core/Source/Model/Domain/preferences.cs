using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAdxCDE.Source.Model.Domain
{
	/// <summary>
	/// @author Jason Canney
	/// Domain preferences class 
	/// The preferences.cs class defines the domain object for multiple domain preference.cs objects to be put into a collection 
	/// The consumer ID will be unique and preference ID will be unique along with date received.  preferenceId is the dictionary
    /// primary key
	/// </summary>
	/// 

	[Serializable]
	public class preferences
	{
		///  @param serialVersionUID
		/// The serialVersionUID is a universal version identifier for a Serializable class. Deserialization uses this
		/// number to ensure that a loaded class corresponds exactly to a serialized object. If no match is found,
		/// then an InvalidClassException is thrown

		private const long serialVersionUID = 4349382150030819654L;

		/// <summary>
		/// _Preferences Collection created with a Hashtable type
		/// </summary>

		private IDictionary _Preferences = new Hashtable();

		/// <summary>
		///  Default Constructor
		///  @param preferences object
		/// </summary>
		public preferences()
		{
		
		}

        /// Setters and Getters
        
		/// <returns> Returns a single preference name _Preference from the collection </returns>
        /// <sets>Puts a single preference domain object into the collection</sets>

        public IDictionary Preferences
		{
			get
			{
				Contract.Ensures(Contract.Result<IDictionary>() != null);
				return _Preferences;
			}
			set
			{
				this._Preferences = value;
			}
		}

	}
}