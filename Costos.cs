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
            textBox1.Text = "EL MEJOR DE LOS CASOS: es de orden lineal, lo mejor que puede pasar es que a las primeras diez corridas del programa nos encuentre e imprima los 10 tableros llenos distintos."+"\n"+ " Lo que tendria que pasar es que cuando le asignamos la posicion a las piezas, llamo a la funcion mover" + "\n" + " 8 veces(una por cada pieza) y cuando llamo a contar el contador de posiciones nos de mayor a 63, es decir que este lleno." + "\n\n" + " EL PEOR DE LOS CASOS:es de orden lineal tambien, lo peor que nos puede pasar es que nunca encuentre ningun tablero lleno porque todas las posiciones que nos tira no llegan a completar el tablero. Entonces se llamaria " + "\n" + "a la funcion mover un monton de veces y nunca llegaria al objetivo. Ademas de que se llamaria reiteradas veces a funciones que se podrian evitar y asi el algortimo tardaria mas" + "\n\n" + "Para lograr que cumpla con los requisitos de la consigna, que nos genere los 10 tableros utilizamos la poda." + "\n" + "Por ejemplo, a las torres las dejamos fijas en la posicion(1,1) y(8, 8) esto lo hacemos para que el tablero de 8x8 se nos achique a uno de 6x6.Otra condicion que pusimos es que" + "\n" + "la reina se encuentre dentro de un subtablero de 4x4.Ademas en los alfiles pusimos como condicion que se encuentren en la misma fila que la reina ya que si se ubicaban en la misma diagonal iban a repetir muchos espacios";
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
