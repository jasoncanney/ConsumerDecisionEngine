using System;
using System.Collections.Generic;
using GenAdxCDE.Source.Model.Domain;
using System.Data;

namespace GenAdxCDE.Source.Model.Services.couponservice
{
    /// <summary>
    /// This interface defines methods for persisting of coupon.cs
    /// to and from a file system
    /// @author Jason L. Canney </summary>
    /// <param name="NAME"> is a string used to identify the service
    ///  </param>
    public interface ICouponSvc : IService
    {

        /// <summary>
        /// Persists a coupon
        /// The storeCoupon takes in a coupon object as input and will pass it to the CouponSvcSQLImpl </summary>
        /// <param name="coupon"> The coupon to be persisted </param>
        /// <returns> boolean true/false </returns>
        /// <exception cref="CouponException">  </exception>

        void storeCoupon(coupon coupon);

        /// <summary>
        /// Retrieves a coupon
        /// The getCoupon takes an ID as an argument and retrieves it through the CouponSvcSQLImpl class </summary>
        /// <param name="none"> The unique identifier for the coupon to be retrieved </param>
        /// <returns> The collection </returns>
        /// <exception cref="CouponException"> </exception>
        /// <exception cref="ClassNotFoundException">  </exception>

        DataTable getCoupon();

        /// <summary>
        /// Updates a coupon
        /// The updateCoupon takes in a coupon object as input and will pass it to the CouponSvcImpl </summary>
        /// <param name="coupon"> The consumer to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="CouponException">  </exception>

        void updateCoupon(coupon coupon);

        /// <summary>
        /// delete a coupon
        /// The deleteCoupon takes in a coupon object as input and will pass it to the CouponSvcImpl </summary>
        /// <param name="coupon"> The consumer to be updated</param>
        /// <returns> void </returns>
        /// <exception cref="CouponException">  </exception>

        void deleteCoupon(coupon coupon);
    }
}