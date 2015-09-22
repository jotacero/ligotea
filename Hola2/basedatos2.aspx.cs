using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hola2
{
    public partial class basedatos2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btCambiar_Click(object sender, EventArgs e)
        {
            // Instancio el contexto de datos: mi conexión con la BD
            NortWndDataContext bd = new NortWndDataContext();

            // Monto una consulta de forma dinámica
            var consulta = bd.Products
                    .Where(d => d.CategoryID == 2);

            // Convierto el resultado en una lista
            var lista = consulta.ToList();


            Products miProducto = bd.Products
                .FirstOrDefault(d => d.ProductName == txtNombre.Text.Trim());


            if ( miProducto!=null && txtNombreNuevo.Text.Trim().Length > 0  )
            {
                miProducto.ProductName = txtNombreNuevo.Text.Trim();

                bd.SubmitChanges();

                // Vuvelvo a vincular el control con el flujo de datos para refrescar
                GridView1.DataBind();
            }



        }

        protected void btInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                // Instancio el contexto de datos: mi conexión con la BD
                NortWndDataContext bd = new NortWndDataContext();

                Products miProducto2 = new Products();

                bd.Products.InsertOnSubmit(miProducto2);

                bd.SubmitChanges();
            }
            catch ( Exception ex )
            {

            }
        }
    }
}