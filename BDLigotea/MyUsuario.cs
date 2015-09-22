using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDLigotea
{
    /// <summary>
    /// Género de los usuarios
    /// </summary>
    public enum UsuarioGenero { Masculino = 0, Femenino = 1 }

    public enum UsuarioEstadoBusqueda { BuscoHombre = 0, 
            BuscoMujer = 1, 
            Indiferente = -1 }

    /// <summary>
    /// Usuarios
    /// </summary>
    public partial class Usuario
    {
        public UsuarioEstadoBusqueda TEstado
        {
            get
            {
                if (Estado == false)
                    return UsuarioEstadoBusqueda.BuscoHombre;
                else if (Estado == true)
                    return UsuarioEstadoBusqueda.BuscoMujer;

                return UsuarioEstadoBusqueda.Indiferente;
            }
        } // TEstado

        public UsuarioGenero TGenero
        {
            get
            {
                return (Genero == false) ? 
                    UsuarioGenero.Masculino : UsuarioGenero.Femenino;
            }
        }

        public byte Edad
        {
            get
            {
                return (byte)((DateTime.Now - Nacimiento).TotalDays / 365);
            }
        }



        /// <summary>
        /// Alta de un usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="genero"></param>
        /// <param name="busco"></param>
        /// <returns></returns>
        public static Usuario Alta(string nombre, string password, 
            string email,
            DateTime fechaNacimiento,
            UsuarioGenero genero,
            UsuarioEstadoBusqueda busco)
        {
            Usuario nuevoUsuario = null;

            using ( LigoteaEntities bd = new LigoteaEntities() )
            {
                nuevoUsuario = new Usuario();

                nuevoUsuario.Nick = nombre;
                nuevoUsuario.Password = password;
                nuevoUsuario.Email = email;
                nuevoUsuario.Nacimiento = fechaNacimiento;

                if (genero == UsuarioGenero.Masculino)
                    nuevoUsuario.Genero = false;
                else
                    nuevoUsuario.Genero = true;

                // Es lo mismo que lo anterior
                // If abreviado
//nuevoUsuario.Genero = (genero == UsuarioGenero.Masculino) ? false : true;

                if (busco == UsuarioEstadoBusqueda.BuscoHombre)
                    nuevoUsuario.Estado = false;
                else if (busco == UsuarioEstadoBusqueda.BuscoMujer)
                    nuevoUsuario.Estado = true;
                else
                    nuevoUsuario.Estado = null;

                //nuevoUsuario.FechaAlta = DateTime.UtcNow;


                // Lo guardo en la tabla: es una tabla en memoria
                bd.Usuarios.Add(nuevoUsuario);

                // Le digo a la Base de Datos que grabe los cambios
                bd.SaveChanges();
            }

            return nuevoUsuario;
        } // Alta


        /// <summary>
        /// Login de usuario
        /// </summary>
        /// <param name="nick"></param>
        /// <param name="password"></param>
        /// <returns>Un objeto usuario si los datos eran correctos, null EOC </returns>
        public static Usuario Login(string nick, string password)
        {
            // Declaro Usuario. 
            // La variable puede llamarse usuario por ser sensible c# a mayúsculas y minúsculas
            Usuario usuario = null;

            using ( LigoteaEntities bd = new LigoteaEntities() )
            {
                usuario = bd.Usuarios
                    .FirstOrDefault(d => d.Nick == nick 
                                        && d.Password == password);
            }

            return usuario;
        } // Login

    } // Usuario
}
