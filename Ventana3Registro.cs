using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response; 

namespace clínica_Varifarmas
{
    public partial class Ventana3Registro : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "hcenu1vpO3LdY9fwGa71v2WweWsvuT7f5E89hACc",
            BasePath = "https://varifarma-proyect-default-rtdb.firebaseio.com/",
        };

        IFirebaseClient client;

        public Ventana3Registro()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                Console.Write("Connection is Estable");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Cancelo el registro exitosamente!");
            Ventana1 InicioLogin = new Ventana1();
            InicioLogin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

            SetResponse response = await client.SetTaskAsync("Users/"+textBox1.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Se agregaron los Datos del Usuario: " + result.Id);
            Ventana1 InicioLogin = new Ventana1();
            InicioLogin.Show();
            this.Hide();

        }

        private void Ventana3Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
