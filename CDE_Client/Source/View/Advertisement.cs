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
    public partial class Advertisement : MetroFramework.Forms.MetroForm
    {
        public Advertisement(Main parent)
        {
            InitializeComponent();
            this.MdiParent = parent;

        }

        private void Advertisement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            advertisement advertisement = new GenAdxCDE.Source.Model.Domain.advertisement();
            advertisement.adId = Int32.Parse(adIDtextBox.Text);
            advertisement.adTitle = adTitletextBox.Text;
            advertisement.adDemo01 = Int32.Parse(adDemo01textBox.Text);
            advertisement.adDemo02 = Int32.Parse(adDemo02textBox.Text);
            advertisement.adDemo03 = Int32.Parse(adDemo03textBox.Text);
            advertisement.adDemo04 = Int32.Parse(adDemo04textBox.Text);
            advertisement.adDescription = adDescriptiontextBox.Text;
            advertisement.adOwner = adOwnertextBox.Text;
            advertisement.adBrand = adBrandTextBox.Text;
             advertisement.adGsSegment = Int32.Parse(adGsSegmentTextBox.Text);
            advertisement.adCaTypeCode = Int32.Parse(adCaTypeCodetextBox.Text);
            advertisement.adCaValueCode = Int32.Parse(adCaValueCodeTextbox.Text);

            adManager adMgr = new adManager();
            adMgr.Create(advertisement);
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

        private void couponToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void consumerHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {


          
        }
    }
}
