using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Biseccion
    {
        private int k;
        private double a;
        private double b;
        private double xk;
        private double Fxk;
        private string fa_fk;
        private double abs_b_a;
        private double errorMinimo;

        public int K { get => k; set => k = value; }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double Xk { get => xk; set => xk = value; }
        public double Fxk1 { get => Fxk; set => Fxk = value; }
        public string Fa_fk { get => fa_fk; set => fa_fk = value; }
        public double Abs_b_a { get => abs_b_a; set => abs_b_a = value; }
        public double ErrorMinimo { get => errorMinimo; set => errorMinimo = value; }
    }
}
