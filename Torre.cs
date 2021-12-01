using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5_ESTE
{
    class Torre : Pieza
    {
        public Torre(int x, int y)
        {
            this.f = x;
            this.c = y;
        }
        public void Mover(char[,] tablero)
        {
            for (int i = c; i < 8; i++)//muevo hacia arriba
            {

                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T')
                {
                    tablero[i, c] = '1';
                }

            }
            for (int i = c; i >= 0; i--)//muevo hacia abajo
            {
                if (tablero[i, c] == '0')
                    tablero[i, c] = '1';
            }
            for (int i = c; i < 8; i++)//muevo a la derecha
            {
                if (tablero[f, i] == '0')
                    tablero[f, i] = '1';
            }
            for (int i = c; i >= 0; i--)//muevo a la izquierda
            {
                if (tablero[f, i] == '0')
                    tablero[f, i] = '1';
            }
            tablero[f, c] = 'T';
        }
    }
}
