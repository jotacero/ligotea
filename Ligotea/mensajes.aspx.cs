using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BDLigotea;

namespace Ligotea
{
    public class ClaseTemporal
    {
        public string MyNick { get; set; }
        public int Total { get; set; }
    }

    public partial class FMensajes : PaginaConectada
    {
        override protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);

            if ( !IsPostBack )
            {
                int idMiusuario = LRegistro.IdUsuario(Session);

                using ( LigoteaEntities bd = new LigoteaEntities() )
                {
                    gvMensajes.DataSource = bd
                        .buscarMensajes( LRegistro.IdUsuario(Session) )
                        .ToList();

                    gvMensajes.DataBind();


                    gvMensajes2.DataSource = bd.Mensajes
                       .Where(d => d.IdUsuarioRecibe == idMiusuario)
                       
                       //.Select( d => new 
                       // { 
                       //    MyNick = d.UsuarioEmisor.Nick,
                       //    Totales = d.UsuarioEmisor.MensajesEnviados.Count
                       // } 
                       .Select(d => new ClaseTemporal()
                       {
                           MyNick = d.UsuarioEmisor.Nick,
                           Total = d.UsuarioEmisor.MensajesEnviados.Count
                       } 
                       )
                       
                       .ToList();

                    gvMensajes2.DataBind();
                } // using

            } // PostBack

        }

    } // class FMensajes
} // namespace