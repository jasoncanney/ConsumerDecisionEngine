using System;
using System.Runtime.Serialization;


/// 
namespace GenAdxCDE.Source.Model.Services
{


    /// <summary>
    /// @author Jason L. Canney
    /// 
    /// </summary>
    [Serializable]


    public class PreferenceException : Exception
	{

		/// 
		private const long serialVersionUID = 1123523456523L;
		private static Exception inNestedException;
		private static string inMessage;

		/// 
		/// <param name="string"> </param>
		/// <param name="ioeinMessage"> </param>
		public PreferenceException(string @string, Exception ioeinMessage) : base(inMessage, inNestedException)
		{
            Console.WriteLine("IO Exception - PreferenceSvcxxxImpl");

        }

        /// 
        /// <param name="string"> </param>
        /// <param name="fnfe"> </param>
        public PreferenceException(string @string, System.IO.FileNotFoundException fnfe) : base(inMessage, inNestedException)
		{
            Console.WriteLine("File Not Found - ConsumerSvcxxxImpl");

        }

        /// 
        /// <param name="string"> </param>
        public PreferenceException(string @string) : base(inMessage, inNestedException)
		{
		}

	}

}