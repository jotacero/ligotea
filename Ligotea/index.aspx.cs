using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text;

using BDLigotea;

namespace Ligotea
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void crearLista()
        {
            List<string> lista = new List<string>();

            lista.Add("Atrévete a nosequé");
            lista.Add("No lo intentes, hazlo");
            lista.Add("Sé tu mismo");
            lista.Add("Reflexiona sobre la supinidad del amor");
            lista.Add("No eructes en tu primera cita");

            //lista.RemoveAt(4);
            lista.Remove("No eructes en tu primera cita");

            // Propiedad Count
            //liFrase.Text = lista[ lista.Count - 1 ];
            
            // Método Count
            //liFrase.Text = lista[ lista.Count() - 1 ];

            DateTime horaActual = DateTime.Now;

            int idx = (int) ( horaActual.Ticks % lista.Count() );

            liFrase.Text = lista[idx];
        }


        protected void btEntrar_Click(object sender, EventArgs e)
        {
            //if ( txtUsuario.Text=="pepe" && txtContraseña.Text=="pepito" )
            Usuario miUsuario = Usuario.Login( 
                            txtUsuario.Text.Trim(),
                            txtContraseña.Text.Trim() );

            if ( miUsuario != null )
            {
                liAviso.Text = new StringBuilder() //  "Bienvenido, pepito";
                        .AppendFormat("Bienvenido {0}", miUsuario.Nick)
                        .ToString();

                // Creo los objetos de sesión que necesito
                LRegistro.Crear(Session, miUsuario);

                // Redirecciono al main
                Response.Redirect("main.aspx");

                // Si hago un Response.Redirect lo siguiente no se va a mostrar

                //pnMiPanel.Visible = true;

                //pnRegistro.Visible = false;

                //crearLista();   
            }
            else
            {
                liAviso.Text = "Usuario erróneo";
            }
        }
    }
}