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
    /// <summary>
    /// Ficha de usuario
    /// Hereda de la clase PaginaConectada que gestiona que el usuario esté registrado
    /// </summary>
    public partial class Ficha : PaginaConectada // System.Web.UI.Page
    {
        /// <summary>
        /// Sobrecarga el método Page_Load de PaginaConectada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        override protected void Page_Load(object sender, EventArgs e)
        {
            // Llamo al método Page_Load de la clase base (PaginaConectada)
            base.Page_Load(sender, e);

            if ( !IsPostBack )
            {
                // Capturo la variable "id" QueryString de la URL ficha.aspx?id=...
                string _idUsuario = Request.QueryString["id"].ToString();

                int idUsuario = 0;

                if ( int.TryParse( _idUsuario, out idUsuario ) )
                {
                    // Instancio el contexto de datos Ligotea
                    using ( LigoteaEntities bd = new LigoteaEntities() )
                    {
                        Usuario miUsuario = bd.buscarUsuario(idUsuario);

                        if ( miUsuario!=null )
                        {
                            // 1: Añado la visita al usuario
                            Visita nuevaVisita = new Visita();

                            nuevaVisita.Fecha = DateTime.UtcNow;
                            nuevaVisita.IdVisitado = miUsuario.IdUsuario;
                            nuevaVisita.IdVisitante = LRegistro.IdUsuario(Session);

                            // 1.1 Añado a la tabla
                            bd.Visitas.Add(nuevaVisita);

                            // 1.2 Grabo en BD
                            bd.SaveChanges();


                            // 2: Cargo los controles de servidor
                            liNick.Text = miUsuario.Nick;
                            liEdad.Text = miUsuario.Edad.ToString();

                            liDescripcion.Text = miUsuario.Descripcion;

                            // Si no tienen ninguna imagen muestro la imagen genérica
                            if ( miUsuario.Fotos.Count==0 )
                            {
                                StringBuilder sbImagen = new StringBuilder()
                                    .AppendFormat("img/sex{0}.jpg", 
                                            (int)miUsuario.TGenero);

                                imgUsuario.ImageUrl = sbImagen.ToString();
                            }

                        }
                    } // using

                } // if
            } // IsPostcast

        }

        protected void btEnviar_Click(object sender, EventArgs e)
        {
            string _idUsuario = Request.QueryString["id"].ToString();

            int idUsuarioReceptor = 0;

            if ( int.TryParse( _idUsuario, out idUsuarioReceptor ) )
            {
                int idUsuarioEmisor = LRegistro.IdUsuario(Session);

                string texto = txtMensaje.Text.Trim();

                if ( texto.Length > 0 )
                {
                    Mensaje.Enviar(idUsuarioEmisor, 
                        idUsuarioReceptor, 
                        texto);


                    txtMensaje.Text = "";
                    
                    liAviso.Text = "Mensaje enviado";
                }
                else
                {
                    liAviso.Text = "Escribe algo";
                }


            } // if try.Parse
        }


    } // class
}