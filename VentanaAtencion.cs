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
    public partial class VentanaAtencion : Form
    {
        public VentanaAtencion()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Ocultar la ventana en lugar de cerrarla cuando se hace clic en el botón de minimizar
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventana2 Vent_Principal = new Ventana2();
            Vent_Principal.Show();
            this.Close();
        }
    }
}
