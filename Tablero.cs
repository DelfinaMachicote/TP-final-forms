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
            bool check = false;
            if (cont < cantidad)
            {
                /*while (aux == tab)
                {
                    aux = Program.Programa(this);
                }*/
                while (check == false)
                {
                    aux = Program.Programa(this);
                    check = comparar(aux, cont);
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
        /*  public bool comparar(char[,] t, int cont )
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
                  for (int i = 0; i < 8; i++)
                  {
                      for (int j = 0; j < 8; j++)
                      {
                          aux1[i, j] = t[i, j];
                      }
                  }
                  return true;
              case 2:
                  int acum1 = 0;
                  for (int i = 0; i < 8; i++)
                  {
                      for (int j = 0; j < 8; j++)
                      {
                          aux2[i, j] = t[i, j];
                          if(aux1[i, j] == t[i, j])
                          {
                              acum1 = acum1 + 1;
                          }
                      }
                  }
                  if (acum1 == 64) { return false; } else return true;


              case 3:
                  int acum2 = 0;
                  int acum3 = 0;
                  for (int i = 0; i < 8; i++)
                  {
                      for (int j = 0; j < 8; j++)
                      {
                          aux3[i, j] = t[i, j];
                          if (aux1[i, j] == t[i, j])
                          {
                              acum2 = acum2 + 1;
                          }
                          if (aux2[i, j] == t[i, j])
                          {
                              acum3 = acum3 + 1;
                          }
                      }
                  }
                  if (acum2 == 64||acum3==64)
                      return true;
                  else return false;

              case 4:
                  int acum4 = 0;
                  int acum5 = 0;
                  int acum6 = 0;

                  for (int i = 0; i < 8; i++)
                  {
                      for (int j = 0; j < 8; j++)
                      {
                          aux4[i, j] = t[i, j];
                          if (aux1[i, j] == t[i, j])
                          {
                              acum4 = acum4 + 1;
                          }
                          if (aux2[i, j] == t[i, j])
                          {
                              acum5 = acum5 + 1;
                          }
                          if (aux3[i, j] == t[i, j])
                          {
                              acum6 = acum6 + 1;
                          }
                      }
                  }
                  if (acum4 == 64 || acum5 == 64||acum6==64)
                      return true;
                  else return false;

              case 5:
                  int acum7 = 0;
                  int acum8 = 0;
                  int acum9 = 0;
                  int acum10 = 0;

                  for (int i = 0; i < 8; i++)
                  {
                      for (int j = 0; j < 8; j++)
                      {
                          aux5[i, j] = t[i, j];

                          if (aux1[i, j] == t[i, j])
                          {
                              acum7 = acum7 + 1;
                          }
                          if (aux2[i, j] == t[i, j])
                          {
                              acum8 = acum8 + 1;
                          }
                          if (aux3[i, j] == t[i, j])
                          {
                              acum9 = acum9 + 1;
                          }
                          if (aux4[i, j] == t[i, j])
                          {
                              acum10 = acum10 + 1;
                          }
                      }
                  }
                  if (acum7 == 64 || acum8 == 64 || acum9 == 64 || acum10 == 64)
                      return true;
                  else return false;


              case 6:
                  int acum11 = 0;
                  int acum12 = 0;
                  int acum13 = 0;
                  int acum14 = 0;
                  int acum15 = 0;

                  for (int i = 0; i < 8; i++)
                  {
                      for (int j = 0; j < 8; j++)
                      {
                          aux6[i, j] = t[i, j];

                          if (aux1[i, j] == t[i, j])
                          {
                              acum11 = acum11 + 1;
                          }
                          if (aux2[i, j] == t[i, j])
                          {
                              acum12 = acum12 + 1;
                          }
                          if (aux3[i, j] == t[i, j])
                          {
                              acum13 = acum13 + 1;
                          }
                          if (aux4[i, j] == t[i, j])
                          {
                              acum14 = acum14 + 1;
                          }
                          if (aux5[i, j] == t[i, j])
                          {
                              acum15 = acum15 + 1;
                          }
                      }
                  }
                  if (acum11 == 64 || acum12 == 64 || acum13 == 64 || acum14 == 64 || acum15 == 64)
                      return true;
                  else return false;

              case 7:
                  int acum16 = 0;
                  int acum17 = 0;
                  int acum18 = 0;
                  int acum19 = 0;
                  int acum20 = 0;
                  int acum21 = 0;


                  for (int i = 0; i < 8; i++)
                  {
                      for (int j = 0; j < 8; j++)
                      {
                          aux7[i, j] = t[i, j];

                          if (aux1[i, j] == t[i, j])
                          {
                              acum16 = acum16 + 1;
                          }
                          if (aux2[i, j] == t[i, j])
                          {
                              acum17 = acum17 + 1;
                          }
                          if (aux3[i, j] == t[i, j])
                          {
                              acum18 = acum18 + 1;
                          }
                          if (aux4[i, j] == t[i, j])
                          {
                              acum19 = acum19 + 1;
                          }
                          if (aux5[i, j] == t[i, j])
                          {
                              acum20 = acum20 + 1;
                          }
                          if (aux6[i, j] == t[i, j])
                          {
                              acum21 = acum21 + 1;
                          }
                      }
                  }
                  if (acum16 == 64 || acum17 == 64 || acum18 == 64 || acum19 == 64 || acum20 == 64|| acum21 == 64)
                      return true;
                  else return false;

              case 8:
                  int acum22 = 0;
                  int acum23 = 0;
                  int acum24 = 0;
                  int acum25 = 0;
                  int acum26 = 0;
                  int acum27 = 0;
                  int acum28 = 0;

                  for (int i = 0; i < 8; i++)
                  {
                      for (int j = 0; j < 8; j++)
                      {
                          aux7[i, j] = t[i, j];

                          if (aux1[i, j] == t[i, j])
                          {
                              acum22 = acum22 + 1;
                          }
                          if (aux2[i, j] == t[i, j])
                          {
                              acum23 = acum23 + 1;
                          }
                          if (aux3[i, j] == t[i, j])
                          {
                              acum24 = acum24 + 1;
                          }
                          if (aux4[i, j] == t[i, j])
                          {
                              acum25 = acum25 + 1;
                          }
                          if (aux5[i, j] == t[i, j])
                          {
                              acum26 = acum26 + 1;
                          }
                          if (aux6[i, j] == t[i, j])
                          {
                              acum27 = acum27 + 1;
                          }
                          if (aux7[i, j] == t[i, j])
                          {
                              acum28 = acum28 + 1;
                          }
                      }
                  }
                  if (acum22 == 64 || acum23 == 64 || acum24 == 64 || acum25 == 64 || acum26 == 64 || acum27 == 64 || acum28 == 64)
                      return true;
                  else return false;

              case 9:
                  int acum29 = 0;
                  int acum30 = 0;
                  int acum31 = 0;
                  int acum32 = 0;
                  int acum33 = 0;
                  int acum34 = 0;
                  int acum35 = 0;
                  int acum36 = 0;

                  for (int i = 0; i < 8; i++)
                  {
                      for (int j = 0; j < 8; j++)
                      {
                          aux7[i, j] = t[i, j];

                          if (aux1[i, j] == t[i, j])
                          {
                              acum29 = acum29 + 1;
                          }
                          if (aux2[i, j] == t[i, j])
                          {
                              acum30 = acum30 + 1;
                          }
                          if (aux3[i, j] == t[i, j])
                          {
                              acum31 = acum31 + 1;
                          }
                          if (aux4[i, j] == t[i, j])
                          {
                              acum32 = acum32+ 1;
                          }
                          if (aux5[i, j] == t[i, j])
                          {
                              acum33 = acum33 + 1;
                          }
                          if (aux6[i, j] == t[i, j])
                          {
                              acum34 = acum34 + 1;
                          }
                          if (aux7[i, j] == t[i, j])
                          {
                              acum35 = acum35 + 1;
                          }
                          if (aux8[i, j] == t[i, j])
                          {
                              acum36 = acum36 + 1;
                          }
                      }
                  }
                  if (acum29 == 64 || acum30 == 64 || acum31 == 64 || acum32 == 64 || acum33 == 64 || acum34== 64 || acum35== 64 || acum36 == 64)
                      return true;
                  else return false;
              case 10:
                  int acum37 = 0;
                  int acum38 = 0;
                  int acum39 = 0;
                  int acum40 = 0;
                  int acum41 = 0;
                  int acum42 = 0;
                  int acum43 = 0;
                  int acum44 = 0;
                  int acum45 = 0;

                  for (int i = 0; i < 8; i++)
                  {
                      for (int j = 0; j < 8; j++)
                      {
                          aux7[i, j] = t[i, j];

                          if (aux1[i, j] == t[i, j])
                          {
                              acum37 = acum37 + 1;
                          }
                          if (aux2[i, j] == t[i, j])
                          {
                              acum38 = acum38 + 1;
                          }
                          if (aux3[i, j] == t[i, j])
                          {
                              acum39 = acum39 + 1;
                          }
                          if (aux4[i, j] == t[i, j])
                          {
                              acum40 = acum40 + 1;
                          }
                          if (aux5[i, j] == t[i, j])
                          {
                              acum41 = acum41 + 1;
                          }
                          if (aux6[i, j] == t[i, j])
                          {
                              acum42 = acum42 + 1;
                          }
                          if (aux7[i, j] == t[i, j])
                          {
                              acum43 = acum43 + 1;
                          }
                          if (aux8[i, j] == t[i, j])
                          {
                              acum44 = acum44+ 1;
                          }
                          if (aux9[i, j] == t[i, j])
                          {
                              acum45 = acum45 + 1;
                          }
                      }
                  }
                  if (acum37 == 64 || acum38 == 64 || acum39 == 64 || acum40== 64 || acum41 == 64 || acum42 == 64 || acum43== 64 || acum44== 64 || acum45 == 64)
                      return true;
                  else return false;
              default: return false;
          }






      }*/

        public bool comparar(char[,] t, int cont)
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
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            aux1[i, j] = t[i, j];
                        }
                    }
                    return true;
                case 2:
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            aux2[i, j] = t[i, j];
                        }
                    }
                    if (aux2 == aux1)
                    {
                        return false;
                    }
                    else { return true; }
                case 3:
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            aux3[i, j] = t[i, j];
                        }
                    }
                    if (aux3 == aux1 || aux3 == aux2)
                    {
                        return false;
                    }
                    else { return true; }
                case 4:
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            aux4[i, j] = t[i, j];
                        }
                    }
                    if (aux4 == aux1 || aux4 == aux2 || aux4 == aux3)
                    {
                        return false;
                    }
                    else { return true; }
                case 5:
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            aux5[i, j] = t[i, j];
                        }
                    }
                    if (aux5 == aux1 || aux5 == aux2 || aux5 == aux3 || aux5 == aux4)
                    {
                        return false;
                    }
                    else { return true; }
                case 6:
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            aux6[i, j] = t[i, j];
                        }
                    }
                    if (aux6 == aux1 || aux6 == aux2 || aux6 == aux3 || aux6 == aux4 || aux6 == aux5)
                    {
                        return false;
                    }
                    else { return true; }
                case 7:
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            aux7[i, j] = t[i, j];
                        }
                    }
                    if (aux7 == aux1 || aux7 == aux2 || aux7 == aux3 || aux7 == aux4 || aux7 == aux5 || aux7 == aux6)
                    {
                        return false;
                    }
                    else { return true; }
                case 8:
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            aux8[i, j] = t[i, j];
                        }
                    }
                    if (aux8 == aux1 || aux8 == aux2 || aux8 == aux3 || aux8 == aux4 || aux8 == aux5 || aux8 == aux6 || aux8 == aux7)
                    {
                        return false;
                    }
                    else { return true; }
                case 9:
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            aux9[i, j] = t[i, j];
                        }
                    }
                    if (aux9 == aux1 || aux9 == aux2 || aux9 == aux3 || aux9 == aux4 || aux9 == aux5 || aux9 == aux6 || aux9 == aux7 || aux9 == aux8)
                    {
                        return false;
                    }
                    else { return true; }
                case 10:
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            aux9[i, j] = t[i, j];
                        }
                    }
                    if (aux10 == aux1 || aux10 == aux2 || aux10 == aux3 || aux10 == aux4 || aux10 == aux5 || aux10 == aux6 || aux10 == aux7 || aux10 == aux8 || aux10 == aux9)
                    {
                        return false;
                    }
                    else { return true; }
                default: return false;
            }
        }
    }

}