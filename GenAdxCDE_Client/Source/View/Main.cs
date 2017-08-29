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
using GenAdxCDE.Source.View;

namespace GenAdxCDE.Source.View
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
            // Preference child = new Preference(this); // Instantiate a Form3 object.
            // child.Show(); // Show Form3 and
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit the application
            System.Windows.Forms.Application.Exit();

        }

        private void consumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FormConsumer child = new FormConsumer(this); // Instantiate a Form3 object.
            // child.Show(); // Show Form3 and
        }

        private void couponToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void consumerHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ConsumerHistoryMgr child = new ConsumerHistoryMgr(this); // Instantiate a Form3 object.
           child.Show(); // Show Form3 and
        }

        private void advertisementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvertisementMgr child = new AdvertisementMgr(this);
            child.Show();
        }

        private void consumerMgrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsumerMgr child = new ConsumerMgr(this);
            child.Show();
        }

        private void couponMgrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CouponMgr child = new CouponMgr(this);
            child.Show();
        }

        private void preferenceMgrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferenceMgr child = new PreferenceMgr(this);
            child.Show();
        }
    }
}
