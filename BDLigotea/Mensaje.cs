//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDLigotea
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mensaje
    {
        public int IdUsuarioEnvia { get; set; }
        public int IdUsuarioRecibe { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Texto { get; set; }
        public bool Leido { get; set; }
        public bool Borrado { get; set; }
    
        public virtual Usuario UsuarioEmisor { get; set; }
        public virtual Usuario UsuarioReceptor { get; set; }
    }
}