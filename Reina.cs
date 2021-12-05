using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5_ESTE
{
    class Reina : Pieza
    {

        public Reina(int x, int y)
        {
            this.f = x;
            this.c = y;
            //  Posiciones();//achico el tablero
        }

        public void Mover(char[,] tablero)
        {
            int aux = 8;

            for (int i = f; i < 8; i++)//muevo hacia abajo
            {

                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T')
                {
                    tablero[i, c] = '1';
                }
                else
                {
                    aux = i;
                    break;
                }
            }
            for (int i = aux; i < 8; i++)
            {
                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T' && tablero[i, c] != '1')
                    tablero[i, c] = '2';
            }
            aux = -1;


            for (int i = f; i >= 0; i--)//muevo hacia arriba
            {
                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T')
                {
                    tablero[i, c] = '1';
                }
                else
                {
                    aux = i;
                    break;
                }
            }
            for (int i = aux; i >= 0; i--)
            {
                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T' && tablero[i, c] != '1')
                    tablero[i, c] = '2';
            }
            aux = 8;

            for (int i = c; i < 8; i++)//muevo a la derecha
            {
                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T')
                {
                    tablero[f, i] = '1';
                }
                else
                {
                    aux = i;
                    break;
                }
            }
            for (int i = aux; i < 8; i++)
            {
                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T' && tablero[i, c] != '1')
                    tablero[i, c] = '2';
            }
            aux = 0;



            for (int i = c; i >= 0; i--)//muevo a la izquierda
            {
                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T')
                {
                    tablero[f, i] = '1';
                }
                else
                {
                    aux = i;
                    break;
                }
            }
            for (int i = aux; i >= 0; i--)
            {
                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T' && tablero[i, c] != '1')
                    tablero[i, c] = '2';
            }

            aux = 8;



            for (int i = 0; i < 8; i++)//diagonal abajo a la derecha
            {
                if (f + i < 7 && c + i < 7)
                {
                    if (tablero[f + i, c + i] != 'A' && tablero[f + i, c + i] != 'R' && tablero[f + i, c + i] != 'C' && tablero[f + i, c + i] != 'T')
                    {
                        tablero[f + i, c + i] = '1';
                    }
                    else
                    {
                        aux = i;
                        break;
                    }
                }

            }
            for (int i = aux; i < 8; i++)
            {
                if (f + i < 7 && c + i < 7)
                {
                    if (tablero[f + i, c + i] != 'A' && tablero[f + i, c + i] != 'R' && tablero[f + i, c + i] != 'C' && tablero[f + i, c + i] != 'T' && tablero[f + i, c + i] != '1')
                    {
                        tablero[f + i, c + i] = '2';
                    }
                }
            }
            aux = 8;



            for (int i = 0; i < 8; i++)//diagonal abajo a la izquierda 
            { 
                if (c - i >= 0 && f + i < 7)
                {
                    if (tablero[f + i, c - i] != 'A' && tablero[f + i, c - i] != 'R' && tablero[f + i, c - i] != 'C' && tablero[f + i, c - i] != 'T')
                    {
                        tablero[f + i, c - i] = '1';
                    }
                    else
                    {
                        aux = i;
                        break;
                    }
                }
            }
            for (int i = aux; i < 8; i++)
            {
                if (f + i < 7 && c - i >= 0)
                {
                    if (tablero[f + i, c - i] != 'A' && tablero[f + i, c - i] != 'R' && tablero[f + i, c - i] != 'C' && tablero[f + i, c - i] != 'T' && tablero[f + i, c - i] != '1')
                    {
                        tablero[f + i, c - i] = '2';
                    }
                }

            }

            aux = 8;

            for (int i = 0; i < 8; i++)//diagonal arriba a la derecha
            {
                if (c + i < 7 && f - i >= 0)
                {
                    if (tablero[f - i, c + i] != 'A' && tablero[f - i, c + i] != 'R' && tablero[f - i, c + i] != 'C' && tablero[f - i, c + i] != 'T')
                    {

                        tablero[f - i, c + i] = '1';
                    }
                    else
                    {
                        aux = i;
                        break;
                    }
                }
            }
            for (int i = aux; i < 8; i++)
            {
                if (f - i >= 0 && c + i < 7)
                {
                    if (tablero[f - i, c + i] != 'A' && tablero[f - i, c + i] != 'R' && tablero[f - i, c + i] != 'C' && tablero[f - i, c + i] != 'T' && tablero[f - i, c + i] != '1')
                    {

                        tablero[f - i, c + i] = '2';
                    }
                }

            }


            aux = 8;


            for (int i = 0; i < 8; i++)//diagonal arriba a la izquierda
            {
                if (f - i >= 0 && c - i >= 0)
                {
                    if (tablero[f - i, c - i] != 'A' && tablero[f - i, c - i] != 'R' && tablero[f - i, c - i] != 'C' && tablero[f - i, c - i] != 'T')
                    {

                        tablero[f - i, c - i] = '1';
                    }
                    else
                    {
                        aux = i;
                        break;
                    }
                }
            }
            for (int i = aux; i < 8; i++)
            {
                if (f - i >= 0 && c - i >= 0)
                {
                    if (tablero[f - i, c - i] != 'A' && tablero[f - i, c - i] != 'R' && tablero[f - i, c - i] != 'C' && tablero[f - i, c - i] != 'T' && tablero[f - i, c - i] != '1')
                    {
                        tablero[f - i, c - i] = '2';
                    }
                }

            }
            tablero[f, c] = 'D';
        }
      /*  
        public void MoverHorizontal(char[,] tablero)
        {
            int aux = 8;

            for (int i = c; i < 8; i++)//muevo a la derecha
            {
                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T'&& tablero[i,c] != 'D')
                {
                    tablero[f, i] = '1';
                }
                else
                {
                    aux = i;
                    break;
                }
            }
            for (int i = aux; i < 8; i++)
            {
                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T' && tablero[i,c] != 'D' && tablero[i, c] != '1')
                    tablero[i, c] = '2';
            }
            aux = 0;



            for (int i = c; i >= 0; i--)//muevo a la izquierda
            {
                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T' && tablero[i, c] != 'D')
                {
                    tablero[f, i] = '1';
                }
                else
                {
                    aux = i;
                    break;
                }
            }
            for (int i = aux; i >= 0; i--)
            {
                if (tablero[i, c] != 'A' && tablero[i, c] != 'R' && tablero[i, c] != 'C' && tablero[i, c] != 'T' && tablero[i, c] != 'D' && tablero[i, c] != '1')
                    tablero[i, c] = '2';
            }

            aux = 8;
        }
   
    */
    }
}