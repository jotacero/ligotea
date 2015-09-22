using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BDLigotea;

namespace Ligotea
{
    public partial class FConversacion : PaginaConectada // System.Web.UI.Page
    {
        /// <summary>
        /// Atributo con el idUsuario pasado
        /// </summary>
        protected int mIdUsuario = 0;


        override protected void Page_Load(object sender, EventArgs e)
        {
            // Llamo a la clase base para gestionar que tenga sesión
            base.Page_Load(sender, e);


            // Leo la variable pasada por query string
            string _idUsuario = Request.QueryString["id"].ToString();

            if ( int.TryParse(_idUsuario, out mIdUsuario) )
            {

                if ( !IsPostBack )
                {
                    // Obtengo el usuario actual de la sesión
                    int miUsuario = LRegistro.IdUsuario(Session);

                    // Instancio la base de datos
                    using ( LigoteaEntities bd = new LigoteaEntities() )
                    {
                        gvConversacion.DataSource = bd
                            .buscarMensajes(miUsuario, mIdUsuario)
                            .ToList();

                        gvConversacion.DataBind();
                    } // using

                } // !IsPostBack

            } // if
        }

        /// <summary>
        /// Devuelve un estilo u otro en función de si el usuario pasado es el de la sesión o no
        /// </summary>
        /// <param name="idUsuarioRemitente"></param>
        /// <returns></returns>
        public string GetEstilo(int idUsuarioRemitente )
        {
            if ( idUsuarioRemitente==LRegistro.IdUsuario(Session) )
                return "mensajeyo";

            return "mensajeotro";
        }

        protected void gvConversacion_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Mensaje m = (Mensaje)e.Row.DataItem;

                e.Row.CssClass = GetEstilo(m.IdUsuarioEnvia);
            }
        }

        //// También habría servido:
        //public string GetEstilo(int idUsuarioRemitente)
        //{
        //    if (idUsuarioRemitente == mIdUsuario)
        //        return "mensajeotro";

        //    return "mensajeyo";
        //}

    } // class
} // namespace