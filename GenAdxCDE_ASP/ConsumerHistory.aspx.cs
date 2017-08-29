using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GenAdxCDE.Source.Model.Business;
using GenAdxCDE.Source.Model.Domain;
using System.Windows.Forms;

namespace GenAdxCDE
{
    public partial class ConsumerHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            consumerHistory consumerHistory = new GenAdxCDE.Source.Model.Domain.consumerHistory()
            {
                ConsumerID = Int32.Parse(TextBox1.Text),
                PreferenceID = Int32.Parse(TextBox2.Text),
                PreferenceDate = TextBox3.Text,
                PreferenceChoice = Int32.Parse(TextBox4.Text),
                AdvertisementID = Int32.Parse(TextBox5.Text),
                CouponID = Int32.Parse(TextBox6.Text)
            };

            try
            {
                consumerHistoryManager cHistMgr = new consumerHistoryManager();
                cHistMgr.Create(consumerHistory);

            }
            catch
            {

                // Display a message box informing the user that the calculations 
                // are complete
                MessageBox.Show("Un-Successful Creation of ConsumerHistory Object ", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }

            // Display a message box informing the user that the calculations 
            // are complete
            MessageBox.Show("Successful Creation of ConsumerHistory Object ", "",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            
        }
    }
}