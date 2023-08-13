using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Windows.Forms;
using Firebase.Auth; 
using FirebaseAdmin.Auth; 
using System.Collections.Generic;
using System.Web.Configuration;
using System; 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace clínica_Varifarmas
{
    public partial class VentanaAtencion : Form
    {
        DataTable dt = new DataTable();


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "hcenu1vpO3LdY9fwGa71v2WweWsvuT7f5E89hACc",
            BasePath = "https://varifarma-proyect-default-rtdb.firebaseio.com/",
        };

        IFirebaseClient client;


        public VentanaAtencion()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);

            if (client != null )
            {
                dt.Columns.Add("DNI");
                dt.Columns.Add("APELLIDO");
                dt.Columns.Add("DIRECCIÓN");
                dt.Columns.Add("EDAD");
                dt.Columns.Add("EMAIL");
                dt.Columns.Add("NOMBRE");
                dt.Columns.Add("SEXO");
                dt.Columns.Add("TELEFONO");
                dataGridView1.DataSource = dt;
                dataGridView1_CellContentClick();
            }
        }

        private async void dataGridView1_CellContentClick()
        {
            bool validate = true;

            dt.Rows.Clear();
            int i = 0;

            while (validate == true)
            {
                i++;
                try
                {
                    FirebaseResponse resp2 = await client.GetAsync("Information/" + i);
                    Data obj2 = resp2.ResultAs<Data>();

                    if (obj2 == null)
                    {
                        validate = false;
                    }
                    else
                    {
                        DataRow row = dt.NewRow();

                        row["Id"] = obj2.Id;
                        row["apellido"] = obj2.apellido;
                        row["direction"] = obj2.direction;
                        row["edad"] = obj2.edad;
                        row["email"] = obj2.email;
                        row["name"] = obj2.name;
                        row["sex"] = obj2.sex;
                        row["telf"] = obj2.telf;
                        dt.Rows.Add(row);
                    }
                }
                catch (Exception ex)
                {

                }
            }
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

        private async void button1_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("DNI O Usuario incorrectos: " + textBox1);
            }
            else
            {
                 

                MessageBox.Show("DNI O Usuario Correcto, Se procede a mostrar sus datos: " + textBox1.Text);


            }

        }
        
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                Console.Write("Connection is Estable");
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        
     
    }
}
