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
    public partial class CouponMgr : MetroFramework.Forms.MetroForm
    {
        private DataGridView dataGridView1 = new DataGridView();

        public CouponMgr(Main parent)
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

        private void CouponMgr_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {


            coupon coupon = new GenAdxCDE.Source.Model.Domain.coupon();
            coupon.CouponID = Int32.Parse(couponIDtextBox.Text);
            coupon.CouponTitle = TitletextBox.Text;
            coupon.CouponDescription = DescriptiontextBox.Text;
            coupon.CouponValue = ValuetextBox.Text;
            coupon.CouponStartActive = StartActtextBox.Text;
            coupon.CouponEndActive = EndActtextBox.Text;
            coupon.CouponLocationsZip = ActZiptextBox.Text;
            

            couponManager CoupMgr = new couponManager();
            if (CoupMgr.Create(coupon))
            {
                MessageBox.Show("Successfully Created Coupon");
            }
            else
            {
                MessageBox.Show("Unsuccessful Create of Coupon");

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
            couponManager CoupMgr = new couponManager();
            DataTable dt = new DataTable();
            dt = CoupMgr.Find();
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

            coupon coupon = new GenAdxCDE.Source.Model.Domain.coupon();
            coupon.CouponID = Int32.Parse(couponIDtextBox.Text);
            coupon.CouponTitle = TitletextBox.Text;
            coupon.CouponDescription = DescriptiontextBox.Text;
            coupon.CouponValue = ValuetextBox.Text;
            coupon.CouponStartActive = StartActtextBox.Text;
            coupon.CouponEndActive = EndActtextBox.Text;
            coupon.CouponLocationsZip = ActZiptextBox.Text;

       

            couponManager CoupMgr = new couponManager();
            if (CoupMgr.Delete(coupon))
            {
                MessageBox.Show("Successfully Deleted Coupon");
            }
            else
            {
                MessageBox.Show("Unsuccessful Delete of Coupon");

            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

            coupon coupon = new GenAdxCDE.Source.Model.Domain.coupon();
            coupon.CouponID = Int32.Parse(couponIDtextBox.Text);
            coupon.CouponTitle = TitletextBox.Text;
            coupon.CouponDescription = DescriptiontextBox.Text;
            coupon.CouponValue = ValuetextBox.Text;
            coupon.CouponStartActive = StartActtextBox.Text;
            coupon.CouponEndActive = EndActtextBox.Text;
            coupon.CouponLocationsZip = ActZiptextBox.Text;

            couponManager CoupMgr = new couponManager();
            if (CoupMgr.Update(coupon))
            {
                MessageBox.Show("Successfully Updated Consumer "+ coupon.CouponID);
            }
            else
            {
                MessageBox.Show("Unsuccessful Delete of Consumer " + coupon.CouponID);

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                couponIDtextBox.Text = row.Cells["couponID"].Value.ToString();
                TitletextBox.Text = row.Cells["couponTitle"].Value.ToString();
                DescriptiontextBox.Text = row.Cells["couponDescription"].Value.ToString();
                ValuetextBox.Text = row.Cells["couponValue"].Value.ToString();
                StartActtextBox.Text = row.Cells["couponStartActive"].Value.ToString();
                EndActtextBox.Text = row.Cells["couponEndActive"].Value.ToString();
                ActZiptextBox.Text = row.Cells["couponLocationsZip"].Value.ToString();
            }
            }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            couponIDtextBox.Clear();
            TitletextBox.Clear();
            DescriptiontextBox.Clear();
            ValuetextBox.Clear();
            StartActtextBox.Clear();
            EndActtextBox.Clear();
            ActZiptextBox.Clear();
        }
    }
}
