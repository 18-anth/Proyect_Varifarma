﻿using FireSharp.Config;
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
using static Google.Apis.Requests.BatchRequest;

namespace clínica_Varifarmas
{

    public partial class Ventana2 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "hcenu1vpO3LdY9fwGa71v2WweWsvuT7f5E89hACc",
            BasePath = "https://varifarma-proyect-default-rtdb.firebaseio.com",
        };

        IFirebaseClient client;

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
            REGISTRO_PACIENTE registro = new REGISTRO_PACIENTE();   
            registro.Show();
            this.Close();
        }

        private async void inicioDeSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data data = new Data();

            FirebaseResponse resp2 = await client.GetAsync("Information/");
            Data obj2 = resp2.ResultAs<Data>();

            if (string.IsNullOrEmpty(obj2.getId()))
            {

                MessageBox.Show("Usted ya inicio sesión" + obj2.getId());
            }
            else
            {
                MessageBox.Show("Usuario no inicio sesión");
                Ventana1 inicio = new Ventana1();
                inicio.Show();
                this.Close();
                this.Hide();
            }

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

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterAdmin admin = new RegisterAdmin();  
            admin.Show();   
            this.Close();   
        }

        private void panelAdministraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana_Administracion adm = new Ventana_Administracion();
            adm.Show();
            this.Close();
        }

        private void nosostrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nosotros nos = new Nosotros();
            nos.Show(); 
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                Console.Write("Connection is Estable");
            }
        }
    }
}
