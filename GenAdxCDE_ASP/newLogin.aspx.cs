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
    public partial class newLogin : System.Web.UI.Page
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

            try
            {
                loginManager ConMgr = new loginManager();
                ConMgr.Create(login);

            }
            catch
            {
                // Display a message box informing the user that the calculations 
                Label1.Text = "Invalid Username or Password";
            }
            finally
            {
                // If login was successful, go to Default
                Response.Redirect("Login.aspx");
                // Server.Transfer("Page2.aspx", true);
            }

            


        }


    }
    }