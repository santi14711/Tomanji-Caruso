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
          
            Retos uno = new Retos("El jugador actual debe cantar libre soy en voz alta por 10 segundos y luego tomar.", 2);
            todo.CantidadRetos.Add(uno);
            Retos dos = new Retos("Noubady misi clan misi down, de que cancion es esta letra?. Tiene un intento para adivinar.", 5);
            todo.CantidadRetos.Add(dos);

            randomretos = todo.TurnoJug.Next(0, todo.CantidadRetos.Count);
            retoactual = Convert.ToString(todo.CantidadRetos[randomretos].Reto);
            label3.Text = retoactual;


            label4.Text = "" + Convert.ToString(todo.CantidadRetos[randomretos].Puntos) + "";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            turno = todo.TurnoJug.Next(0, todo.nombresjugadores.Count);
            label2.Text = Convert.ToString(todo.nombresjugadores[turno].Nombre);

            randomretos = todo.TurnoJug.Next(0, todo.CantidadRetos.Count);
            label3.Text = Convert.ToString(todo.CantidadRetos[randomretos].Reto);

            label4.Text = Convert.ToString(todo.CantidadRetos[randomretos].Puntos);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
