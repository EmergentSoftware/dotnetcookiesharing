<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" Inherits="WebFormsFramework4.Default" Title="Default" Culture="auto" UICulture="auto" CodeBehind="~/Default.aspx.cs" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
  <h3>
    Using Forms Authentication</h3>
  <asp:Label ID="Welcome" runat="server" />
    <asp:Button ID="Submit1" OnClick="Signout_Click" 
       Text="Sign Out" runat="server" /><p>
    <a href="http://localhost:50974/">Razor Pages</a>
</asp:Content>
