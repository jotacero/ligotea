<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="basedatos2.aspx.cs" Inherits="Hola2.basedatos2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Nombre: <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        Nuevo: <asp:TextBox ID="txtNombreNuevo" runat="server"></asp:TextBox>
        <asp:Button ID="btCambiar" runat="server" Text="Cambiar Nombre" OnClick="btCambiar_Click" />


        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
            <Columns>
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" ReadOnly="True" SortExpression="ProductName" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" ReadOnly="True" SortExpression="UnitPrice" />
                <asp:BoundField DataField="UnitsOnOrder" HeaderText="UnitsOnOrder" ReadOnly="True" SortExpression="UnitsOnOrder" />
                <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" ReadOnly="True" SortExpression="UnitsInStock" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btInsertar" runat="server" Text="Insertar Producto Vacío" OnClick="btInsertar_Click" />
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Hola2.NortWndDataContext" EntityTypeName="" Select="new (ProductName, UnitPrice, UnitsOnOrder, UnitsInStock)" TableName="Products">
        </asp:LinqDataSource>
    
    </div>
    </form>
</body>
</html>
