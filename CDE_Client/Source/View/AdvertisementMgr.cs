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
    public partial class AdvertisementMgr : MetroFramework.Forms.MetroForm
    {
        private DataGridView dataGridView1 = new DataGridView();

        public AdvertisementMgr(Main parent)
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

        private void FormAdvertisement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            advertisement advertisement = new GenAdxCDE.Source.Model.Domain.advertisement();
            advertisement.adId = Int32.Parse(adIDtextBox.Text);
            advertisement.adTitle = titletextBox.Text;
            advertisement.adDemo01 = Int32.Parse(demo01textBox.Text);
            advertisement.adDemo02 = Int32.Parse(demo02textBox.Text);
            advertisement.adDemo03 = Int32.Parse(demo03textBox.Text);
            advertisement.adDemo04 = Int32.Parse(demo04textBox.Text);
            advertisement.adDescription = DesctextBox.Text;
            advertisement.adOwner = OwnertextBox.Text;
            advertisement.adPcc = GsSegmentTextBox.Text;
            advertisement.adBrand = BrandTextBox.Text;
            advertisement.adUrl = TypeCodetextBox.Text;
            advertisement.adCampId = ValueCodetextBox.Text;

            adManager AdMgr = new adManager();
            if (AdMgr.Create(advertisement))
            {
                MessageBox.Show("Successfully Created advertisement");
            }
            else
            {
                MessageBox.Show("Unsuccessful Create of advertisement");

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
            adManager AdMgr = new adManager();
            DataTable dt = new DataTable();
            // List<consumer> cons = new List<consumer>();
            dt = AdMgr.Find();
            // foreach(DataRow row in dt.Rows)
            // {
            //     populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());

            //  }
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
            advertisement advertisement = new GenAdxCDE.Source.Model.Domain.advertisement();
            advertisement.adId = Int32.Parse(adIDtextBox.Text);
            advertisement.adTitle = titletextBox.Text;
            advertisement.adDemo01 = Int32.Parse(demo01textBox.Text);
            advertisement.adDemo02 = Int32.Parse(demo02textBox.Text);
            advertisement.adDemo03 = Int32.Parse(demo03textBox.Text);
            advertisement.adDemo04 = Int32.Parse(demo04textBox.Text);
            advertisement.adDescription = DesctextBox.Text;
            advertisement.adOwner = OwnertextBox.Text;
            advertisement.adPcc = GsSegmentTextBox.Text;
            advertisement.adBrand = BrandTextBox.Text;
            advertisement.adUrl = TypeCodetextBox.Text;
            advertisement.adCampId = ValueCodetextBox.Text;

            adManager AdMgr = new adManager();
            if (AdMgr.Delete(advertisement))
            {
                MessageBox.Show("Successfully Deleted Advertisement");
            }
            else
            {
                MessageBox.Show("Unsuccessful Delete of Advertisement");

            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            advertisement advertisement = new GenAdxCDE.Source.Model.Domain.advertisement();
            advertisement.adId = Int32.Parse(adIDtextBox.Text);
            advertisement.adTitle = titletextBox.Text;
            advertisement.adDemo01 = Int32.Parse(demo01textBox.Text);
            advertisement.adDemo02 = Int32.Parse(demo02textBox.Text);
            advertisement.adDemo03 = Int32.Parse(demo03textBox.Text);
            advertisement.adDemo04 = Int32.Parse(demo04textBox.Text);
            advertisement.adDescription = DesctextBox.Text;
            advertisement.adOwner = OwnertextBox.Text;
            advertisement.adPcc = GsSegmentTextBox.Text;
            advertisement.adBrand = BrandTextBox.Text;
            advertisement.adUrl = TypeCodetextBox.Text;
            advertisement.adCampId = ValueCodetextBox.Text;

            adManager AdMgr = new adManager();
            if (AdMgr.Update(advertisement))
            {
                MessageBox.Show("Successfully Updated advertisement " + advertisement.adId);
            }
            else
            {
                MessageBox.Show("Unsuccessful Delete of advertisement " + advertisement.adId);

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow dvr = new DataGridViewRow();
            //dvr = dataGridView2.SelectedRows();

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                adIDtextBox.Text = row.Cells["adId"].Value.ToString();
                titletextBox.Text = row.Cells["adTitle"].Value.ToString();
                demo01textBox.Text = row.Cells["adDemo01"].Value.ToString();
                demo02textBox.Text = row.Cells["adDemo02"].Value.ToString();
                demo03textBox.Text = row.Cells["adDemo03"].Value.ToString();
                demo04textBox.Text = row.Cells["adDemo04"].Value.ToString();
                DesctextBox.Text = row.Cells["adDescription"].Value.ToString();
                OwnertextBox.Text = row.Cells["adOwner"].Value.ToString();
                GsSegmentTextBox.Text = row.Cells["adPCC"].Value.ToString();
                BrandTextBox.Text = row.Cells["adBrand"].Value.ToString();
                TypeCodetextBox.Text = row.Cells["adURL"].Value.ToString();
                ValueCodetextBox.Text = row.Cells["adCampID"].Value.ToString();

            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            adIDtextBox.Clear();
            titletextBox.Clear();
            demo01textBox.Clear();
            demo02textBox.Clear();
            demo03textBox.Clear();
            demo04textBox.Clear();
            DesctextBox.Clear();
            OwnertextBox.Clear();
            GsSegmentTextBox.Clear();
            BrandTextBox.Clear();
            TypeCodetextBox.Clear();
            ValueCodetextBox.Clear();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
