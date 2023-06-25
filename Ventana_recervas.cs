using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clínica_Varifarmas
{
    public partial class Ventana_recervas : Form
    {
        public Ventana_recervas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Ventana2 Vent_Principal = new Ventana2();
            Vent_Principal.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cambiar el estado de la ventana al hacer clic en el botón de maximizar
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ocultar la ventana en lugar de cerrarla cuando se hace clic en el botón de minimizar
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }
    }
}
