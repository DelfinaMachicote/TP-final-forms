using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5_ESTE
{
    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
            textBox2.Text = "Menú";
            textBox1.Text = "Elija cuantos tableros desea imprimir";
           
        }
        public int returnCant()
        {
            int cant = (UInt16)numericUpDown1.Value;
            return cant;
        }
        private void Iniciar_Click(object sender, EventArgs e)
        {
            Tablero tablero = new Tablero(this);
            tablero.Show();
            this.Hide();
            
        }

        private void calcular_costos_Click(object sender, EventArgs e)
        {
            Costos costos = new Costos(this);
            costos.Show();
            this.Hide();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
