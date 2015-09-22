using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BDLigotea;

namespace Ligotea
{
    public partial class FMensajes : PaginaConectada
    {
        override protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);

            if ( !IsPostBack )
            {
                using ( LigoteaEntities bd = new LigoteaEntities() )
                {
                    gvMensajes.DataSource = bd
                        .buscarMensajes( LRegistro.IdUsuario(Session) )
                        .ToList();

                    gvMensajes.DataBind();
                } // using

            } // PostBack

        }

    } // class FMensajes
} // namespace