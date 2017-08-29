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
    public partial class ConsumerHistory : MetroFramework.Forms.MetroForm
    {
        public ConsumerHistory(Main parent)
        {
            InitializeComponent();
            this.MdiParent = parent;

        }

        private void ConsumerHistory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consumerHistory consumerHistory = new GenAdxCDE.Source.Model.Domain.consumerHistory();
            consumerHistory.ConsumerID = Int32.Parse(consumerIDtextBox.Text);
            consumerHistory.PreferenceID = Int32.Parse(preferenceIDtextBox.Text);
            consumerHistory.PreferenceDate = preferenceDatetextBox.Text;
            consumerHistory.PreferenceChoice = Int32.Parse(PreferenceChoicetextBox.Text);
            consumerHistory.AdvertisementID = Int32.Parse(advertisementIDtextBox.Text);
            consumerHistory.CouponID = Int32.Parse(coupontextBox.Text);

            consumerHistoryManager ConHistMgr = new consumerHistoryManager();
            ConHistMgr.Create(consumerHistory);
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
           //  FormCoupon C3 = new FormCoupon(); // Instantiate a Form3 object.
           //  C3.ShowDialog(); // Show Form3 and
           //  this.Close();
        }
    }
}
