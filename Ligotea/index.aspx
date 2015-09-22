<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Ligotea.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/estilos.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="pnRegistro" runat="server">
            <div>
                  Usuario : <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            </div>
            <div>
                Contraseña : 
                <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <asp:Button ID="btEntrar" runat="server" OnClick="btEntrar_Click" Text="Entrar" />
        </asp:Panel>

        <asp:Literal ID="liAviso" runat="server"></asp:Literal>
        
        <asp:Panel ID="pnMiPanel" runat="server" Visible="False">
            <p class="superfrase">
                <asp:Literal ID="liFrase" runat="server"></asp:Literal>
            </p>
            <br />
            <asp:HyperLink ID="hlMain" runat="server" NavigateUrl="~/main.aspx" Text="Entra ya y liga"></asp:HyperLink>
        </asp:Panel>
    </form>
</body>
</html>
