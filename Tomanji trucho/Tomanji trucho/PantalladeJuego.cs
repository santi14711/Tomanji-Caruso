using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomanji_trucho
{
    public partial class PantalladeJuego : Form
    {

        

        public PantalladeJuego()
        {
            InitializeComponent();
        }
        int turno;
        int randomretos;
        string retoactual;
        private void PantalladeJuego_Load(object sender, EventArgs e)
        {
            turno = todo.TurnoJug.Next(0, todo.nombresjugadores.Count);
            label2.Text = Convert.ToString(todo.nombresjugadores[turno].Nombre);
          
            Retos uno = new Retos("tomar 1 copa", 2);
            todo.CantidadRetos.Add(uno);
            Retos dos = new Retos("tomar mucho bro", 5);
            todo.CantidadRetos.Add(dos);

            randomretos = todo.TurnoJug.Next(0, todo.CantidadRetos.Count);
            retoactual = Convert.ToString(todo.CantidadRetos[randomretos].Reto);
            label3.Text = retoactual;


            label4.Text = "Este reto vale: " + Convert.ToString(todo.CantidadRetos[randomretos].Puntos) + " puntos";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            turno = todo.TurnoJug.Next(0, todo.nombresjugadores.Count);
            label2.Text = Convert.ToString(todo.nombresjugadores[turno].Nombre);

            randomretos = todo.TurnoJug.Next(0, todo.CantidadRetos.Count);
            label3.Text = Convert.ToString(todo.CantidadRetos[randomretos].Reto);

            label4.Text = "Este reto vale: "+Convert.ToString(todo.CantidadRetos[randomretos].Puntos)+" puntos";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarReto ag = new AgregarReto();
            ag.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;

            todo.nombresjugadores[turno].Puntos += todo.CantidadRetos[randomretos].Puntos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = false;

            todo.nombresjugadores[turno].Puntos -= todo.CantidadRetos[randomretos].Puntos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            todo.PantallaJuego.Hide();

            Puntajes punt = new Puntajes();
            punt.Show();
        }
    }
}
