<%@ Page Title="" Language="C#" MasterPageFile="~/_Conectada.Master" AutoEventWireup="true" CodeBehind="mensajes.aspx.cs" Inherits="Ligotea.FMensajes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gvMensajes" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="UsuarioEmisor.Nick" />
            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server"
                        NavigateUrl='<%# "conversacion.aspx?id=" + Eval("IdUsuarioEnvia") %>'>ver</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
