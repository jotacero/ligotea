<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="basedatos1.aspx.cs" Inherits="Hola2.basedatos1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ProductName" HeaderText="Nombre de Producto" SortExpression="ProductName" />
                <asp:BoundField DataField="QuantityPerUnit" HeaderText="Cantidad" SortExpression="QuantityPerUnit" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Precio" SortExpression="UnitPrice" />
                <asp:BoundField DataField="UnitsInStock" HeaderText="Almacenaje" SortExpression="UnitsInStock" />
                <asp:BoundField DataField="UnitsOnOrder" HeaderText="Ordenados" SortExpression="UnitsOnOrder" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" SelectCommand="SELECT [ProductName], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [UnitsOnOrder] FROM [Products]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
