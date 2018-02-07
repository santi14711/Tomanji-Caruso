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
        
        string jugactual;
        int cantidadjugadores;
        private void PantalladeJuego_Load(object sender, EventArgs e)
        {
            cantidadjugadores = todo.nombresjugadores.Count;

            Retos uno = new Retos("El jugador actual debe cantar libre soy en voz alta por 10 segundos y luego tomar.", 2);
            todo.CantidadRetos.Add(uno);
            Retos dos = new Retos("Noubady misi clan misi down, de que cancion es esta letra?. Tiene un intento para adivinar.", 5);
            todo.CantidadRetos.Add(dos);

            NumeroJugador = todo.TurnoJug.Next(0, cantidadjugadores);
            label2.Text = Convert.ToString(todo.nombresjugadores[NumeroJugador].Nombre);
            jugactual = Convert.ToString(todo.nombresjugadores[NumeroJugador].Nombre);


            label3.Text = Convert.ToString(todo.CantidadRetos[0].Reto);
            label4.Text = "" + Convert.ToString(todo.CantidadRetos[0].Puntos) + "";
            label7.Text = Convert.ToString(todo.CantidadRetos.Count);
            todo.retoactual++;

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

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    button2.Enabled = false;
        //    button3.Enabled = false;

        //    todo.nombresjugadores[NumeroJugador].Puntos += todo.CantidadRetos[randomretos].Puntos;
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    button3.Enabled = false;
        //    button2.Enabled = false;

        //    todo.nombresjugadores[NumeroJugador].Puntos -= todo.CantidadRetos[randomretos].Puntos;
        //}

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

            if (todo.retoactual >= todo.CantidadRetos.Count)
            {
                MessageBox.Show("no mas retos bro");
            }

            else
            {
                label3.Text = Convert.ToString(todo.CantidadRetos[todo.retoactual].Reto);
                label4.Text = Convert.ToString(todo.CantidadRetos[todo.retoactual].Puntos);
                label7.Text = Convert.ToString(todo.CantidadRetos.Count - todo.retoactual);
                todo.retoactual++;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (todo.retoactual >= todo.CantidadRetos.Count)
            {
                MessageBox.Show("No hay nada para eliminar");
            }
            else
            {
                todo.CantidadRetos.RemoveAt(todo.retoactual);
                todo.retoactual--;
                RetoAleatorio();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }



}

