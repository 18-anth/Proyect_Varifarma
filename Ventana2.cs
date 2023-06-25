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
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana1 sesion = new Ventana1();
            sesion.Show();
            this.Close();
        }

        private void Ventana2_Load(object sender, EventArgs e)
        {

        }

        private void recervarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_recervas reserva = new Ventana_recervas();
            reserva.Show();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Ocultar la ventana en lugar de cerrarla cuando se hace clic en el botón de minimizar
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }

        private void button10_Click(object sender, EventArgs e)
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

        private void registrarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana3Registro registro = new Ventana3Registro(); 
            registro.Show();
            this.Close();
        }

        private void inicioDeSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana1 inicio = new Ventana1();
            inicio.Show();
            this.Close();
        }

        private void horarioMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atenciónCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaAtencion atencion = new VentanaAtencion();
            atencion.Show();
            this.Close();
        }
    }
}
