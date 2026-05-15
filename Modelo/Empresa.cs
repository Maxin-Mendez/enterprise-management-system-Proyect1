using Modelo.cs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Empresa
    {
        private List<cliente> cliente = new List<cliente>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Almacen> almacen = new List<Almacen>();
        private List<IngresosPorServicios> Servicios = new List<IngresosPorServicios>();
        private BindingList<PlanillaTrabajadores> planilla = new BindingList<PlanillaTrabajadores>();
        private List<int> ints = new List<int>();

        public Empresa() {



        }
        public ReadOnlyCollection<PlanillaTrabajadores> GetPlanillas() {

            return planilla.ToList().AsReadOnly();
            
        }
        public ReadOnlyCollection<IngresosPorServicios> GetServicios()
        {
            return Servicios.AsReadOnly();

        }

        public ReadOnlyCollection<Almacen> GetAlmacen() {

            return almacen.AsReadOnly();
        }
        public ReadOnlyCollection<cliente> GetClientes()
        {
            return cliente.AsReadOnly();
        }

        public ReadOnlyCollection<Usuario> GetUsuarios()
        {

            return usuarios.AsReadOnly();

        }
        public List<int> GetHoras() { return ints; }
        public void guardarHoras(int cant) {

            ints.Add(cant);
        
        }
        public void Agregar(string direccion, string nombre, string correo, string telefono)
        {

            cliente clientes = new cliente(direccion, nombre, correo, telefono);
            if (clientes != null)

                cliente.Add(clientes);
            return;

        }
        public void ModCliente(string direccion, string nombre, string correo, string telefono, int Pos)
        {
            int pocision = Pos;
            cliente ModCliente = new cliente(direccion, nombre, correo, telefono);
            
                cliente.RemoveAt(pocision);
            

        }

        public void SaveUsuario(string Direccion, string Nombre, string Correo, string numero, string cargo)
        {


            Usuario _usuario = new Usuario(Direccion, Nombre, Correo, numero, cargo);


            usuarios.Add(_usuario);

        }
        public void EliminarUsuario(int pocision)
        {
            int P = 0;
            P = pocision;

            usuarios.RemoveAt(pocision);

        }
        public void MoUsuario(string Direccion, string Nombre, string Correo, string numero, string cargo, int Pos)
        {
            int Pocision = Pos;
             Usuario user = new Usuario(Direccion, Nombre, Correo, numero, cargo);
            usuarios.RemoveAt(Pocision);
           

        }


        public void GuardarRegistroAlmacen(string Descripcion, string Entrada, string salida, string cantidad, string precio, string fecha, double total) {
            string date = fecha;
            int Cantidad = int.Parse(cantidad);
            double Precio = double.Parse(precio);
            Almacen  AL= new Almacen(Descripcion, Entrada, salida, Cantidad, Precio,total, date);
            almacen.Add(AL);
            
        }
        public void EliminarR_almacem(int pocision)
        {
            int P = 0;
            P = pocision;

            almacen.RemoveAt(pocision);

        }
        public IEnumerable<Almacen> ConsultaMayorAlmacen(int ParametroLinq)
        {

            IEnumerable<Almacen> CAlmacen = from Al in almacen where Al.Total > ParametroLinq select Al;

            return CAlmacen;
        }
        public IEnumerable<Almacen> ConsultaMenorAlmacen(int ParametroLinq)
        {

            IEnumerable<Almacen> CAlmacen = from Al in almacen where Al.Total < ParametroLinq select Al;

            return CAlmacen;
        }

        public IEnumerable<Almacen> ConsultaIgualAlmacen(int ParametroLinq)
        {

            IEnumerable<Almacen> CAlmacen = from Al in almacen where Al.Total == ParametroLinq select Al;

            return CAlmacen;
        }

        public void GuardarIngresosPorServicios(string DescS, string precioS, string fechs)
        {
            string FECHA = fechs;
            int Precio = int.Parse(precioS);
            IngresosPorServicios ser = new (DescS,Precio, FECHA);
            Servicios.Add(ser);

        }
        public void Eliminar_IngresosPorServicios(int pocision)
        {
            int P = 0;
            P = pocision;

            Servicios.RemoveAt(pocision);

        }
        public void ModIngresosServicios(string Disc, string Precio,string Fecha, int Pos)
        {
            int Pocision = Pos;
            double t = double.Parse(Precio);
            IngresosPorServicios SerMod = new IngresosPorServicios(Disc, t, Fecha);
            Servicios.RemoveAt(Pocision);


        }
        public IEnumerable<IngresosPorServicios> ConsultaMayorServicios(int ParametroLinq)
        {

            IEnumerable<IngresosPorServicios> Cservicios = from IS in Servicios where IS.Total > ParametroLinq select IS;

            return Cservicios;
        }
        public IEnumerable<IngresosPorServicios> ConsultaMenorServicios(int ParametroLinq)
        {

            IEnumerable<IngresosPorServicios> Cservicios = from IS in Servicios where IS.Total < ParametroLinq select IS;

            return Cservicios;
        }
        public IEnumerable<IngresosPorServicios> ConsultaIgualServicios(int ParametroLinq)
        {

            IEnumerable<IngresosPorServicios> Cservicios = from IS in Servicios where IS.Total == ParametroLinq select IS;

            return Cservicios;
        }
        public void GuardarPlanilla(string NInss, string nombre, string cargo, double salario, double antiguedad, double HorasExtras, double totalIngresos, double inssL, double IR, double TotalD, double NetoR ) {
            PlanillaTrabajadores planilla = new(NInss, nombre, cargo, salario, antiguedad, HorasExtras, totalIngresos, inssL, IR, TotalD, NetoR);

            this.planilla.Add(planilla);
        
        }
        public void Eliminar_R_Planilla(int pocision)
        {
            int P = 0;
            P = pocision;

            planilla.RemoveAt(pocision);

        }

        public void ModPlanilla(string NInss, string nombre, string cargo, double salario, double antiguedad, double HorasExtras, double totalIngresos, double inssL, double IR, double TotalD, double NetoR, int Pos)
        {
            int Pocision = Pos;
            PlanillaTrabajadores planilla = new(NInss, nombre, cargo, salario, antiguedad, HorasExtras, totalIngresos, inssL, IR, TotalD, NetoR);

            this.planilla.RemoveAt(Pocision);

        }

        public IEnumerable<PlanillaTrabajadores> ConsultaMayorPlanilla(int ParametroLinq)
        {

            IEnumerable<PlanillaTrabajadores> Cplanilla = from PL in planilla where PL.Salario_Mensual > ParametroLinq select PL;

            return Cplanilla;
        }
        public IEnumerable<PlanillaTrabajadores> ConsultaMenorPlanilla(int ParametroLinq)
        {

            IEnumerable<PlanillaTrabajadores> Cplanilla = from PL in planilla where PL.Salario_Mensual < ParametroLinq select PL;

            return Cplanilla;
        }
        public IEnumerable<PlanillaTrabajadores> ConsultaIgualPlanilla(int ParametroLinq)
        {

            IEnumerable<PlanillaTrabajadores> Cplanilla = from PL in planilla where PL.Salario_Mensual == ParametroLinq select PL;

            return Cplanilla;
        }
        public void EliminarCliente(int pocision) {
            int P = 0;
            P = pocision;

            cliente.RemoveAt(pocision);
        
        }

























    }
}
