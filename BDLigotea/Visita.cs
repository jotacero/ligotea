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
    
    public partial class Visita
    {
        public int IdVisitado { get; set; }
        public int IdVisitante { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual Usuario UsuarioVisitado { get; set; }
        public virtual Usuario UsuarioVisitante { get; set; }
    }
}
