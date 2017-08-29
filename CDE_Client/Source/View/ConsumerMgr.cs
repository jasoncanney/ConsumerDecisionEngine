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
    public partial class ConsumerMgr : MetroFramework.Forms.MetroForm
    {
        private DataGridView dataGridView1 = new DataGridView();

        public ConsumerMgr(Main parent)
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

        private void FormConsumer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consumer consumer = new GenAdxCDE.Source.Model.Domain.consumer();
            consumer.ConsumerID = Int32.Parse(consumerIDtextBox.Text);
            consumer.ConsumerFirstName = FirstNametextBox.Text;
            consumer.ConsumerMiddleInitial = MiddleInitialtextBox.Text;
            consumer.ConsumerLastName = LastNametextBox.Text;
            consumer.ConsumerAddress = AddresstextBox.Text;
            consumer.ConsumerCity = CitytextBox.Text;
            consumer.ConsumerState = StatetextBox.Text;
            consumer.ConsumerZip = ZiptextBox.Text;
            consumer.ConsumerPhone = phoneTextBox.Text;
            consumer.ConsumerEmail = emailTextBox.Text;
            consumer.ConsumerSocEmail = SOCEmailtextBox.Text;

            consumerManager ConsMgr = new consumerManager();
            if (ConsMgr.Create(consumer))
            {
                MessageBox.Show("Successfully Created Consumer");
            }
            else
            {
                MessageBox.Show("Unsuccessful Create of Consumer");

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
            consumerManager ConsMgr = new consumerManager();
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
            consumer consumer = new GenAdxCDE.Source.Model.Domain.consumer();
            consumer.ConsumerID = Int32.Parse(consumerIDtextBox.Text);
            consumer.ConsumerFirstName = FirstNametextBox.Text;
            consumer.ConsumerMiddleInitial = MiddleInitialtextBox.Text;
            consumer.ConsumerLastName = LastNametextBox.Text;
            consumer.ConsumerAddress = AddresstextBox.Text;
            consumer.ConsumerCity = CitytextBox.Text;
            consumer.ConsumerState = StatetextBox.Text;
            consumer.ConsumerZip = ZiptextBox.Text;
            consumer.ConsumerPhone = phoneTextBox.Text;
            consumer.ConsumerEmail = emailTextBox.Text;
            consumer.ConsumerSocEmail = SOCEmailtextBox.Text;

            consumerManager ConsMgr = new consumerManager();
            if (ConsMgr.Delete(consumer))
            {
                MessageBox.Show("Successfully Deleted Consumer");
            }
            else
            {
                MessageBox.Show("Unsuccessful Delete of Consumer");

            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            consumer consumer = new GenAdxCDE.Source.Model.Domain.consumer();
            consumer.ConsumerID = Int32.Parse(consumerIDtextBox.Text);
            consumer.ConsumerFirstName = FirstNametextBox.Text;
            consumer.ConsumerMiddleInitial = MiddleInitialtextBox.Text;
            consumer.ConsumerLastName = LastNametextBox.Text;
            consumer.ConsumerAddress = AddresstextBox.Text;
            consumer.ConsumerCity = CitytextBox.Text;
            consumer.ConsumerState = StatetextBox.Text;
            consumer.ConsumerZip = ZiptextBox.Text;
            consumer.ConsumerPhone = phoneTextBox.Text;
            consumer.ConsumerEmail = emailTextBox.Text;
            consumer.ConsumerSocEmail = SOCEmailtextBox.Text;

            consumerManager ConsMgr = new consumerManager();
            if (ConsMgr.Update(consumer))
            {
                MessageBox.Show("Successfully Updated Consumer "+ consumer.ConsumerID);
            }
            else
            {
                MessageBox.Show("Unsuccessful Delete of Consumer " + consumer.ConsumerID);

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
                FirstNametextBox.Text = row.Cells["consumerFirstName"].Value.ToString();
                MiddleInitialtextBox.Text = row.Cells["consumerMiddleInitial"].Value.ToString();
                LastNametextBox.Text = row.Cells["consumerLastName"].Value.ToString();
                AddresstextBox.Text = row.Cells["consumerAddress"].Value.ToString();
                CitytextBox.Text = row.Cells["consumerCity"].Value.ToString();
                StatetextBox.Text = row.Cells["consumerState"].Value.ToString();
                ZiptextBox.Text = row.Cells["consumerZip"].Value.ToString();
                phoneTextBox.Text = row.Cells["consumerPhone"].Value.ToString();
                emailTextBox.Text = row.Cells["consumerEmail"].Value.ToString();
                SOCEmailtextBox.Text = row.Cells["consumerSocEmail"].Value.ToString();
            }
            }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            consumerIDtextBox.Clear();
            FirstNametextBox.Clear();
            MiddleInitialtextBox.Clear();
            LastNametextBox.Clear();
            AddresstextBox.Clear();
            CitytextBox.Clear();
            StatetextBox.Clear();
            ZiptextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();
            SOCEmailtextBox.Clear();
        }
    }
}
