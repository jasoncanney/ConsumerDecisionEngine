using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAdxCDE.Source.Model.Domain
{
    /// <summary>
    /// @author Jason Canney
    /// Domain login class 
    /// The login class defines the domain object for login data that will
    /// be received by the CDE from the mobile app and then stored in a data store
    /// by the CDE
    /// </summary>
    /// 
    
    [Serializable]
    public class login
    {

     ///  @param serialVersionUID
     /// The serialVersionUID is a universal version identifier for a Serializable class. Deserialization uses this
     /// number to ensure that a loaded class corresponds exactly to a serialized object. If no match is found,
     /// then an InvalidClassException is thrown

        private const long serialVersionUID = 4349382150030819493L;

        /// <summary>
        /// Users UserName</summary>
        private string UserName;

        /// <summary>
        /// Users Password</summary>
        private string PassWord;


        /// <summary>
        ///  Default Constructor
        ///  @param login object
        /// </summary>
        public login()
          {

          }
        
        /// <summary>
        /// Overloaded Constructor</summary>
        /// <param name="UserName"></param>
        /// <param name="PassWord"> </param>
            
        public login(string UserName, string PassWord) : base()
          {
            this.UserName = UserName;
            this.PassWord = PassWord;
            }

        // getters and setters

        /// <returns> Returns the UserName</returns>
        /// <sets>Sets the UserName</sets>

        public virtual string userName
        {
            get
            {
                return UserName;
            }
            set
            {
                this.UserName = value;
            }
        }

        /// <returns> Returns the password </returns>
        /// <sets>Sets the password</sets>

        public virtual string passWord
          {
                get
                {
                    return PassWord;
                }
                set
                {
                    this.PassWord = value;
                }
          }

        
        /// <summary>
        /// Validate if the instance variables are valid
        /// </summary>
        /// <returns> boolean - true if instance variables are valid, else false </returns>
        public virtual bool validate()
            {

            if (int.ReferenceEquals(PassWord, null))
            {
                return false;
            }
            if (string.ReferenceEquals(UserName, null))
            {
                 return false;
            }
           
            return true;
            }

        /// <summary>Equals Test Method</summary>
        /// <param name="UserName"></param>
        /// <param name="PassWord"> </param>
       

        public virtual bool Equals(login login)


                {

                if (!UserName.Equals(login.UserName))
                {
                    return false;
                }

                if (!PassWord.Equals(login.PassWord))
                {
                    return false;
                }
               

            return true;
            }

            /// <summary>
            /// Constructs a <code>STring</code> with all attributes
            /// in name = value format
            /// 
            /// @return a <code>String</code> representation
            /// of this object
            /// 
            /// </summary>

            public override string ToString()
            {
                StringBuilder strBfr = new StringBuilder();
                strBfr.Append("UserName:");
                strBfr.Append(UserName);
                strBfr.Append("PassWord:");
                strBfr.Append(PassWord);
                
              
            return strBfr.ToString();
            }
       
    }
}
