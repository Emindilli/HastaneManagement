<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoktorKayit.aspx.cs" Inherits="HastaneOtomasyon.DoktorKayit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">








    <!DOCTYPE html>
    <html lang="tr">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Hastane Otomasyonu - Doktor Kayıt</title>
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    </head>
    <body>


        <div class="container mt-4">
            <h2>Doktor Kayıt</h2>
            <form>
                <div class="form-group">
                    <label for="ID">Doktor Numarası</label>
                    <asp:TextBox ID="txtID" runat="server" CssClass="form-control" OnTextChanged="txtID_TextChanged" ></asp:TextBox>
                     
                </div>
                <div class="form-group">
                    <label for="name">İsim</label>
                    <asp:TextBox ID="txtIsim" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                
                <div class="form-group">
                    <label for="lastname">Soy İsim</label>
                    <asp:TextBox ID="txtSoyIsim" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="phone">Telefon</label>
                    <asp:TextBox ID="txtTel" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="uzmanlik">Doktor Uzmanlık Alanı</label>
                    <asp:TextBox ID="txtAlan" runat="server" CssClass="form-control"></asp:TextBox>
                    
                </div>
                    <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
                    <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" OnClick="btnGuncelle_Click" />
                    <asp:Button ID="btnSil" runat="server" Text="Kayıt Sil" OnClick="btnSil_Click" />
                    <asp:Button ID = "btnGetAllData" runat = "server" Text = "Tablo" OnClick = "btnGetAllData_Click" />

            </form>
            <asp:GridView ID="gwTablo" runat="server" AutoGenerateColumns="true" AllowSorting="true" AllowPaging="false"></asp:GridView>
            
            
            
           
            
            
            
        </div>


        <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>




</asp:Content>
