<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CaptureDetails.aspx.cs" Inherits="AppFactoryRedone.CaptureDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- <link href="styles/bootstrap.min.css" rel="stylesheet" />--%>
    <link href="styles/DefaultStyle.css" rel="stylesheet" />
</asp:Content>


   
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="main_div" >
        <div class="page-header"> <h1> Fill in the form below</h1></div>
<asp:TextBox ID="first_name" placeholder="First name" runat="server" CssClass="form-control"></asp:TextBox>
    
    
<asp:TextBox ID="last_name" placeholder="last name" runat="server" CssClass="form-control"></asp:TextBox>

 <asp:Label ID="roleLabel" runat="server" Text="Role"  CssClass=""></asp:Label><asp:DropDownList ID="Role" runat="server" CssClass="form-control">
     <asp:ListItem Value="1200">Intern</asp:ListItem>
     <asp:ListItem Value="1100">Mentor</asp:ListItem>
     <asp:ListItem Value="1000">Manager</asp:ListItem></asp:DropDownList>

        <asp:Label ID="Primary" runat="server" Text="Is Primary      " CssClass="checkbox">
            <asp:CheckBox ID="PrimaryCheckBox" runat="server" /> </asp:Label>
<asp:TextBox ID="contact_number" placeholder="contact number" runat="server" CssClass="form-control"></asp:TextBox>
<asp:Label ID="Business" runat="server" Text="Is Business ">
            <asp:CheckBox ID="IsBusinesCheckBox" runat="server" /> </asp:Label>
<asp:TextBox ID="email_address" placeholder="email Address" runat="server" CssClass="form-control"></asp:TextBox>
<asp:Calendar ID="DOB" runat="server" Width="10px" Height="8px" Caption="Date Of Birth" ></asp:Calendar>
     <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="Cancel_Click" CssClass="btn btn-primary" />
    <asp:Button ID="sand_to_DB" runat="server" Text="Register" OnClick="sand_to_DB_Click" CssClass="btn btn-primary "/>

    </div>

   
</asp:Content>
