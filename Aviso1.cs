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
    public partial class Aviso1 : Form
    {
        Main main;
        Tablero tablero;
        public Aviso1(Main main, Tablero tablero)
        {
            InitializeComponent();
            this.tablero = tablero;
            this.main = main;
            aviso.Text = "Ya se encontraron los " + main.returnCant() + " tableros.";
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
            tablero.Close();
        }

        private void aviso_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            tablero.Close();
            main.Close();
        }
    }
}
