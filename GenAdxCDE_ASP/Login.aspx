<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GenAdxCDE.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Login</h1>
        <p></p>
        <p class="lead">Login to control and configure the Consumer Decision Engine</p>
            
     
            
     
      <table> 
                <tr>
                    <td>Enter Username</td>
                    <td><asp:TextBox runat="server" ID="t1"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Enter Password</td>
                    <td><asp:TextBox runat="server" ID="t2" TextMode="Password"></asp:TextBox></td>
                </tr>
                 <tr>
                     <td colspan="2">
                         <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                     </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label runat="server" ID="Label1" Text=""></asp:Label>
                    </td>

                </tr>
          

      </table>
         
          <asp:HyperLink ID="HyperLink5" runat="server" Font-Names="Arial" NavigateUrl="~/newLogin.aspx">Create New Login</asp:HyperLink>

        </div>
    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>