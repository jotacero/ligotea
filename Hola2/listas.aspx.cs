using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hola2
{
    public partial class listas : System.Web.UI.Page
    {
        /// <summary>
        /// Cadena numérica inicializada con valores
        /// </summary>
        int[] aiNumeros = { 4, 8, 1, 3, 11, 16 };

        /// <summary>
        /// Cadena numérica inicializada con tamaño 24 
        /// </summary>
        int[] aiOtraInicializacion = new int[24];

        /// <summary>
        /// Cadena numérica sin inicializar
        /// </summary>
        int[] aiOtraMas;

        
        /// <summary>
        /// Función chorra que hace chorradas
        /// </summary>
        /// <param name="miParámetro">Un parámetro que le paso</param>
        /// <returns>Siempre devuelve true</returns>
        protected bool funcionChorra( int miParámetro )
        {
            return true;
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            aiOtraMas = new int[4];

            // Mi primera consulta LINQ
            var aSubLista = aiNumeros
                        .Where(d => d > 4 && d < 10);

            // aSubLista es un IEnumerable que necesito procesar:

            // Puedo convertirlo a lista
            List<int> listaFinal = aSubLista.ToList();

            // También puedo convertirlo en array
            int[] arrayFinal = aSubLista.ToArray();
        }
    }
}