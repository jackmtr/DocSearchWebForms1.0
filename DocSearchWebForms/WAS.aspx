<%@ Page Title="" Language="C#" MasterPageFile="~/MainTemplate.Master" AutoEventWireup="true" CodeBehind="WAS.aspx.cs" Inherits="DocSearchWebForms.WAS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;
    <%--<asp:GridView ID="GridView1" runat="server" ItemType="DocSearchWebForms.Models.PublicVM" DataKeyNames="Folder_ID" SelectMethod="SelectAll" AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="Document_ID" />
            <asp:DynamicField DataField="DocumentTypeName" />
            <asp:DynamicField DataField="IssueDate" />
            <asp:DynamicField DataField="Method" />
            <asp:DynamicField DataField="RefNumber" />
            <asp:DynamicField DataField="EffectiveDate" />
            <asp:DynamicField DataField="Originator" />
            <asp:DynamicField DataField="Reason" />
            <asp:DynamicField DataField="Supplier" />
            <asp:DynamicField DataField="Description" />
            <asp:DynamicField DataField="FileType" />
        </Columns>
    </asp:GridView>--%>
    <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
    <asp:Label ID="ClientName" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="ClientId" runat="server" Text="Client Id: "></asp:Label>
    <asp:Label ID="ClientIdNum" runat="server"></asp:Label>
    <br />
</asp:Content>
