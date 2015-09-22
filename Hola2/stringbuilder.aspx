<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stringbuilder.aspx.cs" Inherits="Hola2.stringbuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <asp:Literal ID="liString" runat="server"></asp:Literal>
        <br />
        <asp:Literal ID="liSB" runat="server"></asp:Literal>
        <br />
        <asp:Literal ID="liSB2" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
