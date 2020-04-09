<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InternsDataTable.aspx.cs" Inherits="AppFactoryRedone.InternsDataTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/TableStylePage.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:Table ID="internsDataTable" runat="server" Caption="Interns Data" Width="687px" CssClass="table">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">Intern ID </asp:TableCell>
            <asp:TableCell runat="server">Full Name</asp:TableCell>
            <asp:TableCell runat="server">Date Of Birth</asp:TableCell>
            <asp:TableCell runat="server">Email Address</asp:TableCell>
            <asp:TableCell runat="server">Business Email </asp:TableCell>
            <asp:TableCell runat="server">Cell Number</asp:TableCell>
            <asp:TableCell runat="server">Is Primary Number</asp:TableCell>
            <asp:TableCell runat="server">Action</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
      
</asp:Content>
