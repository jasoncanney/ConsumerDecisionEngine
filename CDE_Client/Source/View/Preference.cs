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
    public partial class Preference : MetroFramework.Forms.MetroForm
    {
        public Preference(Main parent)
        {
            InitializeComponent();
            this.MdiParent = parent;

        }

        private void Preference_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            preference preference = new GenAdxCDE.Source.Model.Domain.preference();
            preference.PreferenceId = Int32.Parse(preferenceIDtextBox.Text);
            preference.PreferenceGsSegment = Int32.Parse(gsSegmenttextBox.Text);
            preference.PreferenceCaTypeCode = Int32.Parse(CATypeCodetextBox.Text);
            preference.PreferenceCaValueCode = Int32.Parse(CAValueCodetextBox.Text);
            preference.PreferenceBrandOwner = BrandOwnertextBox.Text;
            preference.PreferenceProductDesc = ProductDesctextBox.Text;
            preference.PreferenceDate = PreferenceTextBox.Text;
            preference.ConsumerId = Int32.Parse(ConsumerIDtextBox.Text);

            preferenceManager PrefMgr = new preferenceManager();
            PrefMgr.Create(preference);

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            this.InitializeComponent();
        }

        private void consumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit the application
            System.Windows.Forms.Application.Exit();
        }

        private void couponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void advertisementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FormAdvertisement h3 = new FormAdvertisement(); // Instantiate a Form3 object.
            // h3.ShowDialog(); // Show Form3 and
            // this.Close(); // closes the Form2 instance.
        }

        private void consumerHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FormConsumerHistory i3 = new FormConsumerHistory(); // Instantiate a Form3 object.
            // i3.ShowDialog(); // Show Form3 and
            // this.Close(); // closes the Form2 instance.
        }
    }
}
