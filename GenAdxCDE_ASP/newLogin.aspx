<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="newLogin.aspx.cs" Inherits="GenAdxCDE.newLogin" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Create New Login</h1>
        <p class="lead">Interface to control and configure the Consumer Decision Engine</p>
            
     
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
                         <asp:Button ID="Button1" runat="server" Text="Create" OnClick="Button1_Click" />
                     </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label runat="server" ID="Label1" Text="Label"></asp:Label>
                    </td>

                </tr>

      </table>
        </div>
    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>