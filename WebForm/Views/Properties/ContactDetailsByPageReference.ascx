<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactDetailsByPageReference.ascx.cs" Inherits="WebForm.Views.Properties.ContactDetailsByPageReference" %>

<p>
<asp:Label Text=<%#ContactName%> runat="server"></asp:Label><br />
<EPiServer:Translate Text="/contact/phone" runat="server" />: </asp:Label><asp:Label Text=<%# Phone%> runat="server" /><br />
<EPiServer:Translate Text="/contact/email" runat="server" />: </asp:Label><asp:HyperLink NavigateUrl=<%# "mailto:" + Email%> Text=<%#Email%> runat="server" />
</p>
