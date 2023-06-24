using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace clínica_Varifarmas
{
    public partial class Ventana1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig { 
            AuthSecret= "hcenu1vpO3LdY9fwGa71v2WweWsvuT7f5E89hACc",
            BasePath = "https://varifarma-proyect-default-rtdb.firebaseio.com/",
        };

        IFirebaseClient client;

        public Ventana1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           this.Close();
           this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           

              

            if (checkBox1.Checked)
            {
                // El CheckBox está marcado
                MessageBox.Show("El CheckBox está marcado.");
            }
            else
            {
                // El CheckBox no está marcado
                MessageBox.Show("El CheckBox no está marcado.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string usuario, contraseña;
            usuario = textBox1.Text;
            contraseña = textBox2.Text;

            
            if (usuario == "admin" && contraseña == "admin")
            {
                // Las credenciales son válidas, realizar acciones de inicio de sesión
                MessageBox.Show("Inicio de sesión exitoso.");
                Ventana2 Principal = new Ventana2();
                Principal.Show();
                this.Hide();
            }else if(usuario != "admin") {

                MessageBox.Show("Por favor ingresa el Usuario");
            }
            else if (contraseña != "admin")
            {
                MessageBox.Show("Por favor ingresa la contraseña");
            }
            else
            {
                // Las credenciales no son válidas, mostrar mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

             

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client!= null)
            {
               Console.Write("Connection is Estable");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventana3Registro Registro = new Ventana3Registro();
            Registro.Show();
            this.Hide ();
        }
    }
}
