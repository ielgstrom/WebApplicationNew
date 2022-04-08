<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationNew._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="row centerLogin">
            <div class="col-2 col-offset-5">
            Email:
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="141px"></asp:TextBox>
            </div>
            <div class="col-2 col-offset-7">
                Contraseña
                <asp:TextBox TextMode="Password" ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Entrar" OnClick="Button1_Click" />
        </div>
    </div>
</asp:Content>
