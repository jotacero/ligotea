using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hola2
{
    abstract public class Vehiculo
    {
        private string _Dueño;
        
        /// <summary>
        /// Propiedad que encapsula el atributo _Dueño
        /// </summary>
        public string Dueño
        {
            get
            {
                return _Dueño;
            }
            //set
            //{
            //    _Dueño = value;
            //}
        }

        /// <summary>
        /// Propiedad Color
        /// </summary>
        public string Color { get; set; }

        public string Nombre
        {
            get
            {
                return Dueño + Color;
            }
        }


        /// <summary>
        /// Constructor de Vehículo
        /// </summary>
        /// <param name="d">Dueño</param>
        /// <param name="c">Color</param>
        public Vehiculo(string d, string c)
        {
            _Dueño = d;
            Color = c;
        }

    }
}