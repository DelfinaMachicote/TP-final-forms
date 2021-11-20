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
        int cont = 1;
        char[,] aux = new char[8, 8];
        public Tablero(Main main)
        {
            InitializeComponent();
            this.main = main;

            char[,] tab = Program.Programa(this);
            Titulo.Text = "Tablero " + cont;
            imprimir.Text = Program.Imprimir(tab);


           
        }
        public void setCont(int c)
        {
            this.cont = c;
        }
        private void Volver_Click(object sender, EventArgs e)
        {
            // Main main = new Main();
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
            if (cont < 10)
            {
                char[,] tab = Program.Programa(this);
                imprimir.Text = Program.Imprimir(tab);
                setCont(++cont);
                Titulo.Text = "Tablero " + cont;
                
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tab_imprimir_Paint(object sender, PaintEventArgs e)
        {
            char[,] tab = Program.Programa(this);
            Size _size = new Size(tab_imprimir.Width / 8, tab_imprimir.Height / 8);
            for (int f = 0; f < 8; f++)
            {
                for (int c = 0; c < 8; c++)
                {
                    var btn = new Button();
                    btn.Size = _size;
                    btn.Location = new Point(c * _size.Width, f * _size.Height);
                    btn.BackColor = (c + f) % 2 == 0 ? Color.BurlyWood : Color.White;
                    if (tab[f, c] == 1)
                    {
                        btn.BackColor = Color.White;
                    }
                    if (tab[f, c] == 'D')
                    {
                        btn.Text = "D";
                    }
                    if (tab[f, c] == 'A')
                    {
                        btn.Text = "A";
                    }
                    if (tab[f, c] == 'R')
                    {
                        btn.Text = "R";
                    }
                    if (tab[f, c] == 'T')
                    {
                        btn.Text = "T";
                    }
                    if (tab[f, c] == 'C')
                    {
                        btn.Text = "C";
                    }
                    tab_imprimir.Controls.Add(btn);


                }


            }
        }
    }
}
