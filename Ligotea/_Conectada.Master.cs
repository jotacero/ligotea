using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ligotea
{
    public partial class _Conectada : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( LRegistro.ExisteSesion( Session ) )
            {
                if ( !IsPostBack )
                {
                    // Si utilizamos using System.Text no hace falta invocar con System.Text.StringBuilder()
                    System.Text.StringBuilder sbMiSaludo = new System.Text.StringBuilder();

                    sbMiSaludo.AppendFormat("Hola {0}", LRegistro.NombreUsuario(Session));

                    liSaludo.Text = sbMiSaludo.ToString();


                    System.Text.StringBuilder sbMiSaludo2 = new System.Text.StringBuilder();

                    sbMiSaludo2.Append("Hola ");
                    sbMiSaludo2.Append(LRegistro.NombreUsuario(Session));

                    // sbMiSaludo2.Append("Hola " + LRegistro.NombreUsuario(Session));
                } // IsPosBack
            }
            else
            {
                // Si no hay sessión le expulso
                Response.Redirect("index.aspx");
            }
        }

        protected void btSalir_Click(object sender, EventArgs e)
        {
            LRegistro.Borrar(Session);

            Response.Redirect("index.aspx");
        }
    }
}