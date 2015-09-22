<%@ Page Title="" Language="C#" MasterPageFile="~/_Conectada.Master" AutoEventWireup="true" CodeBehind="conversacion.aspx.cs" Inherits="Ligotea.FConversacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gvConversacion" runat="server" AutoGenerateColumns="false" OnRowDataBound="gvConversacion_RowDataBound" >
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="hyFicha" runat="server" 
                        NavigateUrl='<%# "ficha.aspx?id=" + Eval("IdUsuarioEnvia") %>'
                        Text='<%# Eval("UsuarioEmisor.Nick") %>'
                        ></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField  >
                <ItemTemplate>
                    <asp:Literal ID="liTexto" runat="server" Text='<%# Eval("Texto") %>' ></asp:Literal>
                    <span class="fecha">
                        <asp:Literal ID="liFecha" runat="server" Text='<%# Eval("Fecha") %>'></asp:Literal>
                    </span>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
