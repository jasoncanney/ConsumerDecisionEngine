using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GenAdxCDE.Source.Model.Domain;
using GenAdxCDE.Source.Model.Business;
using System.Windows.Forms;

namespace GenAdxCDE
{
    public partial class Consumer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            consumer consumer = new GenAdxCDE.Source.Model.Domain.consumer()
            {
                // ConsumerID = Int32.Parse(TextBox1.Text),
                ConsumerFirstName = TextBox2.Text,
                ConsumerMiddleInitial = TextBox3.Text,
                ConsumerLastName = TextBox4.Text,
                ConsumerEmail = TextBox5.Text,
                ConsumerPhone = TextBox6.Text,
                ConsumerAddress = TextBox7.Text,
                ConsumerCity = TextBox8.Text,
                ConsumerState = TextBox9.Text,
                ConsumerZip = TextBox10.Text,
                ConsumerSocEmail = TextBox11.Text
            };

            try
            {
            consumerManager ConMgr = new consumerManager();
            ConMgr.Create(consumer);

            }
            catch {

                // Display a message box informing the user that the calculations 
                // are complete
                MessageBox.Show("Un-Successful Creation of Consumer Object ", consumer.ConsumerSocEmail,
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }
            
            // Display a message box informing the user that the calculations 
            // are complete
            MessageBox.Show("Successful Creation of Consumer Object ", consumer.ConsumerSocEmail,
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

        }
    }
}