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
    public partial class Advertisement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            advertisement advertisement = new GenAdxCDE.Source.Model.Domain.advertisement()
            {
                adId = Int32.Parse(TextBox1.Text),
                adTitle = TextBox2.Text,
                adDemo01 = Int32.Parse(TextBox3.Text),
                adDemo02 = Int32.Parse(TextBox4.Text),
                adDemo03 = Int32.Parse(TextBox5.Text),
                adDemo04 = Int32.Parse(TextBox6.Text),
                adDescription = TextBox7.Text,
                adOwner = TextBox8.Text,
                adBrand = TextBox9.Text,
                adPcc = TextBox10.Text,
                adUrl = TextBox11.Text,
                adCampId = TextBox12.Text
            };

               

            try
            {
                 adManager adMgr = new adManager();
                adMgr.Create(advertisement);

            }
            catch
            {

                // Display a message box informing the user that the calculations 
                // are complete
                MessageBox.Show("Un-Successful Creation of Advertisement Object ", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }

            // Display a message box informing the user that the calculations 
            // are complete
            MessageBox.Show("Successful Creation of Advertisement Object ", "",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}