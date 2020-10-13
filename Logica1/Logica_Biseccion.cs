using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica1
{
    /*
    Pasos
  X  1-Calcular XK = (a+b)/2

    2- Verificar cambio 
    2.1-si f(a)*f(xk) es igual a 0 entonces se termina el ejercicio y la raiz es XK
    2.2-si f(a)*f(xk) es mayor 0 entonces A = XK
    2.3-si f(a)*f(xk) es menor 0 entonces B = XK
     
    X  3- verificar el error cuando |b-a|< E 



       
        
      
       
     
    

    */
    public static class Logica_Biseccion
    {
        //Ecuacion
        public static string Ecuacion = "";

        //Error minimo
        public static double ErrorMinimo = 0;
        //Paso 1
        public static double CalcularXK(Biseccion linea)
        {
            return (linea.A + linea.B) / 2;
        }
        //Paso 2
        public static double[] Verificar_Cambio(Biseccion linea)
        {
            double[] valores = new double[2];
            valores[0] = linea.A;
            valores[1] = linea.B;
            if (linea.Fa_fk.Contains('-'))
            {
                valores[1] = linea.Xk;
               
            }
            else if (!linea.Fa_fk.Contains('-') && linea.Fa_fk != "0")
            {
                valores[0] = linea.Xk;
                
            }
          
            return valores;
        }

        //Paso 3
        public static Boolean Seguir_Terminar(Biseccion linea) { 


           
            Boolean respuesta = true;
           
            if (linea.Abs_b_a < ErrorMinimo)
            {
                respuesta= false;
            }


            return respuesta;
        }
        //Paso 4
        public static double CalcularFXK(Biseccion linea)
        {
            Evaluador_De_Expresiones evaluador = new Evaluador_De_Expresiones(Ecuacion);
            return evaluador.F(linea.Xk);
        }
        //Paso 5
        public static string FA_FKX(Biseccion linea)
        {
            Evaluador_De_Expresiones evaluador = new Evaluador_De_Expresiones(Ecuacion);
            return (evaluador.F(linea.A)* evaluador.F(linea.Xk)).ToString();

        }
        //paso 6
        public static double CalcularABS_B_A(Biseccion linea)
        {
            return Math.Abs(linea.B - linea.A);
        }
        //Paso 7
        public static void PrimeraCargarTabla(List<Biseccion> Tabla,int i)
        {

            Biseccion lineaAUX = new Biseccion();
            var val = CalcularIntervalos.GetA_B(Ecuacion);
            lineaAUX.A = val[0];
            lineaAUX.B = val[1];
            lineaAUX.K = i;
            lineaAUX.Xk = CalcularXK(lineaAUX);
            lineaAUX.Fxk1 = CalcularFXK(lineaAUX);
            lineaAUX.Fa_fk = FA_FKX(lineaAUX);
            lineaAUX.Abs_b_a = CalcularABS_B_A(lineaAUX);
            lineaAUX.ErrorMinimo = ErrorMinimo;
            Tabla.Add(lineaAUX);



        }
        public static void PrimeraCargarTabla(List<Biseccion> Tabla,double [] valores)
        {

            Biseccion lineaAUX = new Biseccion();
            lineaAUX.A = valores[0];
            lineaAUX.B = valores[1];
            lineaAUX.K = 0;
            lineaAUX.Xk = CalcularXK(lineaAUX);
            lineaAUX.Fxk1 = CalcularFXK(lineaAUX);
            lineaAUX.Fa_fk = FA_FKX(lineaAUX);
            lineaAUX.Abs_b_a = CalcularABS_B_A(lineaAUX);
            lineaAUX.ErrorMinimo = ErrorMinimo;
            Tabla.Add(lineaAUX);

        }
        //Usuario decide ingresar los intevalos
        public static void CargarTabla(List<Biseccion> Tabla, int i)
        {
            Biseccion lineaAUX = new Biseccion();
            var val = Verificar_Cambio(Tabla[i]);
             lineaAUX.A = val[0];
             lineaAUX.B = val[1];
            lineaAUX.K = i+1;
            lineaAUX.Xk = CalcularXK(lineaAUX);
            lineaAUX.Fxk1 = CalcularFXK(lineaAUX) ;
            lineaAUX.Fa_fk = FA_FKX(lineaAUX);
            lineaAUX.Abs_b_a = CalcularABS_B_A(lineaAUX);
            lineaAUX.ErrorMinimo = ErrorMinimo;
            Tabla.Add(lineaAUX);
        }
        //Usuario ingresa intervalo
        public static List<Biseccion> Resolver(double [] valores)
        {
            List<Biseccion> Tabla = new List<Biseccion>();
            int i = 0;
            PrimeraCargarTabla(Tabla , valores);
            while (Seguir_Terminar(Tabla[i]))
            {
                CargarTabla(Tabla, i);
                i++;

                if (i >= 200000)
                {
                    throw new Exception($"Se realizo {i} calculos y no fue posible encontrar la solucion verifique la ecuacion");
                }
            }
            return Tabla;

        }
        //
        public static List<Biseccion> Resolver()
         {
   
            List<Biseccion> Tabla = new List<Biseccion>();
            int i = 0;
            PrimeraCargarTabla(Tabla, i);
            while (Seguir_Terminar(Tabla[i]))
            {
                CargarTabla(Tabla, i);
                i++;
                if (i >= 200000)
                {
                    
                        throw new Exception($"Se realizo {i} calculos y no fue posible encontrar la solucion verifique la ecuacion");

                    

                }
            }
            return Tabla;
         }


    }
}
