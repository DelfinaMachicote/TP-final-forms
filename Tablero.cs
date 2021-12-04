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
            InitializeComponent();
            this.main = main;
            cont = 1;
            aux = Program.Programa(this);
            tab = Program.Programa(this);
            Titulo.Text = "Tablero " + cont;



            
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
            if (cont <cantidad)
            {
                if (cont <= 5)
                {
                    tab = Program.Reordenar(tab, cont);
                }
                else {
                    while (aux == tab)
                    {
                        aux = Program.Programa(this);
                        
                    }
                    tab = aux;
                }
                
                
                ++cont;
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
                    var btn = new Button();
                    
                    btn.Size = _size;
                    btn.Location = new Point(c * _size.Width, f * _size.Height);
                    btn.BackColor = (c + f) % 2 == 0 ? Color.BurlyWood : Color.White;
                    if (tab[f, c] == '1')
                    {
                        btn.Text = "1";
                    }
                    if (tab[f, c] == '2')
                    {
                        btn.Text = "2";
                    }
                    if (tab[f, c] == 'D')
                    {
                        btn.Text = "D";
                    }
                    if (tab[f, c] == 'A')
                    {
                        btn.Text = "A";
                    }
                    if (tab[f, c] == 'a')
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
                    if (tab[f, c] == 't')
                    {
                        btn.Text = "T";
                    }
                    if (tab[f, c] == 'C')
                    {
                        btn.Text = "C";
                    }
                    if (tab[f, c] == 'c')
                    {
                        btn.Text = "C";
                    }

                    tab_imprimir.Controls.Add(btn);
                }
            }
        }
    }
}
