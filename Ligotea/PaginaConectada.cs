using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using BDLigotea;

namespace Ligotea
{
    /// <summary>
    /// Clase base de todas las páginas que requieren un usuario con sesión
    /// </summary>
 
    public class PaginaConectada : System.Web.UI.Page
    {
        /// <summary>
        /// Devuelve la URL de la imagen por defecto
        /// </summary>
        /// <param name="genero"></param>
        /// <returns></returns>
        public string GetImagenDefecto(UsuarioGenero genero)
        {
            if (genero == UsuarioGenero.Masculino)
                return "img/sex0.jpg";

            return "img/sex1.jpg";
        }

        /// <summary>
        /// Evento Page_Load de la clase base
        ///     Hay que invocarlo desde los Page_Load hijos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        virtual protected void Page_Load(object sender, EventArgs e)
        {
            if ( !LRegistro.ExisteSesion( Session ) )
            {
                Response.Redirect("index.aspx");
            }
        }
    } // PaginaConectada
}