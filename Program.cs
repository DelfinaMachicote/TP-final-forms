using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5_ESTE
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>


        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static char[,] Programa(Form ta)
        {

            bool check = false;

            int cont_posiciones;

            char[,] aux = new char[8, 8];

            while (check == false)
            {
                Random rnd = new Random();

                //genero todas las piezas sin restricciones en las posiciones
                Reina reina = new Reina(rnd.Next(0, 7), rnd.Next(0, 7));
                Rey rey = new Rey(rnd.Next(0, 7), rnd.Next(0, 7));
                Torre torre1 = new Torre(rnd.Next(0, 7), rnd.Next(0, 7));
                Torre torre2 = new Torre(rnd.Next(0, 7), rnd.Next(0, 7));
                Alfil alfil1 = new Alfil(rnd.Next(0, 7), rnd.Next(0, 7));
                Alfil alfil2 = new Alfil(rnd.Next(0, 7), rnd.Next(0, 7));
                Caballo caballo1 = new Caballo(rnd.Next(0, 7), rnd.Next(0, 7));
                Caballo caballo2 = new Caballo(rnd.Next(0, 7), rnd.Next(0, 7));

                //creo el tablero
                char[,] tablero = new char[8, 8];
                //inicializo todo el tablero en 0
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        tablero[i, j] = '0';
                    }
                }

                //me aseguro de que se cumplan todas las restricciones
                Asignar(reina, rey, torre1, torre2, alfil1, alfil2, caballo1, caballo2, tablero);

                //muevo cada pieza

                torre1.Mover(tablero);

                torre2.Mover(tablero);
                tablero[torre2.f, torre2.c] = 't';

                caballo1.Mover(tablero);

                caballo2.Mover(tablero);
                tablero[caballo2.f, caballo2.c] = 'c';

                rey.Mover(tablero);
                alfil1.Mover(tablero);

                alfil2.Mover(tablero);
                tablero[alfil2.f, alfil2.c] = 'a';

                reina.Mover(tablero);

              


                //cuento los casilleros del tablero que se llenaron
                cont_posiciones = Contar(tablero);

                //si el tablero esta lleno, se imprime
                if (cont_posiciones > 63)
                {
                    check = true;
                    aux = tablero;
                }
            }
            return aux;
        }

        public static void Asignar(Reina reina, Rey rey, Torre t1, Torre t2, Alfil a1, Alfil a2, Caballo c1, Caballo c2, char[,] tablero)
        {
            //pasamos todas las piezas por separado porque salta error cada vez que casteamos la clase padre

            Random rnd = new Random();

            t1.f = 0;//la torre 1 estara en la fila 1
            t1.c = 0;
            t2.f = 7;//la torre 2 estara en la fila 8
            t2.c = 7;

            while ((reina.f == c2.f && reina.c == c2.c) || (c2.f == a2.f && c2.c == a2.c) || (c2.f == c1.f && c2.c == c1.c) || (a1.f == c2.f && a1.c == c2.c) || (a2.f == c2.f && a2.c == c2.c) || (reina.f == c1.f && reina.c == c1.c) || (c1.f == a2.f && c1.c == a2.c) || (a1.f == c1.f && a1.c == c1.c) || (c1.f == c2.f && c1.c == c2.c) || (a2.f == c1.f && a2.c == c1.c) || (a2.f == rey.f && a2.c == rey.c) || (reina.f == a2.f && reina.c == a2.c) || (a1.f == a2.f && a1.c == a2.c) || (a2.f == c1.f && a2.c == c1.c) || (a2.f == c2.f && a2.c == c2.c) || (a1.f == rey.f && a1.c == rey.c) || (reina.f == a1.f && reina.c == a1.c) || (a1.f == a2.f && a1.c == a2.c) || (a1.f == c1.f && a1.c == c1.c) || (a1.f == c2.f && a1.c == c2.c) || (reina.f == rey.f && reina.c == rey.c) || (rey.f == a1.f && rey.c == a1.c) || (rey.f == a2.f && rey.c == a2.c) || (reina.f == rey.f && reina.c == rey.c) || (reina.f == a1.f && reina.c == a1.c) || (reina.f == a2.f && reina.c == a2.c) || (reina.f == c2.f && reina.c == c2.c) || (reina.f == c1.f && reina.c == c1.c) || (t1.f==c1.f&& t1.c==c1.c)|| (t1.f == c2.f && t1.c == c2.c) || (t2.f == c1.f && t2.c == c1.c) || (t2.f == c2.f && t2.c == c2.c))
            {
                reina.f = rnd.Next(1, 6);
                reina.c = rnd.Next(1, 6);

                rey.f = rnd.Next(1, 6);
                rey.c = rnd.Next(1, 6);

                c1.f = rnd.Next(2, 5);
                c1.c = rnd.Next(2, 5);

                c2.f = rnd.Next(2, 5);
                c2.c = rnd.Next(2, 5);

                a1.f = reina.f;//hago que los alfiles esten en la misma fila que la reina para que no se superponga ninguna de las diagonales
                a1.c = rnd.Next(1, 6);

                a2.f = reina.f;
                a2.c = rnd.Next(1, 6);

                //condicion para que un alfil este en un color y otro alfil este en el otro
                if ((a2.c % 2 == 0 && a1.c % 2 == 0) || (a2.c % 2 == 1 && a1.c % 2 == 1))
                {
                    if (a2.c + 1 < 7)
                    {
                        a2.c += 1;
                    }
                    else
                    {
                        a2.c = a2.c - 1;
                    }
                }
            }
        }

        public static char[,] Reordenar(char[,] tab, int caso)
        {
            Reina reina = new Reina(0, 0);
            Rey rey = new Rey(0, 0);
            Torre torre1 = new Torre(0, 0);
            Torre torre2 = new Torre(0, 0);
            Alfil alfil1 = new Alfil(0, 0);
            Alfil alfil2 = new Alfil(0, 0);
            Caballo caballo1 = new Caballo(7, 7);
            Caballo caballo2 = new Caballo(0, 0);
            char[,] aux2 = new char[8, 8];
            char[,] aux3 = new char[8, 8];
            char[,] aux4 = new char[8, 8];
            char[,] aux5 = new char[8, 8];



            for (int i = 0; i < 8; i++)//recorre el tablero y localiza cada pieza
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tab[i, j] == 'D')
                    {
                        reina.f = i;
                        reina.c = j;
                    }
                    if (tab[i, j] == 'R')
                    {
                        rey.f = i;
                        rey.c = j;
                    }
                    if (tab[i, j] == 'T')
                    {
                        torre1.f = i;
                        torre1.c = j;
                    }
                    if (tab[i, j] == 't')
                    {
                        torre2.f = i;
                        torre2.c = j;
                    }
                    if (tab[i, j] == 'C')
                    {
                        caballo1.f = i;
                        caballo1.c = j;
                    }
                    if (tab[i, j] == 'c')
                    {
                        caballo2.f = i;
                        caballo2.c = j;
                    }
                    if (tab[i, j] == 'A')
                    {
                        alfil1.f = i;
                        alfil1.c = j;
                    }
                    if (tab[i, j] == 'a')
                    {
                        alfil2.f = i;
                        alfil2.c = j;
                    }

                    //implemento en el mismo for diferentes formas de rotar el tablero
                    aux2[i,j] = tab[i, j];
                    aux3[j, i] = tab[i, j];
                    aux4[7 - i, 7 - j] = tab[i, j];
                    aux5[7 - i, 7 - j] = aux3[i, j];
                }
            }


            switch (caso)
            {
                case 1: //muevo solo las torres

                    torre1.f = 7;
                    torre1.c = 0;

                    torre2.f = 0;
                    torre2.c = 7;

                    torre1.Mover(aux2);

                    torre2.Mover(aux2);
                    aux2[torre2.f, torre2.c] = 't';

                    caballo1.Mover(aux2);

                    caballo2.Mover(aux2);
                    aux2[caballo2.f, caballo2.c] = 'c';

                    rey.Mover(aux2);

                    reina.Mover(aux2);

                    alfil1.Mover(aux2);

                    alfil2.Mover(aux2);
                    aux2[alfil2.f, alfil2.c] = 'a';
                    return aux2;

                case 2:
                    return aux3;
                case 3:
                    return aux4;
                case 4:
                  return aux5;
                default: return tab;

            }

        }

        public static int Contar(char[,] tablero)
        {
            int contador = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tablero[i, j] != '0')
                        contador++;
                }
            }
            return contador;
        }
    }
}
