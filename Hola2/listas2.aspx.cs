using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hola2
{
    public partial class listas2 : System.Web.UI.Page
    {
        protected List<Coche> mListaCoches = new List<Coche>();

        

        protected void Page_Load(object sender, EventArgs e)
        {
            Coche miCoche = new Coche("pepe", "rojo", 3);

            Coche miCarro = new Coche("pepe", "azul", 8);

            Coche suCarro = new Coche("manolo", "amarillo", 2);

            // Puedo añadir objetos ya instanciados
            mListaCoches.Add(miCoche);
            mListaCoches.Add(miCarro);
            mListaCoches.Add(suCarro);

            // Puedo instanciarlos en el momento de añadirlos
            mListaCoches.Add( new Coche("juan", "rojo", 5 ) );


            // Puedo utilizar un atributo aunque lo declare en otro punto de código
            variableDeEjemplo = 8;

            //miCoche.Dueño = "fulano";


            CargarTabla(mListaCoches);
        }


        protected void CargarTabla(List<Coche> listaDeCoches)
        {
            //// Asocio al control DrigView la lista
            gvCoches.DataSource = listaDeCoches;
            gvCoches.DataBind();
        }



        /// <summary>
        /// Puedo declarar un atributo en cualquier punto de la clase
        /// </summary>
        public int variableDeEjemplo;

        protected void btRojos_Click(object sender, EventArgs e)
        {
            var _cochesRojos = mListaCoches.
                                Where(c => c.Color == "rojo");

            List<Coche> cochesRojos = _cochesRojos.ToList();

            CargarTabla(cochesRojos);
        }

        protected void btPepe_Click(object sender, EventArgs e)
        {
            var _cochesPepe = mListaCoches.
                                 Where(coche => coche.Dueño == "pepe");

            List<Coche> cochesPepe = _cochesPepe.ToList();

            CargarTabla(cochesPepe);
        }

        protected void btPuertasPar_Click(object sender, EventArgs e)
        {
            List<Coche> puertasPar = mListaCoches.
                                Where(coche => coche.Puertas % 2 == 0)
                                .ToList();

            CargarTabla(puertasPar);
        }

        protected void btFiltrar_Click(object sender, EventArgs e)
        {
            string color = txtColor.Text.Trim();

            int puertas = 0;

            //try
            //{
            //    puertas = int.Parse(txtPuertas.Text);
            //}
            //catch
            //{

            //}
            // Lo anterior es lo mismo que

            int.TryParse(txtPuertas.Text.Trim(), out puertas);

            var lista = mListaCoches;

            if (color.Length > 0)
                lista = mListaCoches.Where(d => d.Color == color)
                    .ToList();

            if (puertas > 0)
                lista = lista.Where(d => d.Puertas > puertas)
                    .ToList();

            CargarTabla(lista);

        }
    }
}