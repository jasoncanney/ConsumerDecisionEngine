using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.Serialization;

namespace GenAdxCDE.Source.Model.Services
{
    /// <summary>
    /// Factory.cs
    /// @author Jason L. Canney
    /// 
    /// </summary>
    public class Factory
    {

        // Singleton Method - next three lines of code 
        private Factory() { }
        private static Factory factory = new Factory();
        public static Factory GetInstance() { return factory; }

        public IService getService(string serviceName)
        {
            Type type;
            Object obj = null;

            try
            {
                type = Type.GetType(getImplName(serviceName));
                obj = Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred: {0}", e);
                throw e;
            }
           return (IService)obj;
        }
        private string getImplName(string serviceName)
        {
            
            NameValueCollection settings = ConfigurationManager.AppSettings;
            return settings.Get(serviceName);
        }

        }
    }