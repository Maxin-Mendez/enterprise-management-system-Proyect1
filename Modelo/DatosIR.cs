using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.cs
{
    public  class PlanillaTrabajadores
    {
        string INSS, nombre, cargo;
        double SalarioMensual, BonoAntiguedad, HorasExtras, TotalIngresos, insslaboral, IR, TotalDeducciones, NetoRecibir;

        public PlanillaTrabajadores(string iNSS, string nombre, string cargo, double salarioMensual, double bonoAntiguedad, double horasExtras, double totalIngresos, double insslaboral, double iR, double totalDeducciones, double netoRecibir)
        {
            INSS = iNSS;
            this.nombre = nombre;
            this.cargo = cargo;
            SalarioMensual = salarioMensual;
            BonoAntiguedad = bonoAntiguedad;
            HorasExtras = horasExtras;
            TotalIngresos = totalIngresos;
            this.insslaboral = insslaboral;
            IR = iR;
            TotalDeducciones = totalDeducciones;
            NetoRecibir = netoRecibir;
        }

        public string Numero_Inss { get => INSS; set => INSS = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double Salario_Mensual{ get => SalarioMensual; set => SalarioMensual = value; }
        public double Antiguedad { get => BonoAntiguedad; set => BonoAntiguedad = value; }
        public double Horas_Extras { get => HorasExtras; set => HorasExtras = value; }
        public double Total_Ingresos { get => TotalIngresos; set => TotalIngresos = value; }
        public double Inss_Laboral { get => insslaboral; set => insslaboral = value; }
        public double IR_{ get => IR; set => IR = value; }
        public double Total_Deducciones { get => TotalDeducciones; set => TotalDeducciones = value; }
        public double Neto_Recibir { get => NetoRecibir; set => NetoRecibir = value; }
    }
}
