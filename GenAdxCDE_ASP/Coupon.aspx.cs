using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GenAdxCDE.Source.Model.Domain;
using GenAdxCDE.Source.Model.Business;
using System.Windows.Forms;

namespace GenAdxCDE
{
    public partial class Coupon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            coupon coupon = new GenAdxCDE.Source.Model.Domain.coupon()
            {
                CouponID = Int32.Parse(TextBox1.Text),
                CouponTitle = TextBox2.Text,
                CouponDescription = TextBox3.Text,
                CouponValue = TextBox4.Text,
                CouponStartActive = TextBox5.Text,
                CouponEndActive = TextBox6.Text,
                CouponLocationsZip = TextBox7.Text
            };
            

            try
            {
                couponManager cMgr = new couponManager();
                cMgr.Create(coupon);

            }
            catch
            {

                // Display a message box informing the user that the calculations 
                // are complete
                MessageBox.Show("Un-Successful Creation of Coupon Object ", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }

            // Display a message box informing the user that the calculations 
            // are complete
            MessageBox.Show("Successful Creation of Coupon Object ", "",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}