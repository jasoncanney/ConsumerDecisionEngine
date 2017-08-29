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
    public partial class ConsumerHistoryMgr : MetroFramework.Forms.MetroForm
    {
        private DataGridView dataGridView1 = new DataGridView();

        public ConsumerHistoryMgr(Main parent)
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

        private void FormConsumerHistoryMgr_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consumerHistory consumerHistory = new GenAdxCDE.Source.Model.Domain.consumerHistory();

            consumerHistory.ConsumerID = Int32.Parse(consumerIDtextBox.Text);
            consumerHistory.PreferenceID = Int32.Parse(preferenceIDtextBox.Text);
            consumerHistory.PreferenceDate = prefDatetextBox.Text;
            consumerHistory.PreferenceChoice = Int32.Parse(prefChoicetextBox.Text);
            consumerHistory.AdvertisementID = Int32.Parse(adIDtextBox.Text);
            consumerHistory.CouponID = Int32.Parse(couponIDtextBox.Text);

            consumerHistoryManager ConsMgr = new consumerHistoryManager();
            if (ConsMgr.Create(consumerHistory))
            {
                MessageBox.Show("Successfully Created consumerHistory");
            }
            else
            {
                MessageBox.Show("Unsuccessful Create of consumerHistory");

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
            consumerHistoryManager ConsMgr = new consumerHistoryManager();
            DataTable dt = new DataTable();
            // List<consumer> cons = new List<consumer>();
            dt = ConsMgr.Find();
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
            consumerHistory consumerHistory = new GenAdxCDE.Source.Model.Domain.consumerHistory();

            consumerHistory.ConsumerID = Int32.Parse(consumerIDtextBox.Text);
            consumerHistory.PreferenceID = Int32.Parse(preferenceIDtextBox.Text);
            consumerHistory.PreferenceDate = prefDatetextBox.Text;
            consumerHistory.PreferenceChoice = Int32.Parse(prefChoicetextBox.Text);
            consumerHistory.AdvertisementID = Int32.Parse(adIDtextBox.Text);
            consumerHistory.CouponID = Int32.Parse(couponIDtextBox.Text);


            consumerHistoryManager ConsMgr = new consumerHistoryManager();
            if (ConsMgr.Delete(consumerHistory))
            {
                MessageBox.Show("Successfully Deleted Consumer History");
            }
            else
            {
                MessageBox.Show("Unsuccessful Delete of Consumer History");

            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            consumerHistory consumerHistory = new GenAdxCDE.Source.Model.Domain.consumerHistory();

            consumerHistory.ConsumerID = Int32.Parse(consumerIDtextBox.Text);
            consumerHistory.PreferenceID = Int32.Parse(preferenceIDtextBox.Text);
            consumerHistory.PreferenceDate = prefDatetextBox.Text;
            consumerHistory.PreferenceChoice = Int32.Parse(prefChoicetextBox.Text);
            consumerHistory.AdvertisementID = Int32.Parse(adIDtextBox.Text);
            consumerHistory.CouponID = Int32.Parse(couponIDtextBox.Text);


            consumerHistoryManager ConsMgr = new consumerHistoryManager();
            if (ConsMgr.Update(consumerHistory))
            {
                MessageBox.Show("Successfully Updated Consumer History "+ consumerHistory.ConsumerID);
            }
            else
            {
                MessageBox.Show("Unsuccessful Delete of Consumer History " + consumerHistory.ConsumerID);

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow dvr = new DataGridViewRow();
            //dvr = dataGridView2.SelectedRows();

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                consumerIDtextBox.Text = row.Cells["consumerID"].Value.ToString();
                preferenceIDtextBox.Text = row.Cells["preferenceID"].Value.ToString();
                prefDatetextBox.Text = row.Cells["preferenceDate"].Value.ToString();
                prefChoicetextBox.Text = row.Cells["preferenceChoice"].Value.ToString();
                adIDtextBox.Text = row.Cells["advertisementID"].Value.ToString();
                couponIDtextBox.Text = row.Cells["couponID"].Value.ToString();
            }
            }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            consumerIDtextBox.Clear();
            preferenceIDtextBox.Clear();
            prefDatetextBox.Clear();
            prefChoicetextBox.Clear();
            adIDtextBox.Clear();
            couponIDtextBox.Clear();
            
        }
    }
}
