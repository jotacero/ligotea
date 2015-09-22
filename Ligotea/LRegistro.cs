using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Ligotea
{
    public class LRegistro
    {
        public const string SESION_USUARIO = "usuario";
        public const string SESION_ID = "idUsuario";

        /// <summary>
        /// Elimina la sesión de usuario
        /// </summary>
        /// <param name="sesion"></param>
        public static void Borrar(HttpSessionState sesion)
        {
            sesion.Abandon();
        }


        /// <summary>
        /// Crea una sesión de usuario
        /// </summary>
        /// <param name="sesion"></param>
        /// <param name="nombreUsuario"></param>
        public static void Crear(HttpSessionState sesion, 
            BDLigotea.Usuario usuario ) // string nombreUsuario )
        {
            sesion.Add(LRegistro.SESION_USUARIO, usuario.Nick);
            sesion.Add(LRegistro.SESION_ID, usuario.IdUsuario);

            // Dentro de la clase es igual que
            //sesion.Add(SESION_USUARIO, nombreUsuario);
        } // Crear

        public static bool ExisteSesion( HttpSessionState sesion )
        {
            //if ( sesion[SESION_USUARIO] == null )
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}

            return ( sesion[SESION_USUARIO] != null );
        }

        public static string NombreUsuario(HttpSessionState sesion)
        {
            return (string)sesion[SESION_USUARIO];
        }

        public static int IdUsuario(HttpSessionState sesion)
        {
            return (int)sesion[SESION_ID];
        }

    } // LRegistro
}