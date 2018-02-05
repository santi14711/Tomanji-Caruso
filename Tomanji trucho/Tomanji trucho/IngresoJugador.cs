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
   
    public partial class IngresoJugador : Form
    {
        
        public IngresoJugador()
        {
            InitializeComponent();
        }

        private void IngresodeJugadores(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    todo.nombresjugadores.Add(new Jugadores(textBox1.Text));
                    textBox1.Clear();
                    label1.Text = Convert.ToString((int)todo.nombresjugadores.Count);

                }
                else
                {
                    MessageBox.Show("Debe de ingresar un nombre");
                }
            }
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            if (todo.nombresjugadores.Count != 0 && todo.nombresjugadores.Count != 1) {
                 
            this.Hide();
            PantalladeJuego ingreso = new PantalladeJuego();
            ingreso.Show();
            }
            else
            {
                MessageBox.Show("Debe de ingresar al menos dos personas");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.White;
            btnCerrar.BackColor = Color.FromArgb(195, 35, 35);

        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.FromArgb(239, 156, 0);
            btnCerrar.BackColor = Color.FromArgb(63, 63, 63);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (todo.nombresjugadores.Count != 0 && todo.nombresjugadores.Count != 1)
            {

                this.Hide();
                PantalladeJuego ingreso = new PantalladeJuego();
                ingreso.Show();
            }
            else
            {
                MessageBox.Show("Debe de ingresar al menos dos personas.");
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    
        }
    }
}
