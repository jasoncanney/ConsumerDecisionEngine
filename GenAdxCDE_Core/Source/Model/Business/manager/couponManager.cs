using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenAdxCDE.Source.Model.Services.couponservice;
using GenAdxCDE.Source.Model.Services;
using System.Threading.Tasks;
using GenAdxCDE.Source.Model.Domain;
using System.Data;

namespace GenAdxCDE.Source.Model.Business
{
    public class couponManager : ManagerSuperType
    {
        /// <summary>
        /// Business use case for "store coupon"
        /// </summary>
        /// <param name="c"></param>
        public bool Create(coupon c)
        {
            Factory factory = Factory.GetInstance();
            ICouponSvc coupSvc = (ICouponSvc)factory.getService("ICouponSvc");
            coupSvc.storeCoupon(c);
            return true;
        }

        /// <summary>
        /// Business use case for "retrieve coupon"
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable Find()
        {
            Factory factory = Factory.GetInstance();
            ICouponSvc coupSvc = (ICouponSvc)factory.getService("ICouponSvc");
            return coupSvc.getCoupon();
        }
        /// <summary>
        /// Business use case for "update coupon"
        /// </summary>
        /// <param name="c"></param>
        public bool Update(coupon c)
        {
            Factory factory = Factory.GetInstance();
            ICouponSvc coupSvc = (ICouponSvc)factory.getService("ICouponSvc");
            coupSvc.updateCoupon(c);
            return true;

        }

        /// <summary>
        /// Business use case for "delete coupon"
        /// </summary>
        /// <param name="c"></param>
        public bool Delete(coupon c)
        {
            Factory factory = Factory.GetInstance();
            ICouponSvc coupSvc = (ICouponSvc)factory.getService("ICouponSvc");
            coupSvc.deleteCoupon(c);
            return true;
        }

    }
}
