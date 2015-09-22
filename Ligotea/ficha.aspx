<%@ Page Title="" Language="C#" MasterPageFile="~/_Conectada.Master" AutoEventWireup="true" CodeBehind="ficha.aspx.cs" Inherits="Ligotea.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="ficha">
        <div class="imagen">
            <asp:Image ID="imgUsuario" runat="server" />
        </div>
        <div class="descripcion">
            <h1><asp:Literal ID="liNick" runat="server"></asp:Literal></h1>
            <h4>Tiene <asp:Literal ID="liEdad" runat="server"></asp:Literal> años</h4>

            <p>
                <asp:Literal ID="liDescripcion" runat="server"></asp:Literal>
            </p>
        </div>
    </div>

    <asp:Literal ID="liAviso" runat="server"></asp:Literal>
    <asp:Panel ID="pnMensajes" runat="server" >
        <asp:TextBox ID="txtMensaje" runat="server" TextMode="MultiLine" Height="139px" Width="358px"></asp:TextBox>
        <br />
        <asp:Button ID="btEnviar" runat="server" Text="Enviar Mensaje" OnClick="btEnviar_Click" />
    </asp:Panel>



</asp:Content>
