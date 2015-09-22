<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hola.aspx.cs" Inherits="Hola2.hola" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Adiós mundo
            <asp:Literal ID="liSaludo" runat="server" Text="cruel"></asp:Literal>
            </p>
        </div>
        <asp:TextBox ID="txtEntrada" runat="server" ToolTip="Introduce tu nombre aquí"></asp:TextBox>
        <asp:Button ID="btCambiar" runat="server" BackColor="Red" OnClick="btCambiar_Click" Text="Cambiar" ToolTip="Cambiar el saludo" />
        <br />
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
        <asp:Button ID="btMail" runat="server" OnClick="btMail_Click" Text="Button" />
        <p>
            <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
            <asp:Button ID="btIncrementar" runat="server" OnClick="btIncrementar_Click" Text="Incrementar" />
        </p>
    </form>
</body>
</html>
