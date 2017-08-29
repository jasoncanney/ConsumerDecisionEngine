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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            login login = new GenAdxCDE.Source.Model.Domain.login()
            {
                userName = t1.Text,
                passWord = t2.Text,
                
            };

            // create a login manager to submit the login and verify password is correct
            loginManager ConMgr = new loginManager();

            if (ConMgr.Verify(login))
            {
                // If login was successful, go to Default
                Response.Redirect("Default.aspx");
            }
            else
            {
                // Display a message box informing the user that the calculations 
                Label1.Text = "Invalid Username or Password";

            }
        }
    }
}