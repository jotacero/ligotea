using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDLigotea
{
    public partial class LigoteaEntities
    {
        /// <summary>
        /// Devuelve un usuario con el id pasado
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>null si no encuentra nada</returns>
        public Usuario buscarUsuario( int idUsuario )
        {
            return Usuarios
                .FirstOrDefault(d => d.IdUsuario == idUsuario);
        } // buscarUsuario

        /// <summary>
        /// Devuelve una búsqueda que se ajuste a los criterios básicos
        /// de un usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>Devuelve la query básica de búsqueda o null si el usuario es erróneo</returns>
        public IQueryable<Usuario> busquedaBasica( int idUsuario )
        {
            Usuario usuario = buscarUsuario( idUsuario );

            IQueryable<Usuario> query = null;

            // Compruebo que el usuario existe
            if ( usuario!=null )
            {
                // Paso 1 : que los usuarios devueltos sean lo que yo busco
                if ( usuario.TEstado == UsuarioEstadoBusqueda.Indiferente )
                {
                    // Me da igual el género
                    query = Usuarios
                        .Where(d => d.Genero == true || d.Genero == false );  
                }
                else
                {
                    // Que el género coincida con mi búsqueda
                    query = Usuarios
                        .Where(d => d.Genero == usuario.Estado);   
                }

                // Paso 2: que yo sea lo que buscan ell@s
                query = query
                    .Where(d => d.Estado == usuario.Genero || 
                                d.Estado == null);

                // Paso 3 : excluyo al usuario actual de la búsqueda
                query = query
                    .Where(d => d.IdUsuario != usuario.IdUsuario);


                // Alternativa uniendo 2 y 3
                //query = query
                //    .Where(d => (d.Estado == usuario.Genero || 
                //                d.Estado == null ) && 
                //                d.IdUsuario != usuario.IdUsuario);


                // Alternativa 2 uniendo 2 y 3
                // Poco elegante o mierda
                //query = query
                //    .Where(d => d.Estado == usuario.Genero ||
                //                d.Estado == null)
                //    .Where(d => d.IdUsuario != usuario.IdUsuario);
            }

            return query;
        } // busquedaBasica


        /// <summary>
        /// Listado de últimos usuarios dados de alta
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="total">Número de resultados a devolver, 5 por defecto</param>
        /// <returns>listado si Ok null si no</returns>
        public IQueryable<Usuario> buscarRecientes
            ( int idUsuario, int total = 5 )
        {
            IQueryable<Usuario> resultado = null;

            var query = busquedaBasica(idUsuario);

            if ( query != null )
            {
                resultado = query
                    .OrderByDescending(d => d.FechaAlta)
                    .Take(total);
            }

            return resultado;
        } // buscarRecientes
        


        public IQueryable<Mensaje> buscarMensajes( int idUsuarioDestinatario, 
            int? idUsuarioRemitente = null )
        {
            IQueryable<Mensaje> resultado = null;
            IQueryable<Mensaje> query = null;

            if (!idUsuarioRemitente.HasValue)
            {
                query = Mensajes
                    .Where(d => d.IdUsuarioRecibe == idUsuarioDestinatario);
            }
            else
            {
                query = Mensajes
                    .Where(d => ( d.IdUsuarioRecibe == idUsuarioDestinatario || 
                            d.IdUsuarioEnvia==idUsuarioDestinatario ) &&
                                (d.IdUsuarioRecibe == idUsuarioRemitente ||
                            d.IdUsuarioEnvia == idUsuarioRemitente)
                            );
            }

            resultado = query
                    .OrderByDescending(d => d.Fecha);

            return resultado;
        }
    } // class
} // namespace
