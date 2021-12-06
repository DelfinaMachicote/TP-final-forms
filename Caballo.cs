using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5_ESTE
{
    class Caballo : Pieza
    {
        int posicion;
        public Caballo(int x, int y)
        {
            this.f = x;
            this.c = y;
            posicion = 8 * f + (c + 1);
        }
        public void Mover(char[,] tablero)
        {


            if ((c + 1 < 8) && (f + 2 < 8))
            {
                if (tablero[f + 2, c + 1] == '0' || tablero[f + 2, c + 1] == '2')
                    tablero[f + 2, c + 1] = '1';// arriba y a la derecha
            }


            if ((f + 2 < 8) && (c - 1 >= 0))
            {
                if (tablero[f + 2, c - 1] == '0' || tablero[f + 2, c - 1] == '2')
                    tablero[f + 2, c - 1] = '1';// arriba y a la izquierda
            }


            if (c + 2 < 8 && f + 1 < 8)
            {
                if (tablero[f + 1, c + 2] == '0'|| tablero[f + 1, c + 2] == '2')
                    tablero[f + 1, c + 2] = '1';//a la derecha y arriba
            }

            if ((c + 2 < 8) && f - 1 >= 0)
            {
                if (tablero[f - 1, c + 2] == '0'|| tablero[f - 1, c + 2] == '0')
                    tablero[f - 1, c + 2] = '1';//a la derecha abajo
            }
            if (f + 1 < 8 && c - 2 >= 0)
            {
                if (tablero[f + 1, c - 2] == '0'|| tablero[f + 1, c - 2] == '2')
                    tablero[f + 1, c - 2] = '1';//a la izquierda arriba
            }


            if (c - 2 >= 0 && f - 1 >= 0)
            {
                if (tablero[f - 1, c - 2] == '0'|| tablero[f - 1, c - 2] == '2')
                    tablero[f - 1, c - 2] = '1';//a la izquierda abajo
            }


            if (f - 2 >= 0 && c + 1 < 8)
            {
                if (tablero[f - 2, c + 1] == '0'|| tablero[f - 2, c + 1] == '2')
                    tablero[f - 2, c + 1] = '1';//abajo a la derecha
            }


            if (c - 1 >= 0 && f - 2 >= 0)
            {
                if (tablero[f - 2, c - 1] == '0'|| tablero[f - 2, c - 1] == '2')
                    tablero[f - 2, c - 1] = '1';//abajo a la izquierda
            }
            tablero[f, c] = 'C';
        }
    }
}
