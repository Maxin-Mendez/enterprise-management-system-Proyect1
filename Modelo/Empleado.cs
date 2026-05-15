using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.cs
{
    public class Empleado
    {
        string Nombre, NInss, cargo;
        int  CantExtras, antiguedad;
        double salario;

        public Empleado() {
            Nombre = string.Empty;
            NInss = string.Empty;
            cargo = string.Empty;
            cantExtras = 0;
            antiguedad = 0;
            salario = 0;
        }
        public Empleado(string nombre, string nInss, string cargo, double salario, int cantExtras, int antiguedad)
        {
            Nombre = nombre;
            NInss = nInss;
            this.cargo = cargo;
            this.salario = salario;
            this.cantExtras = cantExtras;
            this.antiguedad = antiguedad;
        }

       
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string NInss1 { get => NInss; set => NInss = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario { get => salario; set => salario = value; }
        public int cantExtras { get => CantExtras; set => CantExtras = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
    }
}