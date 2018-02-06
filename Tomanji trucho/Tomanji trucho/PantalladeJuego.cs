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
        int NumeroJugador;
        int randomretos;
        string retoactual;
        string jugactual;
        int cantidadjugadores;
        private void PantalladeJuego_Load(object sender, EventArgs e)
        {
            cantidadjugadores = todo.nombresjugadores.Count;

            Retos uno = new Retos("El jugador de mayor edad debe tomar", 2);
            todo.CantidadRetos.Add(uno);
            Retos dos = new Retos("Puedes agregar, modificar o eliminar una Regla", 5);
            todo.CantidadRetos.Add(dos);
            Retos fas = new Retos("El jugador actual debe cantar libre soy en voz alta por 10 segundos y luego tomar.", 2);
            todo.CantidadRetos.Add(fas);
            Retos UM = new Retos("Noubady misi clan misi down, de que cancion es esta letra?. Tiene un intento para adivinar.", 5);
            todo.CantidadRetos.Add(UM);
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


            NumeroJugador = todo.TurnoJug.Next(0, cantidadjugadores);
            label2.Text = Convert.ToString(todo.nombresjugadores[NumeroJugador].Nombre);
            jugactual = Convert.ToString(todo.nombresjugadores[NumeroJugador].Nombre);


            randomretos = todo.TurnoJug.Next(0, todo.CantidadRetos.Count);
            label3.Text = Convert.ToString(todo.CantidadRetos[randomretos].Reto);
            label4.Text = "" + Convert.ToString(todo.CantidadRetos[randomretos].Puntos) + "";
            retoactual = Convert.ToString(todo.CantidadRetos[randomretos].Reto);

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
          //  button2.Enabled = true;
           // button3.Enabled = true;

            PersonaAleatorio();
            RetoAleatorio();
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

            todo.nombresjugadores[NumeroJugador].Puntos += todo.CantidadRetos[randomretos].Puntos;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = false;

            todo.nombresjugadores[NumeroJugador].Puntos -= todo.CantidadRetos[randomretos].Puntos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            todo.PantallaJuego.Hide();

            Puntajes punt = new Puntajes();
            punt.Show();
        }

        #region "al pedo"
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
#endregion

        private void PersonaAleatorio()
        {
            NumeroJugador = todo.TurnoJug.Next(0, cantidadjugadores);

            if (jugactual!= Convert.ToString(todo.nombresjugadores[NumeroJugador].Nombre)) { 
            
            label2.Text = Convert.ToString(todo.nombresjugadores[NumeroJugador].Nombre);
                jugactual = Convert.ToString(todo.nombresjugadores[NumeroJugador].Nombre);
            }
            else
            {
                PersonaAleatorio();
            }
        }
        private void RetoAleatorio()
        {
            randomretos = todo.TurnoJug.Next(0, todo.CantidadRetos.Count);
            if (retoactual != Convert.ToString(todo.CantidadRetos[randomretos].Reto)) { 
            
            label3.Text = Convert.ToString(todo.CantidadRetos[randomretos].Reto);
            label4.Text = "" + Convert.ToString(todo.CantidadRetos[randomretos].Puntos) + "";
                retoactual= label3.Text = Convert.ToString(todo.CantidadRetos[randomretos].Reto);
            }
            else
            {
                RetoAleatorio();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            todo.CantidadRetos.RemoveAt(randomretos);
            RetoAleatorio();
        }

    }



}

