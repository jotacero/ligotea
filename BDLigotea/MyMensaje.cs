using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDLigotea
{
    public partial class Mensaje
    {
        /// <summary>
        /// Inserta un mensaje en la base de datos
        /// </summary>
        /// <param name="idUsuarioEmisor">Fulano que envía</param>
        /// <param name="idUsuarioReceptor">Mengano que recibe</param>
        /// <param name="texto">Texto que se le manda</param>
        /// <returns>Instancia del mensaje creado</returns>
        public static Mensaje Enviar( int idUsuarioEmisor, 
            int idUsuarioReceptor, 
            string texto )
        {
            Mensaje miMensaje = new Mensaje();

            miMensaje.IdUsuarioEnvia = idUsuarioEmisor;
            miMensaje.IdUsuarioRecibe = idUsuarioReceptor;
            miMensaje.Texto = texto;
            miMensaje.Fecha = DateTime.UtcNow;

            using ( LigoteaEntities bd = new LigoteaEntities() )
            {
                bd.Mensajes.Add(miMensaje);

                bd.SaveChanges();
            } // using

            return miMensaje;
        } // Enviar

    } // class
} // namespace
