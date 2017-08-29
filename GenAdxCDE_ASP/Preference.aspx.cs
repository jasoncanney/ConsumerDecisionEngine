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
    public partial class Preference : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            preference preference = new GenAdxCDE.Source.Model.Domain.preference()
            {
                PreferenceId = Int32.Parse(TextBox1.Text),
                PreferenceGsSegment = Int32.Parse(TextBox2.Text),
                PreferenceCaTypeCode = Int32.Parse(TextBox3.Text),
                PreferenceCaValueCode = Int32.Parse(TextBox4.Text),
                PreferenceBrandOwner = TextBox5.Text,
                PreferenceProductDesc = TextBox6.Text,
                PreferenceDate = TextBox7.Text,
                ConsumerId = Int32.Parse(TextBox8.Text)
            };
            

            try
            {
                preferenceManager pMgr = new preferenceManager();
                pMgr.Create(preference);

            }
            catch
            {

                // Display a message box informing the user that the calculations 
                // are complete
                MessageBox.Show("Un-Successful Creation of Preference Object ", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }

            // Display a message box informing the user that the calculations 
            // are complete
            MessageBox.Show("Successful Creation of Preference Object ", "",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}