using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clínica_Varifarmas
{
    internal class Data
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string sex { get; set; }
        public string edad { get; set; }
        public string telf { get; set; }

        public string password { get; set; }

        public string direction { get; set; }



        public string getId() { return Id; }
        public string getname() { return name; }
        public string getapellido() { return apellido; }
        public string getemail() { return email; }
        public string getsex() { return sex; }
        public string getedad() { return edad; }
        public string gettelf() { return telf; }
        public string getdirection() { return direction; }

        public void setId(string Id) { this.Id = Id; }
        public void setname(string name) {this.name = name; }
        public void setapellido(string apellido) { this.apellido = apellido; }
        public void setemail(string email) { this.email = email; }
        public void setsex(string sex) { this.sex = sex; }
        public void setedad(string edad) { this.edad = edad; }
        public void settelf(string telf) {this.telf = telf; }
        public void setdirection(string direction) { this.direction =  direction; }

    }
}
