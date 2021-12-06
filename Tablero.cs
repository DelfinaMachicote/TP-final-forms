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
    public partial class Tablero : Form
    {
        Main main;
        int cont;
        char[,] tab = new char[8, 8];
        char[,] aux = new char[8, 8];
        public Tablero(Main main)
        {
            cont = 1;
            InitializeComponent();
            Titulo.Text = "Tablero " + cont;
            this.main = main;
            tab = Program.Programa(this);
            aux = tab;

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Close();
        }
        private void imprimir_TextChanged(object sender, EventArgs e)
        {

        }
        private void Siguiente_tablero_Click(object sender, EventArgs e)
        {
            int cantidad = main.returnCant();
            if (cont < cantidad)
            {
                while (aux == tab)
                {
                    aux = Program.Programa(this);

                }
                tab = aux;
                cont++;
                Titulo.Text = "Tablero " + cont;
                tab_imprimir.Controls.Clear();
                tab_imprimir.Refresh();
            }
            else
            {
                Aviso1 aviso = new Aviso1(main, this);
                aviso.Show();
            }

        }
        private void Titulo_TextChanged(object sender, EventArgs e)
        {

        }
        private void tab_imprimir_Paint(object sender, PaintEventArgs e)
        {

            //imprime el tablero
            Size _size = new Size(tab_imprimir.Width / 8, tab_imprimir.Height / 8);
            for (int f = 0; f < 8; f++)
            {
                for (int c = 0; c < 8; c++)
                {
                    var lbl = new Label();

                    lbl.Size = _size;
                    lbl.Location = new Point(c * _size.Width, f * _size.Height);
                    lbl.BackColor = (c + f) % 2 == 0 ? Color.BurlyWood : Color.White;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    if (tab[f, c] == '1')
                    {
                        lbl.Text = "1";
                    }
                    if (tab[f, c] == '2')
                    {
                        lbl.Text = "2";
                    }
                    if (tab[f, c] == 'D')
                    {
                        lbl.Text = "D";
                    }
                    if (tab[f, c] == 'A')
                    {
                        lbl.Text = "A";
                    }
                    if (tab[f, c] == 'a')
                    {
                        lbl.Text = "A";
                    }
                    if (tab[f, c] == 'R')
                    {
                        lbl.Text = "R";
                    }
                    if (tab[f, c] == 'T')
                    {
                        lbl.Text = "T";
                    }
                    if (tab[f, c] == 't')
                    {
                        lbl.Text = "T";
                    }
                    if (tab[f, c] == 'C')
                    {
                        lbl.Text = "C";
                    }
                    if (tab[f, c] == 'c')
                    {
                        lbl.Text = "C";
                    }

                    tab_imprimir.Controls.Add(lbl);
                }
            }
        }
    }
}
