using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class REGISTRO_PACIENTE : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "hcenu1vpO3LdY9fwGa71v2WweWsvuT7f5E89hACc",
            BasePath = "https://varifarma-proyect-default-rtdb.firebaseio.com",
        };

        IFirebaseClient client;

        public REGISTRO_PACIENTE()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = textBox1.Text,
                name = textBox2.Text,
                apellido = textBox3.Text,
                email = textBox4.Text,
                sex = textBox5.Text,
                edad = textBox6.Text,
                telf = textBox7.Text,
                direction = textBox8.Text
            };

            SetResponse response = await client.SetAsync("Paciente/" + textBox1.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Se agregaron los datos del Usuario: " + result.Id);

            Ventana1 InicioLogin = new Ventana1();
            InicioLogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Cancelo el registro exitosamente!");
            Ventana2 VentanaPrincipal = new Ventana2();
            VentanaPrincipal.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                Console.Write("Connection is Estable");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventana2 Vent_Principal = new Ventana2();
            Vent_Principal.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Ocultar la ventana en lugar de cerrarla cuando se hace clic en el botón de minimizar
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }
    }
}
