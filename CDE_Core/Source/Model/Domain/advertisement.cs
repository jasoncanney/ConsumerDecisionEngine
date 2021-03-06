﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenAdxCDE.Source.Model.Domain
{
    /// <summary>
    /// @author Jason Canney
    /// Domain Advertisement class 
    /// The Advertisement class defines the domain object for advertisement data that will
    /// be received by the CDE from advertisers and then stored in a data store
    /// by the CDE
    /// </summary>
    /// 
    
    [Serializable]
    public class advertisement
    {

     ///  @param serialVersionUID
     /// The serialVersionUID is a universal version identifier for a Serializable class. Deserialization uses this
     /// number to ensure that a loaded class corresponds exactly to a serialized object. If no match is found,
     /// then an InvalidClassException is thrown

        private const long serialVersionUID = 4349382150030819493L;

        /// <summary>
        /// Advertisement ID</summary>
        private int adID;

        /// <summary>
        /// advertisement title</summary>
        private string adtitle;

        /// <summary>
        /// advertisement demographic01</summary>
        private int addemo01;

        /// <summary>
        /// advertisement demographic02</summary>
        private int addemo02;

        /// <summary>
        /// advertisement demographic03</summary>
        private int addemo03;

        /// <summary>
        /// advertisement demographic04</summary>
        private int addemo04;

        /// <summary>
        /// advertisement description</summary>
        private string addescription;

        /// <summary>
        /// advertisement owner</summary>
        private string adowner;

        /// <summary>
        /// advertisement brand</summary>
        private string adbrand;
        

        /// <summary>
        /// advertisement PCC code</summary>
        private string adPCC;

        /// <summary>
        /// advertisement URL location for image</summary>
        private string adURL;
        
        /// <summary>
        /// advertisement campaign ID for advertiser reference</summary>
        private string adCampID;
        
        /// <summary>
        ///  Default Constructor
        ///  @param advertisement object
        /// </summary>
        public advertisement()
          {

          }
        
        /// <summary>
        /// Overloaded Constructor</summary>
        /// <param name="adID"></param>
        /// <param name="adtitle"> </param>
        /// <param name="addemo01"> </param>
        /// <param name="addemo02"> </param>
        /// <param name="addemo03"></param>
        /// <param name="addemo04"></param>
        /// <param name="addescription"></param>
        /// <param name="adowner"></param>
        /// <param name="adbrand"></param>
        /// <param name="adPCC"></param>
        /// <param name="adURL"></param>
        /// <param name="adCampID"></param>
       
        public advertisement(int adID, string adtitle, int addemo01, int addemo02, int addemo03, int addemo04, string addescription, string adowner, string adbrand, string adPCC, string adURL, string adCampID) : base()
          {
            this.adID = adID;
            this.adtitle = adtitle;
            this.addemo01 = addemo01;
            this.addemo02 = addemo02;
            this.addemo03 = addemo03;
            this.addemo04 = addemo04;
            this.addescription = addescription;
            this.adowner = adowner;
            this.adbrand = adbrand;
            this.adPCC = adPCC;
            this.adURL = adURL;
            this.adCampID = adCampID;
            }

        // getters and setters

        /// <returns> Returns the advertisement's ID </returns>
        /// <sets>Sets the advertisement's ID</sets>

        public virtual int adId
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

        /// <returns> Returns the advertisement's title </returns>
        /// <sets>Sets the advertisement's title </sets>

        public virtual string adTitle
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



        /// <returns> Returns the advertisement's demo 01 </returns>
        /// <sets>Sets the advertisement's demo 01</sets>

        public virtual int adDemo01
            {
                get
                {
                    return addemo01;
                }
                set
                {
                    this.addemo01 = value;
                }
            }

        /// <returns> Returns the advertisement's demo 02 </returns>
        /// <sets>Sets the advertisement's demo 02</sets>

        public virtual int adDemo02
            {
                get
                {
                    return addemo02;
                }
                set
                {
                    this.addemo02 = value;
                }
            }

        /// <returns> Returns the advertisement's demo 03</returns>
        /// <sets>Sets the advertisement's demo 03</sets>

        public virtual int adDemo03
        {
            get
            {
                return addemo03;
            }
            set
            {
                this.addemo03 = value;
            }
        }

        /// <returns> Returns the advertisement's demo 04 </returns>
        /// <sets>Sets the advertisement's demo 04</sets>

        public virtual int adDemo04
        {
            get
            {
                return addemo04;
            }
            set
            {
                this.addemo04 = value;
            }
        }

        /// <returns> Returns the advertisement's description </returns>
        /// <sets>Sets the advertisement's description</sets>

        public virtual string adDescription
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

        public virtual string adOwner
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

        /// <returns> Returns the advertisement's brand </returns>
        /// <sets>Sets the advertisement's brand</sets>

        public virtual string adBrand
        {
            get
            {
                return adbrand;
            }
            set
            {
                this.adbrand = value;
            }
        }

        /// <returns> Returns the advertisement's PCC code </returns>
        /// <sets>Sets the advertisement's PCC code</sets>

        public virtual string adPcc
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

        /// <returns> Returns the advertisement's URL </returns>
        /// <sets>Sets the advertisement's URL</sets>

        public virtual string adUrl
        {
            get
            {
                return adURL;
            }
            set
            {
                this.adURL = value;
            }
        }

        /// <returns> Returns the advertisement's Campaign ID </returns>
        /// <sets>Sets the advertisement's Campaign ID</sets>

        public virtual string adCampId
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

            if (int.ReferenceEquals(adID, null))
            {
                return false;
            }
            if (string.ReferenceEquals(adtitle, null))
            {
                 return false;
            }
            if (int.ReferenceEquals(addemo01, null))
            {
                return false;
            }
            if (int.ReferenceEquals(addemo02, null))
            {
                return false;
            }
            if (int.ReferenceEquals(addemo03, null))
            {
                return false;
            }
            if (int.ReferenceEquals(addemo04, null))
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
            if (string.ReferenceEquals(adbrand, null))
            {
                return false;
            }
            if (int.ReferenceEquals(adPCC, null))
            {
                return false;
            }
            if (int.ReferenceEquals(adURL, null))
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
        /// <param name="adID"></param>
        /// <param name="adtitle"> </param>
        /// <param name="addemo01"> </param>
        /// <param name="addemo02"> </param>
        /// <param name="addemo03"></param>
        /// <param name="addemo04"></param>
        /// <param name="addescription"></param>
        /// <param name="adowner"></param>
        /// <param name="adbrand"></param>
        /// <param name="adPCC"></param>
        /// <param name="adURL"></param>
        /// <param name="adCampID"></param>

        public virtual bool Equals(advertisement advertisement)


                {

                if (!adID.Equals(advertisement.adID))
                {
                    return false;
                }

                if (!adtitle.Equals(advertisement.adtitle))
                {
                    return false;
                }
                if (!addemo01.Equals(advertisement.addemo01))
                {
                    return false;
                }
                if (!addemo02.Equals(advertisement.addemo02))
                {
                    return false;
                }

                if (!addemo03.Equals(advertisement.addemo03))
                {
                    return false;
                }
                if (!addemo04.Equals(advertisement.addemo04))
                {
                    return false;
                }
                if (!addescription.Equals(advertisement.addescription))
                {
                    return false;
                }

                if (!adowner.Equals(advertisement.adowner))
                {
                    return false;
                }
                if (!adbrand.Equals(advertisement.adbrand))
                {
                    return false;
                }
                if (!adPCC.Equals(advertisement.adPCC))
                {
                    return false;
                }
                if (!adURL.Equals(advertisement.adURL))
                {
                    return false;
                }
                if (!adCampID.Equals(advertisement.adCampID))
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
                strBfr.Append("adID:");
                strBfr.Append(adID);
                strBfr.Append("\nadtitle:");
                strBfr.Append(adtitle);
                strBfr.Append("\naddemo01:");
                strBfr.Append(addemo01);
                strBfr.Append("\naddemo02:");
                strBfr.Append(addemo02);
                strBfr.Append("\naddemo03:");
                strBfr.Append(addemo03);
                strBfr.Append("\naddemo04:");
                strBfr.Append(addemo04);
                strBfr.Append("\naddescription:");
                strBfr.Append(addescription);
                strBfr.Append("\nadowner:");
                strBfr.Append(adowner);
                strBfr.Append("\nadbrand:");
                strBfr.Append(adbrand);
                strBfr.Append("\nadPCC:");
                strBfr.Append(adPCC);
                strBfr.Append("\nadURL:");
                strBfr.Append(adURL);
                strBfr.Append("\nadCampID:");
                strBfr.Append(adCampID);
            return strBfr.ToString();
            }
       
    }
}
