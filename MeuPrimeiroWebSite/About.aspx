<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="MeuPrimeiroWebSite.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>


    <asp:Label Text="" ID="lblIdade" runat="server" />
    <asp:TextBox runat="server" ID="txtIdade" />
    <asp:Button Text="Enviar" ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" />

</asp:Content>
