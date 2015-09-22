<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listas2.aspx.cs" Inherits="Hola2.listas2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btRojos" runat="server" Text="Coches Rojos" OnClick="btRojos_Click" />
        <asp:Button ID="btPuertasPar" runat="server" Text="Coches con puertas par" OnClick="btPuertasPar_Click" />
        <asp:Button ID="btPepe" runat="server" OnClick="btPepe_Click" Text="Coches de Pepe" />
    </div>
        <asp:GridView ID="gvCoches" runat="server">
        </asp:GridView>
        <br />
        <div>
            <label>
                Color <asp:TextBox ID="txtColor" runat="server"></asp:TextBox> 
            </label>
            
        </div>
        <div>
            <label>
                Con número mínimo de puertas
                <asp:TextBox ID="txtPuertas" TextMode="Number" runat="server"></asp:TextBox> 
            </label>
        </div>
        <div>
            <asp:Button ID="btFiltrar" runat="server" Text="Filtrar" OnClick="btFiltrar_Click" />
        </div>
    </form>
</body>
</html>
