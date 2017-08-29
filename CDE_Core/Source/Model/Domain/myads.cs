using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAdxCDE.Source.Model.Domain
{
    /// <summary>
    /// @author Jason Canney
    /// Domain myAds class 
    /// The myads class defines the domain object for ad and coupon data that the mobile app will
    /// request upon startup
    /// </summary>
    /// 
    
    [Serializable]
    public class myads
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
        /// Advertisement ID</summary>
        private int adID;

        /// <summary>
        /// advertisement URL location for image</summary>
        private string AdURL;

        /// <summary>
        /// advertisement PCC code</summary>
        private string adPCC;

        /// <summary>
        /// advertisement title</summary>
        private string adtitle;

        /// <summary>
        /// advertisement description</summary>
        private string addescription;

        /// <summary>
        /// advertisement owner</summary>
        private string adowner;

        /// <summary>
        /// Coupon ID</summary>
        private int couponID;

        /// <summary>
        /// coupon URL location for image</summary>
        private string couponURL;

        /// <summary>
        /// Coupon Title</summary>
        private string couponTitle;

        /// <summary>
        /// Coupon Description</summary>
        private string couponDescription;

        /// <summary>
        /// Coupon Value</summary>
        private string couponValue;
    
        /// <summary>
        /// campaign ID for advertiser reference</summary>
        private string adCampID;
        
       
        /// <summary>
        ///  Default Constructor
        ///  @param myads object
        /// </summary>
        public myads()
          {

          }

        /// <summary>
        /// Overloaded Constructor</summary>
        /// <param name="consumerID"></param>
        /// <param name="adID"></param>
        /// <param name="adURL"></param>
        /// <param name="adPCC"></param>
        /// <param name="adtitle"> </param>
        /// <param name="addescription"></param>
        /// <param name="adowner"></param>
        /// <param name="couponID"></param>
        /// <param name="couponURL"></param>
        /// <param name="couponTitle"></param>
        /// <param name="couponDescription"></param>
        /// <param name="couponValue"></param>
        /// <param name="adCampID"></param>
       

        public myads(int consumerID, int adID, string adURL, string adPCC, string adtitle, string addescription, string adowner, int couponID, string couponURL, string couponTitle, string couponDescription, string couponValue, string adCampID) : base()
          {
            this.consumerID = consumerID;
            this.adID = adID;
            this.AdURL = adURL;
            this.adPCC = adPCC;
            this.adtitle = adtitle;
            this.addescription = addescription;
            this.adowner = adowner;
            this.couponID = couponID;
            this.couponURL = couponURL;
            this.couponTitle = couponTitle;
            this.couponDescription = couponDescription;
            this.couponValue = couponValue;
            this.adCampID = adCampID;
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
        
        /// <returns> Returns the advertisement's ID </returns>
         /// <sets>Sets the advertisement's ID</sets>

        public virtual int AdId
        {
            get
            {
                return adID;
            }
            set
            {
                this.adID = value;
            }
        }

        /// <returns> Returns the advertisement's URL </returns>
        /// <sets>Sets the advertisement's URL</sets>

        public virtual string AdUrl
        {
            get
            {
                return AdURL;
            }
            set
            {
                this.AdURL = value;
            }
        }

        /// <returns> Returns the advertisement's PCC code </returns>
        /// <sets>Sets the advertisement's PCC code</sets>

        public virtual string AdPcc
        {
            get
            {
                return adPCC;
            }
            set
            {
                this.adPCC = value;
            }
        }

        /// <returns> Returns the advertisement's title </returns>
        /// <sets>Sets the advertisement's title </sets>

        public virtual string AdTitle
          {
                get
                {
                    return adtitle;
                }
                set
                {
                    this.adtitle = value;
                }
          }

        /// <returns> Returns the advertisement's description </returns>
        /// <sets>Sets the advertisement's description</sets>

        public virtual string AdDescription
        {
            get
            {
                return addescription;
            }
            set
            {
                this.addescription = value;
            }
        }

        /// <returns> Returns the advertisement's owner </returns>
        /// <sets>Sets the advertisement's owner</sets>

        public virtual string AdOwner
        {
            get
            {
                return adowner;
            }
            set
            {
                this.adowner = value;
            }
        }

        /// <returns> Returns the coupon's ID </returns>
        /// <sets>Sets the coupon's ID</sets>

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

        /// <returns> Returns the coupon's URL </returns>
        /// <sets>Sets the coupon's URL</sets>

        public virtual string CouponUrl
        {
            get
            {
                return couponURL;
            }
            set
            {
                this.couponURL = value;
            }
        }

        /// <returns> Returns the Coupon Title </returns>
        /// <sets>Sets the Coupon Title  </sets>

        public virtual string CouponTitle
        {
            get
            {
                return couponTitle;
            }
            set
            {
                this.couponTitle = value;
            }
        }
        
        /// <returns> Returns the Coupon Description </returns>
        /// <sets>Sets the Coupon Description</sets>

        public virtual string CouponDescription
        {
            get
            {
                return couponDescription;
            }
            set
            {
                this.couponDescription = value;
            }
        }

        /// <returns> Returns the Coupon Value </returns>
        /// <sets>Sets the Coupon Value</sets>

        public virtual string CouponValue
        {
            get
            {
                return couponValue;
            }
            set
            {
                this.couponValue = value;
            }
        }

        /// <returns> Returns the advertisement's Campaign ID </returns>
        /// <sets>Sets the advertisement's Campaign ID</sets>

        public virtual string AdCampId
        {
            get
            {
                return adCampID;
            }
            set
            {
                this.adCampID = value;
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
            if (int.ReferenceEquals(adID, null))
            {
                return false;
            }
            if (string.ReferenceEquals(AdURL, null))
            {
                return false;
            }
            if (string.ReferenceEquals(adPCC, null))
            {
                return false;
            }
            if (string.ReferenceEquals(adtitle, null))
            {
                 return false;
            }
            if (string.ReferenceEquals(addescription, null))
            {
                return false;
            }
            if (string.ReferenceEquals(adowner, null))
            {
                return false;
            }
            if (int.ReferenceEquals(couponID, null))
            {
                return false;
            }
            if (string.ReferenceEquals(couponURL, null))
            {
                return false;
            }
            if (string.ReferenceEquals(couponTitle, null))
            {
                return false;
            }
            if (string.ReferenceEquals(couponDescription, null))
            {
                return false;
            }
            if (string.ReferenceEquals(couponValue, null))
            {
                return false;
            }
            if (int.ReferenceEquals(adCampID, null))
            {
                return false;
            }
            
            return true;
            }

        /// <summary>Equals Test Method</summary>
        /// <param name="consumerID"></param>
        /// <param name="adID"></param>
        /// <param name="adURL"></param>
        /// <param name="adPCC"></param>
        /// <param name="adtitle"> </param>
        /// <param name="addescription"></param>
        /// <param name="adowner"></param>
        /// <param name="couponID"></param>
        /// <param name="couponURL"></param>
        /// <param name="couponTitle"></param>
        /// <param name="couponDescription"></param>
        /// <param name="couponValue"></param>
        /// <param name="adCampID"></param>
        

        public virtual bool Equals(myads myads)


                {
                if (!consumerID.Equals(myads.consumerID))
                {
                    return false;
                }
                if (!adID.Equals(myads.adID))
                {
                    return false;
                }
                if (!AdURL.Equals(myads.AdURL))
                {
                    return false;
                }
                if (!adPCC.Equals(myads.adPCC))
                {
                    return false;
                }
                if (!adtitle.Equals(myads.adtitle))
                {
                    return false;
                }
                if (!addescription.Equals(myads.addescription))
                {
                    return false;
                }
                if (!adowner.Equals(myads.adowner))
                {
                    return false;
                }
                if (!couponID.Equals(myads.couponID))
                {
                    return false;
                }
                if (!AdURL.Equals(myads.couponURL))
                {
                    return false;
                }
                if (!couponTitle.Equals(myads.couponTitle))
                {
                    return false;
                }
                if (!couponDescription.Equals(myads.couponDescription))
                {
                    return false;
                }
                if (!couponValue.Equals(myads.couponValue))
                {
                    return false;
                }
                if (!adCampID.Equals(myads.adCampID))
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
                strBfr.Append("adID:");
                strBfr.Append(adID);
                strBfr.Append("\nadURL:");
                strBfr.Append(AdURL);
                strBfr.Append("\nadPCC:");
                strBfr.Append(adPCC);
                strBfr.Append("\nadtitle:");
                strBfr.Append(adtitle);
                strBfr.Append("\naddescription:");
                strBfr.Append(addescription);
                strBfr.Append("\nadowner:");
                strBfr.Append(adowner);
                strBfr.Append("couponID:");
                strBfr.Append(couponID);
                strBfr.Append("\ncouponURL:");
                strBfr.Append(couponURL);
                strBfr.Append("couponTitle:");
                strBfr.Append(couponTitle);
                strBfr.Append("\ncouponDescription");
                strBfr.Append(couponDescription);
                strBfr.Append("\ncouponValue:");
                strBfr.Append(couponValue);
                strBfr.Append("\nadCampID:");
                strBfr.Append(adCampID);
                
            return strBfr.ToString();
            }
       
    }
}
