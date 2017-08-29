using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAdxCDE.Source.Model.Domain
{
    /// <summary>
    /// @author Jason Canney
    /// Domain Consumer History class 
    /// The ConsumerHistory class defines the domain object for consumer VIEWS and Preferences data that will
    /// be received by the CDE from the mobile app and then stored in a data store
    /// by the CDE
    /// </summary>
    /// 
    
    [Serializable]
    public class consumerHistory
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
        /// Preference ID</summary>
        private int preferenceID;

        /// <summary>
        /// Preference Date</summary>
        private string preferenceDate;

        /// <summary>
        /// Preference Choice</summary>
        private int preferenceChoice;

        /// <summary>
        /// Advertisement ID</summary>
        private int advertisementID;

        /// <summary>
        /// Coupon ID</summary>
        private int couponID;

        

        /// <summary>
        ///  Default Constructor
        ///  @param consumerHistory object
        /// </summary>
        public consumerHistory()
          {

          }
        
        /// <summary>
        /// Overloaded Constructor</summary>
        /// <param name="consumerID"></param>
        /// <param name="preferenceID"> </param>
        /// <param name="preferenceDate"> </param>
        /// <param name="preferenceChoice"> </param>
        /// <param name="advertisementID"></param>
        /// <param name="couponID"></param>
       
        public consumerHistory(int consumerID, int preferenceID, string preferenceDate, int preferenceChoice, int advertisementID, int couponID) : base()
          {
            this.consumerID = consumerID;
            this.preferenceID = preferenceID;
            this.preferenceDate = preferenceDate;
            this.preferenceChoice = preferenceChoice;
            this.advertisementID = advertisementID;
            this.couponID = couponID;
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

        /// <returns> Returns the consumer's preference ID </returns>
        /// <sets>Sets the consumer's preference ID</sets>

        public virtual int PreferenceID
          {
                get
                {
                    return preferenceID;
                }
                set
                {
                    this.preferenceID = value;
                }
          }



            /// <returns> Returns the consumer's preference date </returns>
            /// <sets>Sets the consumer's preference date</sets>

            public virtual string PreferenceDate
            {
                get
                {
                    return preferenceDate;
                }
                set
                {
                    this.preferenceDate = value;
                }
            }

            /// <returns> Returns the consumer's preference choice is positive (1) or negative (0) </returns>
            /// <sets>Sets the consumer's preference choice</sets>

            public virtual int PreferenceChoice
            {
                get
                {
                    return preferenceChoice;
                }
                set
                {
                    this.preferenceChoice = value;
                }
            }

        /// <returns> Returns the consumer's advertisement id </returns>
        /// <sets>Sets the consumer's advertisement ID</sets>

        public virtual int AdvertisementID
        {
            get
            {
                return advertisementID;
            }
            set
            {
                this.advertisementID = value;
            }
        }

        /// <returns> Returns the consumer's coupon ID </returns>
        /// <sets>Sets the consumer's coupon ID</sets>

        public virtual int CouponID
        {
            get
            {
                return couponID;
            }
            set
            {
                this.couponID = value;
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
            if (string.ReferenceEquals(preferenceID, null))
            {
                 return false;
            }
            if (string.ReferenceEquals(preferenceDate, null))
            {
                return false;
            }
            if (string.ReferenceEquals(preferenceChoice, null))
            {
                return false;
            }
            if (string.ReferenceEquals(advertisementID, null))
            {
                return false;
            }
            if (string.ReferenceEquals(couponID, null))
            {
                return false;
            }
           
            return true;
            }

        /// <summary>Equals Test Method</summary>
        /// <param name="consumerID"></param>
        /// <param name="preferenceID"> </param>
        /// <param name="preferenceDate"> </param>
        /// <param name="preferenceChoice"> </param>
        /// <param name="advertisementID"></param>
        /// <param name="couponID"></param>

        public virtual bool Equals(consumerHistory consumerHistory)


                {

                if (!consumerID.Equals(consumerHistory.consumerID))
                {
                    return false;
                }

                if (!preferenceID.Equals(consumerHistory.preferenceID))
                {
                    return false;
                }
                if (!preferenceDate.Equals(consumerHistory.preferenceDate))
                {
                    return false;
                }
                if (!preferenceChoice.Equals(consumerHistory.preferenceChoice))
                {
                    return false;
                }
                if (!advertisementID.Equals(consumerHistory.advertisementID))
                {
                    return false;
                }
                if (!couponID.Equals(consumerHistory.couponID))
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
        /// /// <param name="consumerID"></param>
        /// <param name="preferenceID"> </param>
        /// <param name="preferenceDate"> </param>
        /// <param name="preferenceChoice"> </param>
        /// <param name="advertisementID"></param>
        /// <param name="couponID"></param>
        /// </summary>

        public override string ToString()
            {
                StringBuilder strBfr = new StringBuilder();
                strBfr.Append("consumerID:");
                strBfr.Append(consumerID);
                strBfr.Append("\npreferenceID:");
                strBfr.Append(preferenceID);
                strBfr.Append("\npreferenceDate:");
                strBfr.Append(preferenceDate);
                strBfr.Append("\npreferenceChoice:");
                strBfr.Append(preferenceChoice);
                strBfr.Append("\nadvertisementID:");
                strBfr.Append(advertisementID);
                strBfr.Append("\ncouponID:");
                strBfr.Append(couponID);
              
            return strBfr.ToString();
            }
       
    }
}
