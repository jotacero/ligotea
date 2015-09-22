<%@ Page Title="" Language="C#" MasterPageFile="~/_Conectada.Master" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Ligotea.FMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="recientes">
        <asp:ListView ID="lvRecientes" runat="server">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" 
                    NavigateUrl='<%# "ficha.aspx?id=" + Eval("IdUsuario") %>' >
                    <figure class="item">                    
                        <asp:Image ID="Image1" runat="server" CssClass="foto"
                            ToolTip='<%# Eval("Edad") + " años" %>'
                            ImageUrl='<%# GetImagenDefecto( (BDLigotea.UsuarioGenero)Eval("TGenero") ) %>'  />
                    
                        <figcaption>
                            <asp:Literal ID="Literal1" runat="server"
                                 Text='<%# Eval("Nick") %>'></asp:Literal>
                        </figcaption>
                    </figure>
                </asp:HyperLink>
            </ItemTemplate>
        </asp:ListView>
    </div>


</asp:Content>
