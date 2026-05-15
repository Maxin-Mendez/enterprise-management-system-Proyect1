using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.cs
{
    public class Factura

    {
        string cliente, descripcion, moneda, fecha;
        double CUnitario;
        int cantidad;
        double SubFact;
        double totalFactura;

      
        public Factura() {
            
            cliente = string.Empty;
            descripcion  = String.Empty;
            moneda = string.Empty;
            fecha = string.Empty;
            CUnitario = 0;
            cantidad = 0;
            SubFact = 0;
            totalFactura = 0;
        
        }
        public Factura(string cliente, string descripcion, double cUnitario,int cantidad, string moneda, string fecha, double subFact, double totalFactura)
        {
            this.cliente = cliente;
            this.descripcion = descripcion;
            CUnitario = cUnitario;
            this.cantidad = cantidad;
            this.moneda = moneda;
            this.fecha = fecha;
            SubFact = subFact;
            this.totalFactura = totalFactura;
        }

        public string Cliente { get => cliente; set => cliente = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Costo_Unitario { get => CUnitario; set => CUnitario = value; }
        public string Moneda { get => moneda; set => moneda = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double SubTotal_Factura { get => SubFact; set => SubFact = value; }
        public double Total_Factura { get => totalFactura; set => totalFactura = value; }

        public double SubtotalFactura() {

            SubFact = Cantidad * Costo_Unitario;

            return SubFact;

        }

        public double TotalFactura() {

            totalFactura = (SubTotal_Factura * 0.15) + SubTotal_Factura;
            return totalFactura;
        
        }

       
    }
}
