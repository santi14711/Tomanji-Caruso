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
    public partial class AgregarReto : Form
    {
        public AgregarReto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            todo.CantidadRetos.Add(new Retos(textBox1.Text, Convert.ToInt32(textBox2.Text)));
            textBox1.Text = "";
            textBox2.Text = "";
            //this.Hide();
            //PantalladeJuego pan = new PantalladeJuego();
            //pan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantalladeJuego pan = new PantalladeJuego();
            pan.Show();
        }
    }
}
