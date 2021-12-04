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
            Titulo.Text = "Tablero " + cont;
            this.main = main;
            cont = 1;
            tab = Program.Programa(this);
            aux = tab;
            



            
        }    
       /* public void Guardar(char[,] t)
        {
            char[,] aux1 = new char[8, 8];
            char[,] aux2 = new char[8, 8];
            char[,] aux3 = new char[8, 8];
            char[,] aux4 = new char[8, 8];
            char[,] aux5 = new char[8, 8];
            char[,] aux6 = new char[8, 8];
            char[,] aux7 = new char[8, 8];
            char[,] aux8 = new char[8, 8];
            char[,] aux9 = new char[8, 8];
            char[,] aux10 = new char[8, 8];
            switch (cont)
            {
                case 1:
                    aux1 = t;
                    break;
                case 2:
                    aux2 = t;
                    break;
                case 3:
                    aux3 = t;
                    break;
                case 4:
                    aux4 = t;
                    break;
                case 5:
                    aux5 = t;
                    break;
                case 6:
                    aux6 = t;
                    break;
                case 7:
                    aux7 = t;
                    break;
                case 8:
                    aux8 = t;
                    break;
                case 9:
                    aux9 = t;
                    break;
                case 10:
                    aux10 = t;
                    break;

            }


        }*/
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
                if (cont <= 4)
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
