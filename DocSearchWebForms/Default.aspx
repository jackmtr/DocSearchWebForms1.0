<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DocSearchWebForms.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>Enter the Client Id then Submit</p>
    <p>Ramin: 568801</p>
    <p>Client Id with a picture: 1403635</p>
    <p>Client Id:
        <asp:TextBox ID="ClientId" runat="server">1186367</asp:TextBox>
&nbsp;<asp:Button ID="ClientIdButton" runat="server" OnClick="ClientIdButton_Click" Text="Submit" />
    </p>
</asp:Content>
