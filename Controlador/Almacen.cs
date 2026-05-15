using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.cs
{
    public class Almacen
    {
        private string Descripcion, Cantidad, Entrada, salida,precio;
        string DATE;

        public Almacen(string producto, string entrada, string salida, string cantidad, string precio, string fecha)
        {
            Descripcion = producto;
            Cantidad = cantidad;
            Entrada = entrada;
            this.salida = salida;
            this.precio = precio;
            DATE = fecha;
         
        }

        public string Producto1 { get => Descripcion; set => Descripcion = value; }
        public string Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public string Entrada1 { get => Entrada; set => Entrada = value; }
        public string Salida { get => salida; set => salida = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Fecha { get => DATE; set => DATE = value; }
    }
}
