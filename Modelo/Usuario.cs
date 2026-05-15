using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.cs
{
    public class Usuario
    {
        private string direccion, name, correo, NumT, cargo;

        public Usuario() {

            direccion = string.Empty;
            name = string.Empty;
            correo = string.Empty;
            NumT = String.Empty;
            cargo = String.Empty;
        
        }
        public Usuario(string Direccion, string name, string correo, string NumT, string cargo)
        {
            direccion = Direccion;
            this.name = name;
            this.correo = correo;
            this.NumT = NumT;
            this.cargo = cargo;

        }

        public string Direccion { get => direccion; set => direccion = value; }
        public string Nombre { get => name; set => name = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => NumT; set => NumT = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}
