using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5_ESTE
{
    class Rey : Pieza
    {
        int posicion;
        public Rey(int x, int y)
        {
            this.f = x;
            this.c = y;
             posicion = 8 * f + (c + 1);
        }

        public void Mover(char[,] tablero)
        {
            
            if (f + 1 < 8)
                tablero[f+1, c] = '1';//muevo hacia arriba
            if (c + 1 < 8)
                tablero[f , c+1] = '1';//muevo hacia la derecha
            if (f - 1 >= 1)
                tablero[f-1, c] = '1';//muevo hacia abajo
            if (c - 1 >= 1)
                tablero[f, c-1] = '1';//muevo hacia la izquierda

            if (f + 1 < 8 && c + 1 < 8)//arriba a la derecha
                tablero[f + 1, c + 1] = '1';
            if (c + 1 < 8 && f - 1 >= 0)//abajo a la derecha
                tablero[f - 1, c + 1] = '1';
            if (c - 1 >= 0 && f + 1 < 8)//arriba a la izquierda
                tablero[f + 1, c - 1] = '1';
            if (c - 1 >= 0 && f - 1 >= 0)//abajo a la izquierda
                tablero[f - 1, c - 1] = '1';
            tablero[f, c] = 'R';
        }
    }
}
