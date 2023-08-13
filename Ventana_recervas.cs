using FirebaseAdmin;
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
using Firebase.Database;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Web.UI.WebControls;

namespace clínica_Varifarmas
{
    public partial class Ventana_recervas : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "hcenu1vpO3LdY9fwGa71v2WweWsvuT7f5E89hACc",
            BasePath = "https://varifarma-proyect-default-rtdb.firebaseio.com/",
        };

        IFirebaseClient client;

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

        private void Ventana_recervas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button5_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("Information/");
            Dictionary<string, Data> result = response.ResultAs<Dictionary<string, Data>>();

            /*
                  if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                result = JsonConvert.DeserializeObject<Dictionary<string, Data>>(response.Body);


                List<Data> listaContacto = new List<Data>();

                foreach (KeyValuePair<string, Data> elemento in result)
                {
                    listaContacto.Add(
                        new Data()
                        {

                            Id = elemento.Key,
                            name = elemento.Value.name,
                            apellido = elemento.Value.apellido,
                            email = elemento.Value.email,
                            sex = elemento.Value.sex,
                            telf = elemento.Value.telf

                        });
                   
                }
                  

            }
             
       
             */
        }

    }
}
