using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BDLigotea;

namespace Ligotea
{
    public partial class FVisitas2 : PaginaConectada
    {
        override protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);

            using ( LigoteaEntities bd = new LigoteaEntities() )
            {
                Usuario miUsuario = 
                    bd.buscarUsuario(LRegistro.IdUsuario(Session));

                lvVisitas.DataSource = miUsuario
                    .VisitasRecibidas
                    .OrderByDescending(d => d.Fecha)
                    .ToList();

                // Si pongo el DataBind fuera al acceder a campos
                // existentes en otras tablas da un error
                lvVisitas.DataBind();
            } // using

            //lvVisitas.DataBind();
        }
    }
}