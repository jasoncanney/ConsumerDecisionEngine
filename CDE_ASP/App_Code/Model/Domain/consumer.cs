using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAdxCDE.Source.Model.Domain
{
    /// <summary>
    /// @author Jason Canney
    /// Domain Consumer class 
    /// The Consumer class defines the domain object for consumer data that will
    /// be received by the CDE from the mobile app and then stored in a data store
    /// by the CDE
    /// </summary>
    /// 
    
    [Serializable]
    public class consumer
    {

     ///  @param serialVersionUID
     /// The serialVersionUID is a universal version identifier for a Serializable class. Deserialization uses this
     /// number to ensure that a loaded class corresponds exactly to a serialized object. If no match is found,
     /// then an InvalidClassException is thrown

        private const long serialVersionUID = 4349382150030819493L;

        /// <summary>
        /// Consumers ID</summary>
        private int consumerID;

        /// <summary>
        /// Consumers First Name</summary>
        private string consumerFirstName;

        /// <summary>
        /// Consumers Middle Initial</summary>
        private string consumerMiddleInitial;

        /// <summary>
        /// Consumers Last Name</summary>
        private string consumerLastName;

        /// <summary>
        /// Consumer email address</summary>
        private string consumerEmail;

        /// <summary>
        /// Consumer phone</summary>
        private string consumerPhone;

        /// <summary>
        /// Consumer Address1</summary>
        private string consumerAddress;

        /// <summary>
        /// Consumer City</summary>
        private string consumerCity;

        /// <summary>
        /// Consumer State</summary>
        private string consumerState;

        /// <summary>
        /// Consumer Zip</summary>
        private string consumerZip;

        /// <summary>
        /// Consumer SocialEmail</summary>
        private string consumerSocEmail;


        /// <summary>
        ///  Default Constructor
        ///  @param consumer object
        /// </summary>
        public consumer()
          {

          }
        
        /// <summary>
        /// Overloaded Constructor</summary>
        /// <param name="consumerID"></param>
        /// <param name="consumerFirstName"> </param>
        /// <param name="consumerMiddleInitial"> </param>
        /// <param name="consumerLastName"> </param>
        /// <param name="consumerEmail"></param>
        /// <param name="consumerPhone"></param>
        /// <param name="consumerAddress"></param>
        /// <param name="consumerCity"></param>
        /// <param name="consumerState"></param>
        /// <param name="consumerZip"></param>
        /// <param name="consumerSocEmail"></param>
            
        public consumer(int consumerID, string consumerFirstName, string consumerMiddleInitial, string consumerLastName, string consumerEmail, string consumerPhone, string consumerAddress, string consumerCity, string consumerState, string consumerZip, string consumerSocEmail) : base()
          {
            this.consumerID = consumerID;
            this.consumerFirstName = consumerFirstName;
            this.consumerMiddleInitial = consumerMiddleInitial;
            this.consumerLastName = consumerLastName;
            this.consumerEmail = consumerEmail;
            this.consumerPhone = consumerPhone;
            this.consumerAddress = consumerAddress;
            this.consumerCity = consumerCity;
            this.consumerState = consumerState;
            this.consumerZip = consumerZip;
            this.consumerSocEmail = consumerSocEmail;
            }

        // getters and setters

        /// <returns> Returns the consumer's ID </returns>
        /// <sets>Sets the consumer's ID</sets>

        public virtual int ConsumerID
        {
            get
            {
                return consumerID;
            }
            set
            {
                this.consumerID = value;
            }
        }

        /// <returns> Returns the consumer's first name. </returns>
        /// <sets>Sets the consumer's first name. </sets>

        public virtual string ConsumerFirstName
          {
                get
                {
                    return consumerFirstName;
                }
                set
                {
                    this.consumerFirstName = value;
                }
          }



            /// <returns> Returns the consumer's middle initial. </returns>
            /// <sets>Sets the consumer's middle initial</sets>

            public virtual string ConsumerMiddleInitial
            {
                get
                {
                    return consumerMiddleInitial;
                }
                set
                {
                    this.consumerMiddleInitial = value;
                }
            }

            /// <returns> Returns the consumer's last name. </returns>
            /// <sets>Sets the consumer's last name</sets>

            public virtual string ConsumerLastName
            {
                get
                {
                    return consumerLastName;
                }
                set
                {
                    this.consumerLastName = value;
                }
            }

        /// <returns> Returns the consumer's email. </returns>
        /// <sets>Sets the consumer's email</sets>

        public virtual string ConsumerEmail
        {
            get
            {
                return consumerEmail;
            }
            set
            {
                this.consumerEmail = value;
            }
        }

        /// <returns> Returns the consumer's Phone </returns>
        /// <sets>Sets the consumer's phone</sets>

        public virtual string ConsumerPhone
        {
            get
            {
                return consumerPhone;
            }
            set
            {
                this.consumerPhone = value;
            }
        }

        /// <returns> Returns the consumer's Address </returns>
        /// <sets>Sets the consumer's address</sets>

        public virtual string ConsumerAddress
        {
            get
            {
                return consumerAddress;
            }
            set
            {
                this.consumerAddress = value;
            }
        }

        /// <returns> Returns the consumer's city </returns>
        /// <sets>Sets the consumer's city</sets>

        public virtual string ConsumerCity
        {
            get
            {
                return consumerCity;
            }
            set
            {
                this.consumerCity = value;
            }
        }

        /// <returns> Returns the consumer's State </returns>
        /// <sets>Sets the consumer's State</sets>

        public virtual string ConsumerState
        {
            get
            {
                return consumerState;
            }
            set
            {
                this.consumerState = value;
            }
        }

        /// <returns> Returns the consumer's zip </returns>
        /// <sets>Sets the consumer's zip</sets>

        public virtual string ConsumerZip
        {
            get
            {
                return consumerZip;
            }
            set
            {
                this.consumerZip = value;
            }
        }

        /// <returns> Returns the consumer's Social Media Email </returns>
        /// <sets>Sets the consumer's Social Media Email</sets>

        public virtual string ConsumerSocEmail
        {
            get
            {
                return consumerSocEmail;
            }
            set
            {
                this.consumerSocEmail = value;
            }
        }

        /// <summary>
        /// Validate if the instance variables are valid
        /// </summary>
        /// <returns> boolean - true if instance variables are valid, else false </returns>
        public virtual bool validate()
            {

            if (int.ReferenceEquals(consumerID, null))
            {
                return false;
            }
            if (string.ReferenceEquals(consumerFirstName, null))
            {
                 return false;
            }
            if (string.ReferenceEquals(consumerMiddleInitial, null))
            {
                return false;
            }
            if (string.ReferenceEquals(consumerLastName, null))
            {
                return false;
            }
            if (string.ReferenceEquals(consumerEmail, null))
            {
                return false;
            }
            if (string.ReferenceEquals(consumerPhone, null))
            {
                return false;
            }
            if (string.ReferenceEquals(consumerAddress, null))
            {
                return false;
            }

            if (string.ReferenceEquals(consumerCity, null))
            {
                return false;
            }
            if (string.ReferenceEquals(consumerState, null))
            {
                return false;
            }
            if (string.ReferenceEquals(consumerZip, null))
            {
                return false;
            }
            if (string.ReferenceEquals(consumerSocEmail, null))
            {
                return false;
            }
           
            return true;
            }

        /// <summary>Equals Test Method</summary>
        /// <param name="consumerID"></param>
        /// <param name="consumerFirstName"> </param>
        /// <param name="consumerMiddleInitial"> </param>
        /// <param name="consumerLastName"> </param>
        /// <param name="consumerEmail"></param>
        /// <param name="consumerPhone"></param>
        /// <param name="consumerAddress"></param>
        /// <param name="consumerCity"></param>
        /// <param name="consumerState"></param>
        /// <param name="consumerZip"></param>
        /// <param name="consumerSocEmail"></param>

        public virtual bool Equals(consumer consumer)


                {

                if (!consumerID.Equals(consumer.consumerID))
                {
                    return false;
                }

                if (!consumerFirstName.Equals(consumer.consumerFirstName))
                {
                    return false;
                }
                if (!consumerMiddleInitial.Equals(consumer.consumerMiddleInitial))
                {
                    return false;
                }
                if (!consumerLastName.Equals(consumer.consumerLastName))
                {
                    return false;
                }

                if (!consumerEmail.Equals(consumer.consumerEmail))
                {
                    return false;
                }
                if (!consumerPhone.Equals(consumer.consumerPhone))
                {
                    return false;
                }
                if (!consumerAddress.Equals(consumer.consumerAddress))
                {
                    return false;
                }

                if (!consumerCity.Equals(consumer.consumerCity))
                {
                    return false;
                }
                if (!consumerState.Equals(consumer.consumerState))
                {
                    return false;
                }
                if (!consumerZip.Equals(consumer.consumerZip))
                {
                    return false;
                }
                if (!consumerSocEmail.Equals(consumer.consumerSocEmail))
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
                strBfr.Append("consumerID:");
                strBfr.Append(consumerID);
                strBfr.Append("consumerFirstName:");
                strBfr.Append(consumerFirstName);
                strBfr.Append("\nconsumerMiddleInitial:");
                strBfr.Append(consumerMiddleInitial);
                strBfr.Append("\nconsumerLastName:");
                strBfr.Append(consumerLastName);
                strBfr.Append("\nconsumerEmail:");
                strBfr.Append(consumerEmail);
                strBfr.Append("\nconsumerPhone:");
                strBfr.Append(consumerPhone);
                strBfr.Append("\nconsumerAddress:");
                strBfr.Append(consumerAddress);
                strBfr.Append("\nconsumerCity:");
                strBfr.Append(consumerCity);
                strBfr.Append("\nconsumerState:");
                strBfr.Append(consumerState);
                strBfr.Append("\nconsumerZip:");
                strBfr.Append(consumerZip);
                strBfr.Append("\nconsumerSocEmail:");
                strBfr.Append(consumerSocEmail);
              
            return strBfr.ToString();
            }
       
    }
}
