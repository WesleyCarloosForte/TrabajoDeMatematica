using Microsoft.VisualBasic;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica1
{
 public   class Logica_Gaus
    {


        double[,] a;
        double[] x;
        int n;
        int fila;
        int columna;
        int k;
        int band = 0;
        int conta = 0;
        double ErrorMinimo;
        double y;
        IteraccionesGaus ResultadoParcial;
        ResultadoGaus Resultas = new ResultadoGaus();
        private void LeerValores()
        {
            for (fila = 0; fila < n; fila++)
            {

                for (columna = 0; columna <= n; columna++)
                {

                    a[fila, columna] = Double.Parse(Interaction.InputBox($"Ingrese el valor para [ { fila + 1} ] [ { columna + 1}  ] ", "Ecuaciones", "", -1, -1));

                }
            }

        }

        public void LeerValorInicial()
        {

            for (fila = 0; fila < n; fila++)
            {

                x[fila] = Double.Parse(Interaction.InputBox($"Introduce los valores iniciales del ejercicio: [ {fila + 1} ]  ", "Valores inciales", "", -1, -1));
            }

        }
        public ResultadoGaus resolver(TextBox Cantiidad,TextBox Error)
        {
            
            n = int.Parse(Cantiidad.Text);
            a = new double[n, n + 1];
            x = new double[n];
            ErrorMinimo = double.Parse(Error.Text);

            this.LeerValores();
            this.LeerValorInicial();

            

            for (fila = 0; fila < n; fila++)
            {


                for (k = fila + 1; k < n; k++)
                {




                    if (Math.Abs(a[fila, fila]) < Math.Abs(a[k, fila]))
                    {





                        for (columna = 0; columna <= n; columna++)

                        {

                            double temp = a[fila, columna];

                            a[fila, columna] = a[k, columna];

                            a[k, columna] = temp;

                        }
                    }
                }
            }

            for (fila = 0; fila < n; fila++)
            {


                do
                {


                    for (fila = 0; fila < n; fila++)

                    {

                        y = x[fila];

                        x[fila] = a[fila, n];

                        for (columna = 0; columna < n; columna++)

                        {

                            if (columna != fila)

                                x[fila] = x[fila] - a[fila, columna] * x[columna];

                        }

                        x[fila] = x[fila] / a[fila, fila];

                        if (Math.Abs(x[fila] - y) <= ErrorMinimo)
                        {

                            band++;

                        }
                    }





                    conta++;
                    if (conta > 200000)
                        throw new Exception("no fue posible resolver");

                } while (band < n);

            }
          
            for (fila = 0; fila < n; fila++)
            {
                ResultadoParcial = new IteraccionesGaus();

                ResultadoParcial.Iteracion = ($"Para X{fila + 1} = {Math.Abs(x[fila])}");
                Resultas.list.Add(ResultadoParcial);


            }
            Resultas.cantidad=$"Cantidad de iteraciones {conta++}";
            return Resultas;
        }


    }
}
