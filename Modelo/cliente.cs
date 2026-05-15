using Modelo.cs;
using System.ComponentModel;

namespace Modelo
{
    public class cliente
    {
        private string direccion, nombre, correo, telefono;
        private BindingList<Factura> RFacturas = new BindingList<Factura>();
       
        public cliente() {

            direccion = string.Empty;
            nombre = string.Empty;
            correo = string.Empty;
            telefono = string.Empty;

        }
        public cliente(string direccion, string nombre, string correo, string telefono)
        {
            this.direccion = direccion;
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
        }
        public IReadOnlyCollection<Factura> GetFacturas() {

            return RFacturas.ToList().AsReadOnly();

        }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public void GuardarFactura(string nombre, string Desc, double CU, int Cant, string moneda, string fecha, double subF, double Tf) {
            Factura fact = new Factura(nombre, Desc, CU, Cant, moneda, fecha, subF, Tf);
            RFacturas.Add(fact);
        }


        public void EliminarFactura( int pocision) {
            int p = 0;
                p = pocision;

            RFacturas.RemoveAt(p);
            
        
        }

        public void ModFact( int Pos)
        {
            
            RFacturas.RemoveAt(Pos);
        }
        public IEnumerable<Factura> ConsultaMayor(int ParametroLinq) {
            
            
            
                IEnumerable<Factura> CFactura = from factura in RFacturas where factura.Total_Factura > ParametroLinq select factura;
            
            
            return CFactura;
        }

        public IEnumerable<Factura> ConsultaIgual(int ParametroLinq)
        {
            List<Factura> Facts = RFacturas.ToList();


             IEnumerable<Factura> CFactura = from factura in Facts where factura.Total_Factura == ParametroLinq select factura;


            return CFactura;
        }

        public override string ToString()
        {
            return String.Format(" {0}, con {1}, y {2}, para {3}", this.Direccion, this.nombre, this.correo, this.telefono);
        }

        public IEnumerable<Factura> ConsultaMenor(int ParametroLinq)
        {


            IEnumerable<Factura> CFactura = from factura in RFacturas where factura.Total_Factura < ParametroLinq select factura;


            return CFactura;
        }






    }
}