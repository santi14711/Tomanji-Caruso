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
    public partial class Puntajes : Form
    {
        public Puntajes()
        {
            InitializeComponent();
        }

        private void Puntajes_Load(object sender, EventArgs e)
        {
           
            foreach (var item in todo.nombresjugadores)
            {
                int index = 0;
                listBox1.Items.Insert(index,item.Puntos+" puntos "+item.Nombre);
            
          
                index++;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            todo.PantallaJuego.Show();
        }
    }
}
