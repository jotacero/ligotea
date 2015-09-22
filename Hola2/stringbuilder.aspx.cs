using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hola2
{
    public partial class stringbuilder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            const int sLen = 30, Loops = 10000;             
            DateTime sTime, eTime; 
            string sSource = new String('X', sLen); 
            string sDest = ""; 
            
            // // Tiempo para la concatenación de cadenas. // 
            sTime = DateTime.Now;

            for (int i = 0; i < Loops; i++)
            {
                sDest += sSource;
            }
            
            eTime = DateTime.Now;

            TimeSpan tsDiferencia = (eTime - sTime);
            
            //Console.WriteLine("La concatenación tardó " + (eTime - sTime).TotalSeconds + " segundos."); 
            liString.Text = "La concatenación tardó "
                + tsDiferencia.TotalSeconds 
                + " segundos."
                + tsDiferencia.TotalMilliseconds + " milisegundos"; 
            
            // // Time StringBuilder. 
            sTime = DateTime.Now; 
            
            System.Text.StringBuilder sb 
                = new System.Text.StringBuilder((int)(sLen * Loops * 1.1));

            for (int i = 0; i < Loops; i++)
            {
                sb.Append(sSource);
            }

            sDest = sb.ToString(); 
            
            eTime = DateTime.Now;

            tsDiferencia = (eTime - sTime);
            
            liSB.Text = "El Generador de cadenas tardó "
                + tsDiferencia.TotalSeconds + " segundos. "
                + tsDiferencia.TotalMilliseconds + " milisegundos"; 
            // // Hacer que la ventana de consola permanezca // abierta de forma que pueda ver el resultado cuando la ejecute desde el IDE. // Console.WriteLine(); Console.Write("Presione ENTRAR para terminar ... "; 

            // // Time StringBuilder. 
            sTime = DateTime.Now;

            System.Text.StringBuilder sb2
                = new System.Text.StringBuilder();

            for (int i = 0; i < Loops; i++)
            {
                sb2.Append(sSource);
            }

            sDest = sb2.ToString();

            eTime = DateTime.Now;

            tsDiferencia = (eTime - sTime);

            liSB2.Text = "El Generador de cadenas 2 tardó "
                + tsDiferencia.TotalSeconds + " segundos. "
                + tsDiferencia.TotalMilliseconds + " milisegundos"; 
        }
    }
}