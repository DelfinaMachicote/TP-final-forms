﻿using System;
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
        int cont = 1;
        public Tablero(Main main)
        {
            InitializeComponent();
            this.main = main;
            
            char[,] tab = Program.Programa(this);
            Titulo.Text = "Tablero " + cont;
            imprimir.Text = Program.Imprimir(tab);
        }
        public void setCont(int c)
        {
            this.cont = c;
        }
        private void Volver_Click(object sender, EventArgs e)
        {
            // Main main = new Main();
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
            char[,] tab = Program.Programa(this);
            imprimir.Text = Program.Imprimir(tab);
            setCont(++cont);
            Titulo.Text = "Tablero " + cont;

        }

        private void Titulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
