using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Tomanji_trucho
{
    public partial class Inicio:Form
    {
      
        public Inicio()
        {
            InitializeComponent();
        }

      
        private void AgregarJug(object sender, EventArgs e)
        {
            this.Hide();
            IngresoJugador ingreso = new IngresoJugador();
            ingreso.Show();
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.White;
            btnCerrar.BackColor = Color.FromArgb(195, 35, 35);
           
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.FromArgb(239, 156, 0);
            btnCerrar.BackColor = Color.FromArgb(63,63,63);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
