using System;

namespace GenAdxCDE.Source.Model.Business
{

	/// 
	/// <summary>
	/// Service Load Exception class in the business layer for issues when business classes run into problems
	/// @author JasonCanney
	/// 
	/// </summary>
//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @SuppressWarnings("serial") public class ServiceLoadException extends Exception
	public class ServiceLoadException : Exception
	/// <summary>
	/// Used to catch issues with loading services through the business layer
	/// @author JasonCanney
	/// 
	/// </summary>
	{
//JAVA TO C# CONVERTER WARNING: 'final' parameters are not available in .NET:
//ORIGINAL LINE: public ServiceLoadException(final String inMessage, final Throwable inNestedException)
		public ServiceLoadException(string inMessage, Exception inNestedException) : base(inMessage, inNestedException)
		{
		}

	} // end class ServiceLoadException
}