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
            Retos B1= new Retos("El jugador actual debe tomar", 1);
            todo.CantidadRetos.Add(B1);
            Retos B2 = new Retos("Todos toman.", 1);
            todo.CantidadRetos.Add(B2);
            Retos A2 = new Retos("El jugador sentado a la izquierda del jugador actual debe tomar.", 2);
            todo.CantidadRetos.Add(A2);
            Retos A3 = new Retos("El jugador actual debe tomar.", 5);
            todo.CantidadRetos.Add(A3);
            Retos A4 = new Retos("Los jugadores deben construir en conjunto una linda historia agregando una palabra hacia la derecha, el que falle toma.", 1);
            todo.CantidadRetos.Add(A4);
            Retos A5 = new Retos("Todos los que estudien o hayan estudiado humanidades deben tomar.", 1);
            todo.CantidadRetos.Add(A5);
            Retos A6 = new Retos("Todos los que hayan estudiado algo relacionado con la salud deben tomar.", 2);
            todo.CantidadRetos.Add(A6);
            Retos A7 = new Retos("El jugador debe tomar un vaso al seco, todo de una vez.", 8);
            todo.CantidadRetos.Add(A7);
            Retos A8 = new Retos("Nadie puede decir si ni no uno por cada error.", 1);
            todo.CantidadRetos.Add(A8);
            Retos A9 = new Retos("El jugador que reciba el regalo debe tomar.", 5);
            todo.CantidadRetos.Add(A9);
            Retos A10 = new Retos("El jugador de menor estatura debe tomar.", 2);
            todo.CantidadRetos.Add(A10);
            Retos A11 = new Retos("Para cada jugador por cada E que tenga en su nombre debe tomar.", 2);
            todo.CantidadRetos.Add(A11);
            Retos A12 = new Retos("El o los jugadores dueños de la casa deben tomar.", 1);
            todo.CantidadRetos.Add(A12);
            Retos A13 = new Retos("Todos los forever alone deben tomar.", 2);
            todo.CantidadRetos.Add(A13);
            Retos A14 = new Retos("El jugador de mayor edad debe tomar.", 2);
            todo.CantidadRetos.Add(A14);
            Retos A15 = new Retos("El jugador tiene la facultad de inflar las mejillas cuando desee,  todos deben imitarlo, el ultimo debe tomar.", 3);
            todo.CantidadRetos.Add(A15);
            Retos A16 = new Retos("Todas las jugadoras deben tomar.", 2);
            todo.CantidadRetos.Add(A16);
            Retos A17 = new Retos("El jugador debe recitar un trabalenguas a eleccion, en caso de equivocarse debe tomar.", 2);
            todo.CantidadRetos.Add(A17);
            Retos A18 = new Retos("Todos los jugadores excepto el actual deben tomar.", 2);
            todo.CantidadRetos.Add(A18);
            Retos A19 = new Retos("Todos deben poner sus llaves en su mesa, cada uno debe tomar la cantidad de llaves que posee.", 1);
            todo.CantidadRetos.Add(A19);
            Retos A20 = new Retos("Todos los jugadores que tengan hermano deben tomar.", 2);
            todo.CantidadRetos.Add(A20);
            Retos A21 = new Retos("El jugador actual debe tomar.", 2);
            todo.CantidadRetos.Add(A21);
            Retos A22 = new Retos("Puedes agregar una regla.", 3);
            todo.CantidadRetos.Add(A22);
            Retos A23 = new Retos("Puedes eliminar una regla.", 3);
            todo.CantidadRetos.Add(A23);
            Retos A24 = new Retos("Puedes modificar una regla.", 3);
            todo.CantidadRetos.Add(A24);
            Retos A25 = new Retos("Puedes agregar, eliminar o modificar una regla.", 2);
            todo.CantidadRetos.Add(A25);
            Retos A26 = new Retos("Puedes modificar agregar o eliminar una Regla.", 3);
            todo.CantidadRetos.Add(A26);
            Retos A27 = new Retos("Todos los que fuman deben tomar.", 3);
            todo.CantidadRetos.Add(A27);
            Retos A28 = new Retos("El mas flaco debe tomar.", 2);
            todo.CantidadRetos.Add(A28);
            Retos A29 = new Retos("Todos los que esten en una relacion deben tomar.", 2);
            todo.CantidadRetos.Add(A29);
            Retos A30 = new Retos("El jugador debe retar a otro jugador a hacer algo. Si el otro lo hace, este debe tomar.", 3);
            todo.CantidadRetos.Add(A30);
            Retos A31 = new Retos("El jugador sentado a la derecha del jugador actual debe tomar.", 3);
            todo.CantidadRetos.Add(A31);
            Retos A32 = new Retos("El jugador debe realizar 10 abdominales y tomar.", 5);
            todo.CantidadRetos.Add(A32);
            Retos A33 = new Retos("Cantar la macarena y tomar.", 3);
            todo.CantidadRetos.Add(A33);
            Retos A34 = new Retos("El jugador tiene la facultad de iniciar un yo nunca nunca.", 3);
            todo.CantidadRetos.Add(A34);
            Retos A35 = new Retos("Nadie puede decir que toca.", 1);
            todo.CantidadRetos.Add(A35);
            Retos A36 = new Retos("El jugador debe permanecer callado durante todo el turno. De lo contrario debe tmar.", 3);
            todo.CantidadRetos.Add(A36);
            Retos A37 = new Retos("Nombres de paises Africanos.", 3);
            todo.CantidadRetos.Add(A37);
            Retos A38 = new Retos("Nombres de paises Americanos.", 4);
            todo.CantidadRetos.Add(A38);
            Retos A39 = new Retos("Nombres de series viejas.", 2);
            todo.CantidadRetos.Add(A39);
            Retos A40 = new Retos("Nombres de juegos viejos.", 3);
            todo.CantidadRetos.Add(A40);
            Retos E2 = new Retos("Numeros romanos PALO PALO PALO y asi, el primero en equivocarse toma.", 3);
            todo.CantidadRetos.Add(E2);
            Retos E3 = new Retos("Habilidad especial, ESPEJO, el jugador tiene la facultad de devolver un ataque.", 3);
            todo.CantidadRetos.Add(E3);
            Retos E4 = new Retos("Habilidad ESPEJO", 3);
            todo.CantidadRetos.Add(E4);
            Retos E5 = new Retos("Habilidad ESPEJO", 3);
            todo.CantidadRetos.Add(E5);
            Retos E6 = new Retos("Habilidad especial +4, Jugador actual puede hacer que otro jugador tome  4 sorbos mas.", 4);
            todo.CantidadRetos.Add(E6);
            Retos E7 = new Retos("Habilidad especial +2", 2);
            todo.CantidadRetos.Add(E7);
            Retos E8 = new Retos("Habilidad especial +3",2 );
            todo.CantidadRetos.Add(E8);
            Retos E9 = new Retos("Habilidad especial -3.", 3);
            todo.CantidadRetos.Add(E9);
            Retos E10 = new Retos("Habilidad especial -5", 2);
            todo.CantidadRetos.Add(E10);
            Retos E11 = new Retos("Habilidad Reflejo Magico, el jugador puede elegir a otra persona para que esa persona regale los sorbos.", 8);
            todo.CantidadRetos.Add(E11);
            Retos E12 = new Retos("Piedra papel o tijera entre todos.", 8);
            todo.CantidadRetos.Add(E12);
            Retos E13 = new Retos("El jugador actual piensa un numero del 1 a la cantidad de jugadores presentes, el que lo adivine toma.", 4);
            todo.CantidadRetos.Add(E13);
            Retos E14 = new Retos("El jugador actual debe tararear una cancion, el que la adivine puede regalar sorbos a otros menos al actual.", 3);
            todo.CantidadRetos.Add(E14);
            Retos E15 = new Retos("Animales con la letra B.", 3);
            todo.CantidadRetos.Add(E15);
            Retos E16 = new Retos("Animales invertebrados.", 5);
            todo.CantidadRetos.Add(E16);
            Retos E17 = new Retos("Animales extintos.", 2);
            todo.CantidadRetos.Add(E17);
            Retos E18 = new Retos("Dioses griegos.", 3);
            todo.CantidadRetos.Add(E18);
            Retos E19 = new Retos("Criaturas mitologicas.", 2);
            todo.CantidadRetos.Add(E19);
            Retos E20 = new Retos("El jugador puede hacer el circulo con el dedo. El que lo mire, toma.", 2);
            todo.CantidadRetos.Add(E20);




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

