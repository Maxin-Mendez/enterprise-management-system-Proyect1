using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.cs
{
    public class Almacen
    {
        private string Descripcion, entrada, salida;
        string DATE;
        int cantidad;
        double total,precio;

        public Almacen() {

            Descripcion = String.Empty;
            entrada = String.Empty;
            salida = String.Empty;
            DATE = String.Empty;
            cantidad = 0;
            total = 0;
            precio = 0;
        
        }
        public Almacen(string producto, string entrada, string salida, int cantidad, double precio, double total, string fecha)
        {
            Descripcion = producto;
            this.cantidad = cantidad;
            this.entrada = entrada;
            this.salida = salida;
            this.precio = precio;
            DATE = fecha;
            this.total = total;
        }

        public string Producto1 { get => Descripcion; set => Descripcion = value; }
        public int Cantidad1 { get => cantidad; set => cantidad = value; }
        public string Entrada{ get => entrada; set => entrada = value; }
        public string Salida { get => salida; set => salida = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Fecha { get => DATE; set => DATE = value; }
        public double Total { get => total; set => total = value; } 
        public double CalcularTotalAlmacem() {

            total = Precio * Cantidad1;
            return total;
        
        }
    }
}
