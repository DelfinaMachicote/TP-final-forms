using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5_ESTE
{
    static class Program
    {
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
            Random rnd = new Random();

            while (check == false)
            {
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

            while (((reina.f == c2.f && reina.c == c2.c) || (c2.f == a2.f && c2.c == a2.c) || (c2.f == c1.f && c2.c == c1.c) ||  (a1.f == c2.f && a1.c == c2.c) || (a2.f == c2.f && a2.c == c2.c) || (reina.f == c1.f && reina.c == c1.c) ||   (c1.f == a2.f && c1.c == a2.c) || (a1.f == c1.f && a1.c == c1.c) || (c1.f == c2.f && c1.c == c2.c) || (a2.f == c1.f && a2.c == c1.c) || (a2.f == rey.f && a2.c == rey.c) || (reina.f == a2.f && reina.c == a2.c) || (a1.f == a2.f && a1.c == a2.c) || (a2.f == c1.f && a2.c == c1.c) || (a2.f == c2.f && a2.c == c2.c) || (a1.f == rey.f && a1.c == rey.c) || (reina.f == a1.f && reina.c == a1.c) || (a1.f == a2.f && a1.c == a2.c) || (a1.f == c1.f && a1.c == c1.c) || (a1.f == c2.f && a1.c == c2.c) || (reina.f == rey.f && reina.c == rey.c) || (rey.f == a1.f && rey.c == a1.c) || (rey.f == a2.f && rey.c == a2.c) || (reina.f == rey.f && reina.c == rey.c) || (reina.f == a1.f && reina.c == a1.c) || (reina.f == a2.f && reina.c == a2.c) || (reina.f == c2.f && reina.c == c2.c) || (reina.f == c1.f && reina.c == c1.c) || (t1.f==c1.f&& t1.c==c1.c)|| (t1.f == c2.f && t1.c == c2.c) || (t2.f == c1.f && t2.c == c1.c) || (t2.f == c2.f && t2.c == c2.c)) && (reina.f!= a1.f || reina.f!= a2.f) )
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

                int ac1 = a1.c;
                int ac2 = a2.c;

                //condicion para que un alfil este en un color y otro alfil este en el otro
                if ((ac2 % 2 == 0 && ac1 % 2 == 0)|| ((ac2 + 1) % 2 == 0 && (ac1 + 1) % 2 == 0))
                {
                    if (a2.c + 1 < 7)
                    {
                        a2.c = a2.c + 1;
                    }
                    else
                    {
                        a2.c = a2.c - 1;
                    }
                }
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
