<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alta.aspx.cs" Inherits="Ligotea.alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Usuario : <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox><br />
        Contraseña : <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
        Repetir Contraseña : <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox><br />
        Email : <asp:TextBox ID="txtMail" runat="server" TextMode="Email"></asp:TextBox><br />
        Fecha de nacimiento: <asp:TextBox ID="txtFechaNacimiento" 
            ToolTip="Introduce la fecha de nacimiento" 
            runat="server" TextMode="Date"></asp:TextBox><br />
        Género: <asp:RadioButton ID="rbMasculino" runat="server" Text="Masculino" GroupName="Genero" />
        <asp:RadioButton ID="rbFemenino" runat="server" Text="Femenino" GroupName="Genero" /><br />
        <asp:DropDownList ID="ddEstado" runat="server">
            <asp:ListItem Value="1">Busco Mujer</asp:ListItem>
            <asp:ListItem Value="0">Busco Hombre</asp:ListItem>
            <asp:ListItem Value="-1">Me da igual</asp:ListItem>
        </asp:DropDownList><br />
        
        <asp:Button ID="btAlta" runat="server" Text="Entra y ponte a ligar ya" OnClick="btAlta_Click" />
        <br /><asp:Literal ID="liMensaje" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
