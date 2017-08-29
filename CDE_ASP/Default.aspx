<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GenAdxCDE._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Consumer Decision Engine</h1>
        <p class="lead">Interface to control and configure the Consumer Decision Engine</p>
        <p class="lead">
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Consumer.aspx">Consumer </asp:HyperLink>
&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ConsumerHistory.aspx">Consumer History</asp:HyperLink>
&nbsp;
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Preference.aspx">Preference</asp:HyperLink>
&nbsp;
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Advertisement.aspx">Advertisement</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Coupon.aspx">Coupon</asp:HyperLink>
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>
