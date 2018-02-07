using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tomanji_trucho
{
   
    public partial class IngresoJugador : Form
    {
        
        public IngresoJugador()
        {
            InitializeComponent();
        }

    
        string name;
        bool repetido = false;

        private void IngresodeJugadores(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                
                if (string.IsNullOrWhiteSpace(textBox1.Text))

                {
                    MessageBox.Show("Ingresa un nombre, los espacios no son nombres...","Error de idiota",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    textBox1.Clear();
                    
                }
                else if (todo.ContieneNums(textBox1.Text))
                {
                    MessageBox.Show("Como tu nombre va a tener números...", "Complejo de eleven", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Clear();
                }

                else
                {
                    name = textBox1.Text;
                    foreach (var item in todo.nombresjugadores)
                    {
                        if (item.Nombre == name)
                        {
                            repetido = true;
                        }
                    }
                    if (repetido == false)
                    {
                        todo.nombresjugadores.Add(new Jugadores(textBox1.Text));
                        textBox1.Clear();
                        label1.Text = Convert.ToString((int)todo.nombresjugadores.Count);
                        
                    }
                    else
                    {
                        MessageBox.Show("No se pueden llamar igual, si no como los diferencias...", "Show me da waeeeeeeeee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBox1.Clear();
                        repetido = false;
                    }
                    
                }
            }
        }
    
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
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
                todo.pan.Show();
            }
            else
            {
                MessageBox.Show("Tenes que ingresar al menos 2 personas, ¿o pensas jugar solo?","Forever alone :'v", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    
        }
    }
}
