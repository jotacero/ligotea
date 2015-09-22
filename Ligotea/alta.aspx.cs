using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BDLigotea;

namespace Ligotea
{
    public partial class alta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAlta_Click(object sender, EventArgs e)
        {
            DateTime dtFecha = new DateTime(); // null; // DateTime.Now;

            if ( txtUsuario.Text.Trim() == "" )
            {
                liMensaje.Text = "El usuario no puede estar en blanco";
            }
            else if ( txtPassword.Text.Trim().Length == 0 )
            {
                liMensaje.Text = "La contraseña no puede estar en blanco";
            }
            else if (txtPassword.Text.Trim() != txtPassword2.Text.Trim())
            {
                liMensaje.Text = "Las contraseñas no coinciden";
            }
            else if ( rbFemenino.Checked==false && !rbMasculino.Checked )
            {
                liMensaje.Text = "Debe introducir un género";
            }
            else if ( !DateTime.TryParse(txtFechaNacimiento.Text, out dtFecha) )
            {
                liMensaje.Text = "El campo fecha es obligatorio";
            }
            else if ( dtFecha.AddYears(18) > DateTime.UtcNow  )
            {
                liMensaje.Text = "Madura y vuelve cuando seas mayor de edad";
            }
            else if ( txtMail.Text.Trim().Length == 0 )
            {
                liMensaje.Text = "El campo mail es obligatorio";
            }
            else 
            {
                //liMensaje.Text = "todo bien, ya te daremos de alta porque no tenemos BASE DE DATOS";

                // Creo una variable para el género
                UsuarioGenero genero = UsuarioGenero.Masculino;

                if ( rbFemenino.Checked )
                {
                    genero = UsuarioGenero.Femenino;
                }

                // Creo otra para el estado
                UsuarioEstadoBusqueda busqueda = UsuarioEstadoBusqueda.Indiferente;
                
                if ( ddEstado.SelectedValue=="0" )
                {
                    busqueda = UsuarioEstadoBusqueda.BuscoHombre;
                }
                else if (ddEstado.SelectedValue == "1")
                {
                    busqueda = UsuarioEstadoBusqueda.BuscoMujer;
                }

                Usuario nuevoUsuario = Usuario.Alta(txtUsuario.Text.Trim(),
                                            txtPassword.Text.Trim(),
                                            txtMail.Text.Trim(),
                                            dtFecha,
                                            genero,
                                            busqueda );

            } //
        }
    }
}