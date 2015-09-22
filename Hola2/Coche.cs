using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hola2
{
    public class Coche : Vehiculo
    {
        public int Puertas { get; set;}

        public Coche(string d, string c, int p) : base(d, c)
        {
            Puertas = p;
        }

    }
}