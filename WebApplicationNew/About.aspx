<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplicationNew.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    

    <div _designerregion="0">
    <asp:ListBox ID="ListBox2" CssClass="listFormas" runat="server" Width="268px"></asp:ListBox>
        <br />
        <asp:RadioButtonList runat="server" AutoPostBack="True"  OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged" ID="checkbox">

        <asp:ListItem CssClass="checkFormas" ID="Rectangulo2"  Text="Rectangulo" />
        <asp:ListItem CssClass="checkFormas" ID="Triangulo"  Text="Triangulo" />
        <asp:ListItem CssClass="checkFormas" ID="Circulo"  Text="Circulo" />
        </asp:RadioButtonList>
        <br />

    <asp:Button ID="Button12" CssClass="buttonAddFormas" runat="server" Text="Añadir Figura" enabled="false" OnClick="Button12_Click"/>
    </div>
    

</asp:Content>
