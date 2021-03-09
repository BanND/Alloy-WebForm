<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StringsCollection.ascx.cs" Inherits="WebForm.Views.Properties.StringsCollection" %>
<asp:Repeater ID="list" runat="server">
    <HeaderTemplate><ul></HeaderTemplate>
    <ItemTemplate><li><%#Server.HtmlEncode(Container.DataItem.ToString())%></li></ItemTemplate>
    <FooterTemplate></ul></FooterTemplate>
</asp:Repeater>
