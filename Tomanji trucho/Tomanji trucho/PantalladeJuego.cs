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
            Retos tres = new Retos("Numeros romanos comenzando desde el jugador actual, hacia la derecha, quien pierda toma.", 3);
            todo.CantidadRetos.Add(tres);
            Retos cuatro = new Retos("Los jugadores que hayan sido infieles deben tomar un sorbo por cada pareja engañada", 1);
            todo.CantidadRetos.Add(cuatro);
            Retos cinco = new Retos("Todos los jugadores que usen lentes deben tomar.", 1);
            todo.CantidadRetos.Add(cinco);
            Retos seis = new Retos("Puedes agregar, modificar o eliminar una Regla", 1);
            todo.CantidadRetos.Add(seis);
            Retos siete = new Retos("El jugador debe darle un beso no importa donde a un jugador de su eleccion, y regalarle los sorbos.", 8);
            todo.CantidadRetos.Add(siete);
            Retos ocho = new Retos("Los jugadores que esten en una especie de relacion deben tomar.", 3);
            todo.CantidadRetos.Add(ocho);
            Retos nueve = new Retos("El jugador actual debe jugar una pulseada con un jugador de su eleccion, si pierde debe tomar el doble.", 3);
            todo.CantidadRetos.Add(nueve);
            Retos diez = new Retos("El jugador actual puede hacerle 3 preguntas a otro jugador, las cuales debe responder con total sinceridad, por cada pregunta es un sorbo.", 1);
            todo.CantidadRetos.Add(diez);
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
