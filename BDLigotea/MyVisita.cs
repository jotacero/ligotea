using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDLigotea
{
    public partial class Visita
    {
        /// <summary>
        /// Número de días desde la visita
        /// </summary>
        public int Dias
        {
            get
            {
                return (int)(DateTime.Now - Fecha).TotalDays;
            }
        } // Dias

        /// <summary>
        /// Tiempo desde la visita 
        /// Devuelve "Hace x días, horas o minutos"
        /// </summary>
        public string Texto
        {
            get 
            {
                StringBuilder sb = new StringBuilder("Hace ");

                TimeSpan ts = DateTime.UtcNow - Fecha;

                if ( ts.TotalDays > 1 )
                {
                    sb.AppendFormat("{0} días", (int)ts.TotalDays);
                }
                else if ( ts.TotalHours > 1 )
                {
                    sb.AppendFormat("{0} horas", (int)ts.TotalHours);
                }
                else
                {
                    sb.AppendFormat("{0} minutos", (int)ts.TotalMinutes);
                }

                return sb.ToString();
            }
        }

    } // Visita
}
