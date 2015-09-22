using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BDLigotea;

namespace Ligotea
{
    public partial class FMain : PaginaConectada // System.Web.UI.Page
    {



        override protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);

            // No es acción de usuario, es primera carga
            if ( !IsPostBack )
            {
                // Obtengo el idUsuario de la sesión
                int idUsuario = LRegistro.IdUsuario(Session);

                // Hago la instancia con el Contexto de Datos para 
                //  abrir la conexión con la BD
                using ( LigoteaEntities bd = new LigoteaEntities() )
                {
                    lvRecientes.DataSource = bd
                        .buscarRecientes(idUsuario)
                        .ToList();

                    lvRecientes.DataBind();
                }
                // acaba el using y destruye el objeto bd con el contexto de 
                //      datos cerrando la conexión                
            } // !IsPostBack
        } // Page_Load


    } // class FMain
}