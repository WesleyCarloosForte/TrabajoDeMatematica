using Logica1;
using Microsoft.VisualBasic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class GausFrm : Form
    {
        public GausFrm()
        {
            InitializeComponent();
            Logica_Compartida.Cambiar_Punto_Coma();
        }
       Logica_Gaus Gaus = new Logica_Gaus();
        private void btnResolver_Click(object sender, EventArgs e)
        {
            try
            {
                ResultadoGaus resultado = this.Gaus.resolver(textBox1, textBox2);
                drresultado.DataSource = resultado.list;
                label2.Text = resultado.cantidad;
               
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error al resolver verifique los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                drresultado.DataSource = null;
            }


        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
