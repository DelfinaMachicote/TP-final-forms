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
        }

        private void Volver_Click(object sender, EventArgs e)
        {

        }
    }
}
