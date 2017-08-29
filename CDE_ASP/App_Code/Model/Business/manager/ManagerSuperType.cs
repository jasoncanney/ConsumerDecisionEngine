using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenAdxCDE.Source.Model.Services.consumerservice;
using GenAdxCDE.Source.Model.Services;
using System.Threading.Tasks;
using GenAdxCDE.Source.Model.Domain;

namespace GenAdxCDE.Source.Model.Business
{

	/// <summary>
	/// Used as an abstract class for the managers in the business layer
	/// Static code below is executed anytime any of the managers in the 
	/// business layer are executed that inherit this abstract class
	/// 
	/// @author Jason Canney
	/// 
	/// </summary>
	public abstract class ManagerSuperType
	{

        private Factory factory;


        protected IService getService(string name)
        {
            return factory.getService(name);
        }

    }

}