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
    public partial class PreferenceMgr : MetroFramework.Forms.MetroForm
    {
        private DataGridView dataGridView1 = new DataGridView();

        public PreferenceMgr(Main parent)
        {
            InitializeComponent();
            this.MdiParent = parent;



            // DATAGRIDVIEW PROPERTIES
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "First";
            dataGridView1.Columns[2].Name = "Middle";
            dataGridView1.Columns[3].Name = "Last";
            dataGridView1.Columns[4].Name = "Email";
            dataGridView1.Columns[5].Name = "Phone";
            dataGridView1.Columns[6].Name = "Address";
            dataGridView1.Columns[7].Name = "City";
            dataGridView1.Columns[8].Name = "State";
            dataGridView1.Columns[9].Name = "Zip";
            dataGridView1.Columns[10].Name = "SocEmail";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // SELECTION MODE
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;



        }

        private void PreferenceMgr_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            preference preference = new GenAdxCDE.Source.Model.Domain.preference();
            preference.PreferenceId = Int32.Parse(preferenceIDtextBox.Text);
            preference.PreferenceGsSegment = Int32.Parse(GSSegmenttextBox.Text);
            preference.PreferenceCaTypeCode = Int32.Parse(CATypeCodetextBox.Text);
            preference.PreferenceCaValueCode = Int32.Parse(CAValueCodetextBox.Text);
            preference.PreferenceBrandOwner = BrandOwnertextBox.Text;
            preference.PreferenceProductDesc = DescriptiontextBox.Text;
            preference.PreferenceDate = DatetextBox.Text;
            preference.ConsumerId = Int32.Parse(ConsumerIDtextBox.Text);


            preferenceManager PrefMgr = new preferenceManager();
            if (PrefMgr.Create(preference))
            {
                MessageBox.Show("Successfully Created Preference");
            }
            else
            {
                MessageBox.Show("Unsuccessful Create of Preference");

            }

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

        private void consumerHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void advertisementToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //  FormAdvertisement i3 = new FormAdvertisement(); // Instantiate a Form3 object.
            // i3.ShowDialog(); // Show Form3 and
            // this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            preferenceManager PrefMgr = new preferenceManager();
            DataTable dt = new DataTable();
            dt = PrefMgr.Find();
            dataGridView2.ReadOnly = false;
            dataGridView2.DataSource = dt;


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consumerManagerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            preference preference = new GenAdxCDE.Source.Model.Domain.preference();
            preference.PreferenceId = Int32.Parse(preferenceIDtextBox.Text);
            preference.PreferenceGsSegment = Int32.Parse(GSSegmenttextBox.Text);
            preference.PreferenceCaTypeCode = Int32.Parse(CATypeCodetextBox.Text);
            preference.PreferenceCaValueCode = Int32.Parse(CAValueCodetextBox.Text);
            preference.PreferenceBrandOwner = BrandOwnertextBox.Text;
            preference.PreferenceProductDesc = DescriptiontextBox.Text;
            preference.PreferenceDate = DatetextBox.Text;
            preference.ConsumerId = Int32.Parse(ConsumerIDtextBox.Text);

            preferenceManager PrefMgr = new preferenceManager();
            if (PrefMgr.Delete(preference))
            {
                MessageBox.Show("Successfully Deleted Preference");
            }
            else
            {
                MessageBox.Show("Unsuccessful Delete of Preference");

            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            preference preference = new GenAdxCDE.Source.Model.Domain.preference();
            preference.PreferenceId = Int32.Parse(preferenceIDtextBox.Text);
            preference.PreferenceGsSegment = Int32.Parse(GSSegmenttextBox.Text);
            preference.PreferenceCaTypeCode = Int32.Parse(CATypeCodetextBox.Text);
            preference.PreferenceCaValueCode = Int32.Parse(CAValueCodetextBox.Text);
            preference.PreferenceBrandOwner = BrandOwnertextBox.Text;
            preference.PreferenceProductDesc = DescriptiontextBox.Text;
            preference.PreferenceDate = DatetextBox.Text;
            preference.ConsumerId = Int32.Parse(ConsumerIDtextBox.Text);

            preferenceManager PrefMgr = new preferenceManager();
            if (PrefMgr.Update(preference))
            {
                MessageBox.Show("Successfully Updated Preference "+ preference.PreferenceId);
            }
            else
            {
                MessageBox.Show("Unsuccessful Delete of Preference " + preference.PreferenceId);

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow dvr = new DataGridViewRow();
            //dvr = dataGridView2.SelectedRows();

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                preferenceIDtextBox.Text = row.Cells["preferenceID"].Value.ToString();
                GSSegmenttextBox.Text = row.Cells["preferenceGsSegment"].Value.ToString();
                CATypeCodetextBox.Text = row.Cells["preferenceCaTypeCode"].Value.ToString();
                CAValueCodetextBox.Text = row.Cells["preferenceCaValueCode"].Value.ToString();
                BrandOwnertextBox.Text = row.Cells["preferenceBrandOwner"].Value.ToString();
                DescriptiontextBox.Text = row.Cells["preferenceProductDesc"].Value.ToString();
                DatetextBox.Text = row.Cells["preferenceDate"].Value.ToString();
                ConsumerIDtextBox.Text = row.Cells["consumerID"].Value.ToString();
                
            }
            }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            preferenceIDtextBox.Clear();
            GSSegmenttextBox.Clear();
            CATypeCodetextBox.Clear();
            CAValueCodetextBox.Clear();
            BrandOwnertextBox.Clear();
            DescriptiontextBox.Clear();
            DatetextBox.Clear();
            ConsumerIDtextBox.Clear();
        }
    }
}
