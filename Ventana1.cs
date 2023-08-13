using System;
using System.Windows.Forms;
using Firebase.Auth;
using FireSharp.Config;
using FireSharp.Interfaces;
using FirebaseAdmin.Auth;
using FireSharp.Response;
using System.Collections.Generic;
using System.Web.Configuration;

namespace clínica_Varifarmas
{
    public partial class Ventana1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig {
            AuthSecret = "hcenu1vpO3LdY9fwGa71v2WweWsvuT7f5E89hACc",
            BasePath = "https://varifarma-proyect-default-rtdb.firebaseio.com/",
        };

        IFirebaseClient client;

        public Ventana1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
             this.Hide();
            this.Close();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // FUNCION DE CHECKEDBOX
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                // El CheckBox está marcado
                MessageBox.Show("Se recordara el usuario la proxima vez.");
            }
            else
            {
                // El CheckBox no está marcado
                MessageBox.Show("No selecciono esta opción.");
            }

        }

        // BUTTON DE INICIO DE SESION

        public static string Idrresultpass;

        private void button2_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("Users/");
                Dictionary<string, Data> result = response.ResultAs<Dictionary<string, Data>>();


            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Usuario o contraseña incorrectos: " + textBox1 + " , " + textBox2);
            }
            else {
                
                
                foreach (var get in result)
                {
                    string Idrresult = get.Value.Id;
                    string passrresult = get.Value.password;


                    if (textBox1.Text == Idrresult)
                    {
                        if (textBox2.Text == passrresult)
                        {
                            MessageBox.Show("Inicio de sesión exitoso, Bienvenido usuario: " + textBox1.Text);

                            Idrresultpass = textBox1.Text;
                            Ventana2 Principal = new Ventana2();
                            Principal.Show();
                            this.Hide();
                        }
                         if (textBox2.Text != passrresult)
                        {
                            MessageBox.Show("Por favor ingresa la contraseña correcta: " + textBox2.Text);

                            if (textBox1.Text != Idrresult)
                            {
                                MessageBox.Show("Por favor ingresa el ID correcto: " + textBox1.Text);
                            }
                            else if(textBox1.Text != Idrresult || textBox2.Text != passrresult)
                            {

                                MessageBox.Show("Usuario o contraseña incorrectos: " + textBox1.Text + ", "+ textBox2.Text);
                            }
                        }
                        
                    }
                   
                     

                }
                

            }




            /*
                          
            string Id = textBox1.Text;
            string password = textBox2.Text;


              if (Id == "admin" && password == "admin")
             {


                 // Las credenciales son válidas, realizar acciones de inicio de sesión
                 MessageBox.Show("Inicio de sesión exitoso.");
                 Ventana2 Principal = new Ventana2();
                 Principal.Show();
                 this.Hide();
             }else if(Id != "admin") {

                 MessageBox.Show("Por favor ingresa el Usuario");

             }
             else if (password != "admin")
             {
                 MessageBox.Show("Por favor ingresa la contraseña");
             }
             else
             {
                 // Las credenciales no son válidas, mostrar mensaje de error
                 MessageBox.Show("Usuario o contraseña incorrectos");
             }



             */

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
               Console.Write("Connection is Estable");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
        
    }
}
