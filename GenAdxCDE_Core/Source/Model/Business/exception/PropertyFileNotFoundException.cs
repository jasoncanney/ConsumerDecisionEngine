using System;

namespace com.voyage.model.business.exception
{

	/// <summary>
	/// Exception class that is used by PropertyManager in the service layer for reading in properties file
	/// @author JasonCanney
	/// 
	/// </summary>


	public class PropertyFileNotFoundException : Exception
	{
		/// <param name="serialVersionUID"> - unique identifier </param>
		private const long serialVersionUID = 1L;

		/// 
		/// <param name="inMessage"> </param>
		/// <param name="inNestedException"> </param>
//JAVA TO C# CONVERTER WARNING: 'final' parameters are not available in .NET:
//ORIGINAL LINE: public PropertyFileNotFoundException(final String inMessage, final Throwable inNestedException)
		public PropertyFileNotFoundException(string inMessage, Exception inNestedException) : base(inMessage, inNestedException)
		{
		}

	} // end class PropertyFileNotFoundException
}