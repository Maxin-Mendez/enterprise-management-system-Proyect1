using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.cs
{
    public class IngresosPorServicios
    {
        string descripcion, fecha;
        double precio;
        
        public IngresosPorServicios(string descripcion, double precio, string fecha )
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.fecha = fecha;
           
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Total { get => precio; set => precio = value; }
        public string Fecha { get => fecha; set => fecha = value; }


    }
}
