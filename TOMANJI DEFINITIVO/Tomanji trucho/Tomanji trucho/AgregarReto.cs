using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Tomanji_trucho
{
    public partial class AgregarReto : Form
    {

        

        public AgregarReto()
        {
            InitializeComponent();
        }
        int contador = 1;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (todo.ContieneNums(textBox2.Text))
            {
                todo.CantidadRetos.Add(new Retos(textBox1.Text, Convert.ToInt32(textBox2.Text)));


                todo.pan.label7.Text = Convert.ToString(todo.CantidadRetos.Count);


                contador++;
                todo.mensaje += Environment.NewLine + ("Retos A" + Convert.ToString(contador) + "= New Retos(" + quote + textBox1.Text + quote + "," + textBox2.Text + ");") + Environment.NewLine +
                    "todo.CantidadRetos.Add(A" + Convert.ToString(contador) + ");";
                textBox1.Clear();
                textBox2.Clear();

            }
            else
            {
                MessageBox.Show("desde cuando los puntos tienen letras..");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            todo.pan.Show();
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        const string quote = "\"";

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter escrito = new StreamWriter(todo.ruta + "\\tomanji.txt");
            try
            {
                escrito.WriteLine(todo.mensaje);
                escrito.Flush();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                escrito.Close();
            }
           
        }

        
    }
}
