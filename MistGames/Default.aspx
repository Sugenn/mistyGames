<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MistGames.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Username:&nbsp;&nbsp;
    <asp:TextBox ID="txtUser" runat="server">User</asp:TextBox>
&nbsp;<br />
    <br />
    Password:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPassword" runat="server" style="margin-bottom: 0px" TextMode="Password">**********</asp:TextBox>
&nbsp;<br />
    <br />
    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login!" />
</asp:Content>
