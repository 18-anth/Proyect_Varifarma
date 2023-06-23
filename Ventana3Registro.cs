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

namespace clínica_Varifarmas
{
    public partial class Ventana3Registro : Form
    {
        public Ventana3Registro()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = textBox1.Text;
            string name = textBox2.Text;
            string apellido = textBox3.Text;
            string email = textBox4.Text;
            string sex = textBox5.Text;
            string edad = textBox6.Text;
            string telf = textBox7.Text;
            string direction = textBox8.Text;

     

            using (StreamWriter sw = new StreamWriter("database.json"))
            {
                 
                sw.WriteLine(dni, name, apellido, email, sex, edad, telf, direction);

                File.WriteAllText("database.txt", dni);
            }
            MessageBox.Show("Se Registro Exitosamente!");
        }
    }
}
