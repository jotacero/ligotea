using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text;


namespace Hola2
{
    public partial class hola : System.Web.UI.Page
    {
        private int mContador = 1;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mContador = 5;
            }

            // Igual que lo anterior, pero mala práctica de programación
            //if (!IsPostBack)
            //    mContador = 5;
            
        }

        protected void btCambiar_Click(object sender, EventArgs e)
        {
            mContador++;

            liSaludo.Text = txtEntrada.Text + mContador;
        }

        protected void btMail_Click(object sender, EventArgs e)
        {
            StringBuilder miCadena = new StringBuilder();

            //liSaludo.Text = "El mail de " + txtEntrada.Text + " es " + txtEmail.Text;

            miCadena.Append("El mail de " );
            miCadena.Append(txtEntrada.Text);
            miCadena.AppendFormat(" es {0} ", txtEmail.Text);

            liSaludo.Text = miCadena.ToString();

            miCadena.AppendFormat("El mail de {0} es {1} ", 
                        txtEntrada.Text,        // <- 0
                        txtEmail.Text );        // <- 1 

            liSaludo.Text = miCadena.ToString();
        }

        protected void btIncrementar_Click(object sender, EventArgs e)
        {
            try
            {
                int variable = int.Parse( txtNumero.Text );

                //variable++;

                //txtNumero.Text = variable.ToString();

                txtNumero.Text = (++variable).ToString();

                //txtNumero.Text = "" + variable++;
            }
            catch ( Exception ex )
            {
                liSaludo.Text = ex.ToString();
            }
        }

        
    } // clase
} // namespace