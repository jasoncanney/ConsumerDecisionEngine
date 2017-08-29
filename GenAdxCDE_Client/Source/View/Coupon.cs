using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenAdxCDE.Source.Model.Domain;
using GenAdxCDE.Source.Model.Business;

namespace GenAdxCDE.Source.View
{
    public partial class Coupon : MetroFramework.Forms.MetroForm
    {
        public Coupon(Main parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        private void Coupon_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            coupon coupon = new GenAdxCDE.Source.Model.Domain.coupon();
            coupon.CouponID = Int32.Parse(couponIDtextBox.Text);
            coupon.CouponTitle = couponTitletextBox.Text;
            coupon.CouponDescription = couponDesctextBox.Text;
            coupon.CouponValue = float.Parse(CouponValuetextBox.Text);
            coupon.CouponStartActive = couponStarttextBox.Text;
            coupon.CouponEndActive = couponEndtextBox.Text;
            coupon.CouponLocationsZip = couponLocationtextBox.Text;

            couponManager CoupMgr = new couponManager();
            CoupMgr.Create(coupon);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void consumerIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddleInitialtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddresstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZiptextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SOCEmailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            this.InitializeComponent();
        }

        private void preferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit the application
            System.Windows.Forms.Application.Exit();

        }

        private void consumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void advertisementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consumerHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FormConsumerHistory C3 = new FormConsumerHistory(); // Instantiate a Form3 object.
            // C3.ShowDialog(); // Show Form3 and
            // this.Close();
        }
    }
}
