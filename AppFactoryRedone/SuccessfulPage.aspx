<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SuccessfulPage.aspx.cs" Inherits="AppFactoryRedone.SuccessfulPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/DefaultStyle.css" rel="stylesheet" />
    <link href="styles/SuccesfulPageStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_div"> 

        
        <asp:Label ID="textDynamicTextLabel" runat="server" Text="You have Sucessfully Updated Your Details"></asp:Label>


        <asp:Button ID="btnOK" runat="server" Text="OK" CssClass="btn btn-success" OnClick="btnOK_Click" />
    </div>

</asp:Content>
