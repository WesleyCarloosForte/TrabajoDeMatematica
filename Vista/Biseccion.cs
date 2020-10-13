using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica1;
using Microsoft.Office.Interop.Word;
using Model;

namespace Vista
{
    /**/
    public partial class Biseccion : Form
    {

        double valor;
        Boolean Usar_Intervalos = false;
        public Biseccion()
        {
            InitializeComponent();
            Logica_Compartida.Cambiar_Punto_Coma();
            ControlarPanel();
        }

        private void ControlarPanel()
        {
            pnlintervalos.Visible = chkintervalos.Checked;
            Usar_Intervalos = chkintervalos.Checked;
        }
        private void Titulos()
        {
            dtresultado.Columns[0].HeaderText = " K ";
            dtresultado.Columns[1].HeaderText = " A k ";
            dtresultado.Columns[2].HeaderText = " B k ";
            dtresultado.Columns[3].HeaderText = " X k ";
            dtresultado.Columns[4].HeaderText = " F ( X k ) ";
            dtresultado.Columns[5].HeaderText = "| B k - A k |";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btncalcular_Click(object sender, EventArgs e)
        {
          
          
            try
            {
                //Ecucion no este null
                if (string.IsNullOrEmpty(txtecuacion.Text))
                {
                    throw new Exception("Ingrese una ecuacion");
                }
                if (string.IsNullOrEmpty(txta.Text) || string.IsNullOrEmpty(txtb.Text))
                {

                }
                else if (chkintervalos.Checked && 
                    !Logica_Compartida.ValidarIntervalo(Convert.ToDouble(txta.Text),
                    double.Parse(txtb.Text), txtecuacion.Text))
                {
                    if (string.IsNullOrEmpty(txta.Text)
                        ||
                        string.IsNullOrEmpty(txtb.Text))
                    {
                        throw new Exception("Ingrese el intervalo");
                    }
                    else
                    {
                        throw new Exception("El intervalo no es valido");
                    }
                        
                }

                if (string.IsNullOrEmpty(txterrorminimo.Text) ||
                    !double.TryParse(txterrorminimo.Text, out valor))
                {
                    throw new Exception("Ingrese un valor valido para el error minimo");
                }
                Logica_Biseccion.Ecuacion = txtecuacion.Text;
                Logica_Biseccion.ErrorMinimo = double.Parse(txterrorminimo.Text);
                if (!Usar_Intervalos)

                {
                    var AUX = (from li in Logica_Biseccion.Resolver()
                               select new
                               {
                                   K = li.K,
                                   AK = li.A,
                                   BK = li.B,
                                   XK = li.Xk,
                                   F_XK = li.Fxk1,
                                   ValorAbsBK_AK = li.Abs_b_a
                               }).ToList();
                    dtresultado.DataSource = AUX;
                    lbla.Text = $"A= {AUX[0].AK}";
                    lblb.Text = $"B= {AUX[0].BK}";
                    lbliteraciones.Text = $"Cantidad de Iteraciones= {AUX.Count}";
                    lblX.Text = $"X= {((from x in AUX select x.XK).Last()).ToString()}";
                    Titulos();
                }
                else 
                {
                    double[] valores = new double[2];
                    valores[0] = double.Parse(txta.Text);
                    valores[1] = double.Parse(txtb.Text);
                   var Aux= (from li in Logica_Biseccion.Resolver(valores)
                       select new
                       {
                           K = li.K,
                           AK = li.A,
                           BK = li.B,
                           XK = li.Xk,
                           F_XK = li.Fxk1,
                           ValorAbsBK_AK = li.Abs_b_a
                       }).ToList();

                    dtresultado.DataSource = Aux;
                    Titulos();
                    lbla.Text = $"A= {txta.Text}";
                    lblb.Text = $"B= {txtb.Text}";
                    lbliteraciones.Text = $"Cantidad de iteraciones= {Aux.Count}";
                    lblX.Text =$"X= {((from x in Aux select x.XK).Last()).ToString()}";
                    
                }


                lblerror.Text = $"Error minimo= {txterrorminimo.Text}";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void txtx_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtx_KeyPress(object sender, KeyPressEventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtecuacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkintervalos_CheckedChanged(object sender, EventArgs e)
        {
            ControlarPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Intervalos_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

/*
 
 
 
 
 */