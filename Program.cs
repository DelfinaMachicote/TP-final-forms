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

        public static char[,] Programa(Tablero ta)
        {
            
            int cont_tableros = 0;
            //bool[,] matrizOriginal = random(n, 50); //Creo la matriz random
            //bool[,] tablero = new bool[8, 8];
            int cont_posiciones = 0;

            char[,] aux = new char[8, 8];
            
            while (cont_tableros <= 9)
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
                Asignar(reina, rey, torre1, torre2, alfil1, alfil2, caballo1, caballo2);

                //muevo cada pieza
                reina.Mover(tablero);
                rey.Mover(tablero);
                alfil1.Mover(tablero);
                alfil2.Mover(tablero);
                torre1.Mover(tablero);
                torre2.Mover(tablero);
                caballo1.Mover(tablero);
                caballo2.Mover(tablero);


                //cuento los casilleros del tablero que se llenaron
                cont_posiciones = Contar(tablero);

                //si el tablero esta lleno, se imprime
                if (cont_posiciones > 63)
                {
                    cont_tableros++;
                    Imprimir(tablero);

                }
                aux = tablero;

            }
            return aux;
            
        }

        public static void Asignar(Reina reina, Rey rey, Torre t1, Torre t2, Alfil a1, Alfil a2, Caballo c1, Caballo c2)
        {//pasamos todas las piezas por separado porque salta error cada vez que casteamos la clase padre


            Random rnd = new Random();

            t1.x = 0;//la torre 1 estara en la columna 1
            t1.y = 0;
            t2.x = 7;//la torre 2 estara en la columna 8
            t2.y = 7;

          
            while ((reina.x == c2.x && reina.y == c2.y) || (c2.x == a2.x && c2.y == a2.y) || (c2.x == c1.x && c2.y == c1.y) || (a1.x == c2.x && a1.y == c2.y) || (a2.x == c2.x && a2.y == c2.y) || (reina.x == c1.x && reina.y == c1.y) || (c1.x == a2.x && c1.y == a2.y) || (a1.x == c1.x && a1.y == c1.y) || (c1.x == c2.x && c1.y == c2.y) || (a2.x == c1.x && a2.y == c1.y) || (a2.x == rey.x && a2.y == rey.y) || (reina.x == a2.x && reina.y == a2.y) || (a1.x == a2.x && a1.y == a2.y) || (a2.x == c1.x && a2.y == c1.y) || (a2.x == c2.x && a2.y == c2.y) || (a1.x == rey.x && a1.y == rey.y) || (reina.x == a1.x && reina.y == a1.y) || (a1.x == a2.x && a1.y == a2.y) || (a1.x == c1.x && a1.y == c1.y) || (a1.x == c2.x && a1.y == c2.y) || (reina.x == rey.x && reina.y == rey.y) || (rey.x == a1.x && rey.y == a1.y) || (rey.x == a2.x && rey.y == a2.y) || (reina.x == rey.x && reina.y == rey.y) || (reina.x == a1.x && reina.y == a1.y) || (reina.x == a2.x && reina.y == a2.y) || (reina.x == c2.x && reina.y == c2.y) || (reina.x == c1.x && reina.y == c1.y))
            {
                reina.x = rnd.Next(2, 5);
                reina.y = rnd.Next(2, 5);

                c1.x = rnd.Next(2, 5);
                c1.y = rnd.Next(2, 5);

                c2.x = rnd.Next(2, 5);
                c2.y = rnd.Next(2, 5);

                a1.x = reina.x;//hago que los alfiles esten en la columna que la reina para que no se superponga ninguna de las diagonales
                a1.y = rnd.Next(1, 6);

                a2.x = reina.x;
                a2.y = rnd.Next(1, 6);

                rey.x = rnd.Next(1, 6);
                rey.y = rnd.Next(1, 6);

              
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

        public static string Imprimir(char[,] tablero)
        {
            string t = null;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    //Console.Write(tablero[j, i] + "    ");
                    t += tablero[j, i] + "   ";
                }
                t += "\n";
            }
            return t;
        }
    }
}
