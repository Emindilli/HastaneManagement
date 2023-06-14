<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tablo.aspx.cs" Inherits="HastaneOtomasyon.Tablo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="gwTablo" runat="server" AutoGenerateColumns="true" AllowSorting="true" AllowPaging="false"></asp:GridView>
    <asp:GridView ID="gwTablo2" runat="server" AutoGenerateColumns="true" AllowSorting="true" AllowPaging="false"></asp:GridView>


</asp:Content>
