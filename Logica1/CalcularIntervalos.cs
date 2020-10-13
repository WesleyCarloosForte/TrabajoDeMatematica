using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica1;
using Model;

namespace Logica1
{
  public static  class CalcularIntervalos
    {
        
        public static  List<IntervalosBiseccion> GetAutomatico(string Ecuacion)
        {
            double ValorInicial = 0.1;
            double ValorIncremento = 0.1;
       List<IntervalosBiseccion> lista = new List<IntervalosBiseccion>();
            IntervalosBiseccion items;
            Evaluador_De_Expresiones evaluador = new Evaluador_De_Expresiones(Ecuacion);
            Boolean encontro = false;
            int contador = 0;
            while (encontro==false)
            {
                if ((evaluador.F(ValorInicial) * evaluador.F(ValorInicial + ValorIncremento)) < 0)
                {
                    items = new IntervalosBiseccion();
                    items.X = ValorInicial.ToString();
                    items.Fx = evaluador.F(ValorInicial).ToString();
                    lista.Add(items);
                    ValorInicial = ValorInicial + ValorIncremento;
                    encontro = true;
                    items = new IntervalosBiseccion();
                    items.X = ValorInicial.ToString();
                    items.Fx = evaluador.F(ValorInicial).ToString();
                    lista.Add(items);
                }
                else 
                {
                    items = new IntervalosBiseccion();
                    items.X = ValorInicial.ToString();
                    items.Fx = evaluador.F(ValorInicial).ToString();
                    lista.Add(items);
                    ValorInicial = ValorInicial + ValorIncremento;
                }

                contador++;
                if (contador >= 200000)
                {
                  throw new Exception($"Se realizo {contador} calculos y no fue posible encontrar la solucion verifique la ecuacion");
                
                }
            }
            return lista;
        }
        public static double[] GetA_B(string Ecuacion)
        {
            var lista = GetAutomatico(Ecuacion);

            double[] li = new double[2];
            li[0] = double.Parse(  lista[lista.Count-2].X);
            li[1] = double.Parse( lista[lista.Count - 1].X);
            return li;
        }
       
    }
}
