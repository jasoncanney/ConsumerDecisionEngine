using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAdxCDE.Source.Model.Domain
{
    /// <summary>
    /// @author Jason Canney
    /// Domain Coupon class 
    /// The Coupon class defines the domain object for coupon data that will
    /// be received by the CDE from the advertiser system and then stored in a data store
    /// by the CDE
    /// </summary>
    /// 

    [Serializable]
    public class coupon
    {

     ///  @param serialVersionUID
     /// The serialVersionUID is a universal version identifier for a Serializable class. Deserialization uses this
     /// number to ensure that a loaded class corresponds exactly to a serialized object. If no match is found,
     /// then an InvalidClassException is thrown

        private const long serialVersionUID = 4349382150030819493L;

        /// <summary>
        /// Coupon ID</summary>
        private int couponID;

        /// <summary>
        /// Coupon Title</summary>
        private string couponTitle;
        
        /// <summary>
        /// Coupon Description</summary>
        private string couponDescription;

        /// <summary>
        /// Coupon Value</summary>
        private float couponValue;

        /// <summary>
        /// Coupon Start Active</summary>
        private string couponStartActive;

        /// <summary>
        /// Coupon End Active</summary>
        private string couponEndActive;

        /// <summary>
        /// Coupon LocationsZip</summary>
        private string couponLocationsZip;


        /// <summary>
        ///  Default Constructor
        ///  @param consumer object
        /// </summary>
        public coupon()
          {

          }

        /// <summary>
        /// Overloaded Constructor</summary>
        /// <param name="couponID"></param>
        /// <param name="couponTitle"> </param>
        /// <param name="couponDescription"> </param>
        /// <param name="couponValue"> </param>
        /// <param name="couponStartActive"></param>
        /// <param name="couponEndActive"></param>
        /// <param name="couponLocationsZip"></param>

        public coupon(int couponID, string couponTitle, string couponDescription, float couponValue, string couponStartActive, string couponEndActive, string couponLocationsZip) : base()
          {
            this.couponID = couponID;
            this.couponTitle = couponTitle;
            this.couponDescription = couponDescription;
            this.couponValue = couponValue;
            this.couponStartActive = couponStartActive;
            this.couponEndActive = couponEndActive;
            this.couponLocationsZip = couponLocationsZip;
            }

        // getters and setters

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

        public virtual float CouponValue
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

        /// <returns> Returns the Coupon's Start Active </returns>
        /// <sets>Sets the Coupon's Start Active</sets>

        public virtual string CouponStartActive
        {
            get
            {
                return couponStartActive;
            }
            set
            {
                this.couponStartActive = value;
            }
        }

        /// <returns> Returns the Coupon's End Active </returns>
        /// <sets>Sets the Coupon's End Active</sets>

        public virtual string CouponEndActive
        {
            get
            {
                return couponEndActive;
            }
            set
            {
                this.couponEndActive = value;
            }
        }

        /// <returns> Returns the Coupon's Location Zip </returns>
        /// <sets>Sets the Coupon's Location Zip</sets>

        public virtual string CouponLocationsZip
        {
            get
            {
                return couponLocationsZip;
            }
            set
            {
                this.couponLocationsZip = value;
            }
        }

        /// <summary>
        /// Validate if the instance variables are valid
        /// </summary>
        /// <returns> boolean - true if instance variables are valid, else false </returns>
        public virtual bool validate()
            {

            if (int.ReferenceEquals(couponID, null))
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
            if (string.ReferenceEquals(couponStartActive, null))
            {
                return false;
            }
            if (string.ReferenceEquals(couponEndActive, null))
            {
                return false;
            }
            if (string.ReferenceEquals(couponLocationsZip, null))
            {
                return false;
            }
           
            return true;
            }

        /// <summary>Equals Test Method</summary>
        /// <param name="couponID"></param>
        /// <param name="couponTitle"> </param>
        /// <param name="couponDescription"> </param>
        /// <param name="couponValue"> </param>
        /// <param name="couponStartActive"></param>
        /// <param name="couponEndActive"></param>
        /// <param name="couponLocationsZip"></param>

        public virtual bool Equals(coupon coupon)


                {

                if (!couponID.Equals(coupon.couponID))
                {
                    return false;
                }

                if (!couponTitle.Equals(coupon.couponTitle))
                {
                    return false;
                }
                if (!couponDescription.Equals(coupon.couponDescription))
                {
                    return false;
                }
                if (!couponValue.Equals(coupon.couponValue))
                {
                    return false;
                }

                if (!couponStartActive.Equals(coupon.couponStartActive))
                {
                    return false;
                }
                if (!couponEndActive.Equals(coupon.couponEndActive))
                {
                    return false;
                }
                if (!couponLocationsZip.Equals(coupon.couponLocationsZip))
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
        ///<param name="couponID"></param>
        /// <param name="couponTitle"> </param>
        /// <param name="couponDescription"> </param>
        /// <param name="couponValue"> </param>
        /// <param name="couponStartActive"></param>
        /// <param name="couponEndActive"></param>
        /// <param name="couponLocationsZip"></param>
        /// </summary>

        public override string ToString()
            {
                StringBuilder strBfr = new StringBuilder();
                strBfr.Append("couponID:");
                strBfr.Append(couponID);
                strBfr.Append("couponTitle:");
                strBfr.Append(couponTitle);
                strBfr.Append("\ncouponDescription");
                strBfr.Append(couponDescription);
                strBfr.Append("\ncouponValue:");
                strBfr.Append(couponValue);
                strBfr.Append("\ncouponStartDate:");
                strBfr.Append(couponStartActive);
                strBfr.Append("\ncouponEndDate:");
                strBfr.Append(couponEndActive);
                strBfr.Append("\ncouponLocationsZip:");
                strBfr.Append(couponLocationsZip);
              
            return strBfr.ToString();
            }
       
    }
}
