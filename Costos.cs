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
    public partial class Costos : Form
    {
        Main main;
        public Costos(Main main)
        {
            InitializeComponent();
            this.main = main;
            textBox1.Text = "T(n)=8n^2 + 280n";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }
    }
}
