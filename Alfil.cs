﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5_ESTE
{
    class Alfil : Pieza
    {
        public Alfil(int f, int c)
        {
            this.f = f;
            this.c = c;
        }
        public void Mover(char[,] tablero)
        {
            for (int i = 0; i < 8; i++)//diagonal arriba a la derecha
            {
                if (f + i < 8 && c + i < 8)
                {
                    if (tablero[f + i, c + i] == '0')
                    {

                        tablero[f + i, c + i] = '1';
                    }
                }

            }
            for (int i = 0; i < 8; i++)//diagonal abajo a la derecha  
            {
                if (c - i >= 0 && f + i < 8)
                {
                    if (tablero[f + i, c - i] == '0')
                    {

                        tablero[f + i, c - i] = '1';
                    }
                }
            }
            for (int i = 0; i < 8; i++)//diagonal arriba a la izquierda
            {
                if (c + i < 8 && f - i >= 0)
                {
                    if (tablero[f - i, c + i] == '0')
                    {

                        tablero[f - i, c + i] = '1';
                    }
                }

            }
            for (int i = 0; i < 8; i++)//diagonal abajo a la izquierda
            {
                if (f - i >= 0 && c - i >= 0)
                {
                    if (tablero[f - i, c - i] == '0')
                    {

                        tablero[f - i, c - i] = '1';
                    }
                }

            }
            tablero[f, c] = 'A';
        }
    }
}
