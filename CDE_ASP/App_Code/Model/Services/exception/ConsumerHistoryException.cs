using System;
using System.Runtime.Serialization;

/// 
namespace GenAdxCDE.Source.Model.Services
{


    /// <summary>
    /// @author Jason L. Canney
    /// 
    /// </summary>
    /// 
    [Serializable]

    public class ConsumerHistoryException : Exception
	{

		/// <param name="serialVersionUID"> = unique identifier </param>
		/// <param name="Throwable"> exception </param>
		/// <param name="inMessage"> is a string </param>
		private const long serialVersionUID = 1L;
		private static Exception inNestedException;
		private static string inMessage;

		/// 
		/// <param name="string"> </param>
		/// <param name="ioeinMessage"> </param>
		public ConsumerHistoryException(string @string, System.IO.IOException ioeinMessage) : base(inMessage, inNestedException)
		{
            Console.WriteLine("IO Exception - ConsumerHistorySvcxxxImpl");
		}

		/// 
		/// <param name="string"> </param>
		/// <param name="fnfe"> </param>
		public ConsumerHistoryException(string @string, System.IO.FileNotFoundException fnfe) : base(inMessage, inNestedException)
		{
            Console.WriteLine("File Not Found - ConsumerHistorySvcxxxImpl");
        }

		/// 
		/// <param name="string"> </param>
		public ConsumerHistoryException(string @string) : base(inMessage)
		{
		}

	}

}