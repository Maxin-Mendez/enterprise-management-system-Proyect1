using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Modelo.cs
{
    public class NominaTrabajadores : Empleado
    {

        double Tdeducciones, NetoRecibir,totalIN;
        double horasExtras;
        double InssL, IR, Tantiguedad, porcentaje;
        
        public NominaTrabajadores() {
            Tdeducciones = 0;
            NetoRecibir = 0;
            horasExtras = 0;
            InssL = 0;
            IR = 0;
        }
        public NominaTrabajadores(double totalIN,double Tantiguedad, string nombre, string nInss, string cargo, double salario, int cantExtras, int cantantiguedad, double horasEx0tras, double Tdeducciones, double NetoRecibir, double insl, double IR)
        : base( nombre, nInss, cargo, salario,  cantExtras,  cantantiguedad)
        {
            this.horasExtras = horasEx0tras;
            this.Tdeducciones = Tdeducciones;
            this.NetoRecibir = NetoRecibir;
            this.InssL = insl;
            this.IR = IR;
            this.Tantiguedad = Tantiguedad;
            this.totalIN = totalIN;
        }

        public double Porcentaje { get => porcentaje; set => porcentaje = value; }

        public double CalcularAntiguedad() {

            Tantiguedad = Salario * Porcentaje;

            return Tantiguedad;

        }

        public double HorasExtras() {

            horasExtras =( (Salario / 30) / 8)* cantExtras;

            return horasExtras;
        }

        public double TotalIngresos() {

            totalIN = Salario + HorasExtras() + CalcularAntiguedad();
            return totalIN;
        }

        public double Innslaboral() {

            InssL = Salario * 0.07;

            return InssL;
        }

        private double SalarioAnualIR() {
            double SalarioA = 0;
            SalarioA = (Salario - Innslaboral())*12;
            return SalarioA;   
        }
        public double CalcularIR() {
                if (SalarioAnualIR() > 0 && SalarioAnualIR() <= 100000)
                {
                  IR = 0;

                }
                if (SalarioAnualIR() >= 100001 && SalarioAnualIR() <= 200000)
                {
                    IR = ((SalarioAnualIR() - 100000) * 0.15) / 12;

                }
                if (SalarioAnualIR() >= 200001 && SalarioAnualIR() <= 350000)
                {
                    IR = (((SalarioAnualIR() - 200000) * 0.20)+15000) / 12;
                    
                }
                if (SalarioAnualIR() >= 350001 && SalarioAnualIR() <= 500000)
                {
                    IR = (((SalarioAnualIR() - 350000) * 0.25) + 45000) / 12;
                   
                }
                if (SalarioAnualIR() >= 500001)
                {

                    IR = (((SalarioAnualIR() - 500000) * 0.30) + 82500) / 12;
                }

            return IR;
        }
        public double TotalDeduccines() {
            Tdeducciones = Innslaboral() + CalcularIR();

            return Tdeducciones;
        }

        public  double TotalRecibir() {

            NetoRecibir = TotalIngresos() - TotalDeduccines();

            return NetoRecibir;
        }
       
    }
}
