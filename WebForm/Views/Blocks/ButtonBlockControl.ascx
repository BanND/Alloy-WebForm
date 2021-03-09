<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ButtonBlockControl.ascx.cs" Inherits="WebForm.Views.Blocks.ButtonBlockControl" %>

<a class="btn-blue" title="<%# CurrentBlock.ButtonText %>" href="<%# CurrentBlock.ButtonLink %>" id="ButtonLink" runat="server"><%= string.IsNullOrWhiteSpace(CurrentBlock.ButtonText) ? Translate("/blocks/buttonblockcontrol/buttondefaulttext") : Server.HtmlEncode(CurrentBlock.ButtonText) %></a>
