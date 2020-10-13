using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica1
{
   public class Logica_Compartida
    {
        public static void Cambiar_Punto_Coma()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
        public static Boolean ValidarIntervalo(double a, double b, string ecuacion)
        {
            Boolean respuesta = false;
            try
            {
                Evaluador_De_Expresiones evaludor = new Evaluador_De_Expresiones(ecuacion);
                if ((evaludor.F(a) * evaludor.F(b)) < 0)
                    respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;

            }
            return respuesta;
        }
    }
}
