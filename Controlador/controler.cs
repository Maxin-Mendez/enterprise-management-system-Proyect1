using Modelo;
using Modelo.cs;
using System.Reflection;
using System.Windows.Forms;
namespace Controlador
    
{
    public class controler
    {
        Modelo.Empresa E = new Modelo.Empresa();
        Modelo.cs.NominaTrabajadores N = new();
        Modelo.cliente C = new();
        Modelo.cs.Factura F = new();
        Modelo.cs.Almacen A = new();
        string Fecha = "";
        int posicion;
        


        public controler() { }
        public void ClientesDatos(TextBox dir, TextBox nom, TextBox mail, TextBox cel)
        {
            string Dir = dir.Text;
            string Nom = nom.Text;
            string gmail = mail.Text;
            string Tel = cel.Text;



            E.Agregar(Dir, Nom, gmail, Tel);


        }

        public void Datagrid(DataGridView Cliente)
        {

            Cliente.DataSource = null;
            Cliente.DataSource = E.GetClientes();

        }
        public void ModificarClientes(TextBox dir, TextBox nom, TextBox mail, TextBox cel, DataGridView dgv) {

            IReadOnlyCollection<cliente> clien = E.GetClientes();
            if (dgv.SelectedRows.Count > 0)
            {
                posicion = dgv.CurrentRow.Index;

                dir.Text = clien.ElementAt(posicion).Direccion;
                nom.Text = clien.ElementAt(posicion).Nombre;
                mail.Text = clien.ElementAt(posicion).Correo;
                cel.Text = clien.ElementAt(posicion).Telefono;
            }
            E.ModCliente(dir.Text, nom.Text, mail.Text, cel.Text, posicion);
        
        }
        public void GuardarUsuario(TextBox Dire, TextBox Nomb, TextBox eMail, TextBox Tel, TextBox Carg)
        {

            string Direccion, Nombre, Email, Telefono, Cargo;
            Direccion = Dire.Text;
            Nombre = Nomb.Text;
            Email = eMail.Text;
            Telefono = Tel.Text;
            Cargo = Carg.Text;


            E.SaveUsuario(Direccion, Nombre, Email, Telefono, Cargo);

        }
        public void MosDatos(DataGridView data)
        {
            data.DataSource = null;

            data.DataSource = E.GetUsuarios();
        }

        public void EliminarUsuario(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                posicion = dgv.CurrentRow.Index;
                E.EliminarUsuario(posicion);
            }

        }

        public void ModificarUsuario(TextBox Dire, TextBox Nomb, TextBox eMail, TextBox Tel, TextBox Carg, DataGridView dgv)
        {
            ObtenerIndices(dgv);
            string Direccion, Nombre, Email, Telefono, Cargo;
            Direccion = Dire.Text;
            Nombre = Nomb.Text;
            Email = eMail.Text;
            Telefono = Tel.Text;
            Cargo = Carg.Text;


            E.MoUsuario(Direccion, Nombre, Email, Telefono, Cargo, posicion);

        }
        public void VaciarTextboxUsuario(TextBox Dire, TextBox Nomb, TextBox eMail, TextBox Tel, TextBox Carg)
        {
            Dire.Text = "";
            Nomb.Text = " ";
            eMail.Text = " ";
            Tel.Text = " ";
            Carg.Text = " ";
        }
        public void llenarTextoUsuario(TextBox Dire, TextBox Nomb, TextBox eMail, TextBox Tel, TextBox Carg, DataGridView dgv, Label l) {

            List<Usuario> user = E.GetUsuarios().ToList();
        
            if (dgv.SelectedRows.Count > 0)
            {

                posicion = dgv.CurrentRow.Index;

                
                Dire.Text = user.ElementAt(posicion).Direccion;
                Nomb.Text = user[posicion].Nombre;
                eMail.Text = user[posicion].Correo;
                Tel.Text = user[posicion].Telefono;
                Carg.Text = user[posicion].Cargo;


                E.MoUsuario(Dire.Text, Nomb.Text, eMail.Text, Tel.Text, Carg.Text, posicion);

            }
        }
        private bool entradaOsalidaAlmacen(RadioButton Entrada, RadioButton Salida) {

            if (Entrada.Checked == true && Salida.Checked == false)
            {

                return true;
            }
            else {
                return false;
            }

        }
        public void RegistrarAlmacen(TextBox des, TextBox Cant, TextBox Precio, RadioButton Ent, RadioButton Sal) {

            A.Precio = double.Parse(Precio.Text);
            A.Cantidad1 = int.Parse(Cant.Text);
            double TotalAlmacen = A.CalcularTotalAlmacem();
            
                Fecha = DateTime.Now.ToString("MM-dd-yyyy");

            if (entradaOsalidaAlmacen(Ent, Sal) == true)
            {

                E.GuardarRegistroAlmacen(des.Text, "Entrada", ".....", Cant.Text, Precio.Text,Fecha, TotalAlmacen);
            }
            else {

                E.GuardarRegistroAlmacen(des.Text, "......", "Salida", Cant.Text, Precio.Text, Fecha, TotalAlmacen);
            }
        }

        public void EliminarAlmacen(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                posicion = dgv.CurrentRow.Index;
                E.EliminarR_almacem(posicion);
            }

        }
        public void MostrarAlmacem(DataGridView dgvAlmacen) {

            dgvAlmacen.DataSource = null;

            dgvAlmacen.DataSource = E.GetAlmacen();
        }

        public void ModificarAlmacem(TextBox des, TextBox Cant, TextBox Precio, RadioButton Ent, RadioButton Sal, DataGridView dgv) {

           IReadOnlyCollection<Almacen> ModA = E.GetAlmacen();
            if (dgv.SelectedRows.Count > 0)
            {
                
                posicion = dgv.CurrentRow.Index;
                des.Text = ModA.ElementAt(posicion).Producto1;
                Cant.Text = ModA.ElementAt(posicion).Cantidad1.ToString();
                Precio.Text = ModA.ElementAt(posicion).Precio.ToString(); ;

                if (ModA.ElementAt(posicion).Entrada == " Entrada")
                {

                    Ent.Checked = true;
                }
                else {
                    Sal.Checked = true;

                }
                E.EliminarR_almacem(posicion);
            }
        }

        public void ConsultaMayorAlmacen(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<Almacen> almacen = E.ConsultaMayorAlmacen(p);

                dgv.DataSource = null;
                dgv.DataSource = almacen.ToList();


            }
        }
        public void ConsultaMenorAlmacen(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<Almacen> almacen = E.ConsultaMenorAlmacen(p);

                dgv.DataSource = null;
                dgv.DataSource = almacen.ToList();


            }
        }
        public void ConsultaIgualAlmacen(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<Almacen> almacen = E.ConsultaIgualAlmacen(p);

                dgv.DataSource = null;
                dgv.DataSource = almacen.ToList();


            }
        }
        public void RegistrarServicios(TextBox Des, TextBox Precio, TextBox Fech) {

            E.GuardarIngresosPorServicios(Des.Text, Precio.Text, Fech.Text);

        }

        public void RegistrosServicios(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                posicion = dgv.CurrentRow.Index;
                E.Eliminar_IngresosPorServicios(posicion);
            }

        }
        public void MoestrarIngresosPorServicios(DataGridView Servicios) {

            Servicios.DataSource = null;
            Servicios.DataSource = E.GetServicios();

        }
        public void EliminarServicios(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                posicion = dgv.CurrentRow.Index;
                E.Eliminar_IngresosPorServicios(posicion);
            }

        }
        public void ModificarServicios(TextBox Des, TextBox Precio, TextBox Fech, DataGridView dgv)
        {
            IReadOnlyCollection<IngresosPorServicios> ser = E.GetServicios();
            if (dgv.SelectedRows.Count > 0)
            {
                posicion = dgv.CurrentRow.Index;
                Des.Text = ser.ElementAt(posicion).Descripcion;
                Precio.Text = ser.ElementAt(posicion).Total.ToString();
                Fech.Text = ser.ElementAt(posicion).Fecha;

                E.ModIngresosServicios(Des.Text, Precio.Text, Fech.Text , posicion);
            }

        }
        public void ConsultaMayorServ(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<IngresosPorServicios> ingresosPorServicios = E.ConsultaMayorServicios(p);

                dgv.DataSource = null;
                dgv.DataSource = ingresosPorServicios.ToList();


            }
        }
        public void ConsultaMenorServ(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<IngresosPorServicios> ingresosPorServicios = E.ConsultaMenorServicios(p);

                dgv.DataSource = null;
                dgv.DataSource = ingresosPorServicios.ToList();


            }
        }
        public void ConsultaIgualServ(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<IngresosPorServicios> ingresosPorServicios = E.ConsultaIgualServicios(p);

                dgv.DataSource = null;
                dgv.DataSource = ingresosPorServicios.ToList();


            }
        }
        public void MandarDatosNomina(TextBox NuInss, TextBox nombre, TextBox cargo, TextBox salario, NumericUpDown CantHE, NumericUpDown cantAntiguedad)
        {
            double IR, HorasExtras, Antiguedad, totalIngresos, insnLaboral, totaldeduccionos, netoRe;
            N.NInss1 = NuInss.Text;
            N.Nombre1 = nombre.Text;
            N.Cargo = cargo.Text;
            N.cantExtras = Convert.ToInt16(CantHE.Text);
            N.Salario = Convert.ToDouble(salario.Text);
            N.Antiguedad = Convert.ToInt16(cantAntiguedad.Text);
            HorasExtras = N.HorasExtras();
            Antiguedad = N.CalcularAntiguedad();
            totalIngresos = N.TotalIngresos();
            insnLaboral = N.Innslaboral();
            IR = N.CalcularIR();
            totaldeduccionos = N.TotalDeduccines();
            netoRe = N.TotalRecibir();
            E.guardarHoras((int)CantHE.Value);
            E.GuardarPlanilla(NuInss.Text, nombre.Text, cargo.Text, N.Salario, Antiguedad, HorasExtras, totalIngresos, insnLaboral, IR, totaldeduccionos, netoRe);

        }

        public void MostrarPlanilla(DataGridView planilla) {
            planilla.DataSource = null;
            planilla.DataSource = E.GetPlanillas();
        }
        public void EliminarNominaPlanilla(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                posicion = dgv.CurrentRow.Index;
                E.Eliminar_R_Planilla(posicion);
            }

        }

        public void ModificarPlanilla(TextBox NuInss, TextBox nombre, TextBox cargo, TextBox salario, NumericUpDown CantHE, NumericUpDown cantAntiguedad, DataGridView dgv) {

            IReadOnlyCollection<PlanillaTrabajadores> planilla = E.GetPlanillas();
            List<int> hr = E.GetHoras();
            if (dgv.SelectedRows.Count > 0)
            {
                posicion = dgv.CurrentRow.Index;
                NuInss.Text = planilla.ElementAt(posicion).Numero_Inss;
                nombre.Text = planilla.ElementAt(posicion).Nombre;
                cargo.Text = planilla.ElementAt(posicion).Cargo;
                salario.Text = planilla.ElementAt(posicion).Salario_Mensual.ToString();
                
                E.Eliminar_R_Planilla(posicion);
            }

        }
        public void ConsultaMayorPlani(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<PlanillaTrabajadores> Cp = E.ConsultaMayorPlanilla(p);

                dgv.DataSource = null;
                dgv.DataSource = Cp.ToList();


            }
        }
        public void ConsultaMenorPlani(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<PlanillaTrabajadores> Cp = E.ConsultaMenorPlanilla(p);

                dgv.DataSource = null;
                dgv.DataSource = Cp.ToList();


            }
        }
        public void ConsultaIgualPlani(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<PlanillaTrabajadores> Cp = E.ConsultaIgualPlanilla(p);

                dgv.DataSource = null;
                dgv.DataSource = Cp.ToList();


            }
        }
        public void GuardarFact(TextBox Nombre, TextBox Desc, TextBox CostoU, NumericUpDown Cant, ComboBox Moneda, DateTimePicker fecha) {
            string Fecha = fecha.Value.ToShortDateString();
            int Cantidad = Convert.ToInt16(Cant.Value.ToString());
            double Subtotal=0, TotalFact =0;

            F.Cantidad = Cantidad;
            F.Costo_Unitario = Convert.ToDouble(CostoU.Text);
            Subtotal = F.SubtotalFactura();
            TotalFact = F.TotalFactura();
            C.GuardarFactura(Nombre.Text, Desc.Text, Convert.ToDouble(CostoU.Text), Cantidad, Moneda.Text, Fecha, Subtotal, TotalFact);
        }
        public void MostrarRegistroFactura(DataGridView dgvFact) {
            dgvFact.DataSource = null;
            dgvFact.DataSource = C.GetFacturas();

        }
        public void EliminarFact(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {

                posicion = dgv.CurrentRow.Index;
                C.EliminarFactura(posicion);
                
                
            }

        }
        public void ModificarFactura(TextBox Nombre, TextBox Desc, TextBox CostoU, NumericUpDown Cant, ComboBox Moneda, DateTimePicker fecha, DataGridView dgv)
        {

            IReadOnlyCollection<Factura> Fac = C.GetFacturas();
            
            if (dgv.SelectedRows.Count > 0)
            {

                posicion = dgv.CurrentRow.Index;


                Nombre.Text = Fac.ElementAt(posicion).Cliente;
                Desc.Text = Fac.ElementAt(posicion).Descripcion;
                CostoU.Text = Fac.ElementAt(posicion).Costo_Unitario.ToString();
              
                C.EliminarFactura(posicion);
            }
        }
        public void ConsultaMenorFactura(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<Factura> FACt = C.ConsultaMenor(p);

                dgv.DataSource = null;
                dgv.DataSource = FACt.ToList();


            }
        }
        public void ConsultaIgualFactura(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<Factura> FACt = C.ConsultaMenor(p);


                dgv.DataSource = FACt.ToList();


            }
        }
        public void Buscar(DataGridView dgv, TextBox txtBuscar)
          {
                if (txtBuscar.Text != "")
            {
                dgv.CurrentCell = null;
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if (c.Value.ToString().ToUpper().IndexOf(txtBuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    r.Visible = true;
                }
            }
        }

        public void EliminarClient(DataGridView dgv) 
        {
            if(dgv.SelectedRows.Count > 0) {

                posicion = dgv.CurrentRow.Index;
                E.EliminarCliente(posicion);
                dgv.DataSource = null;
                dgv.DataSource = E.GetClientes();
             }
            
        }
        public void ObtenerIndices(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0)
            {

                posicion = dgv.CurrentRow.Index;
               
            }

        }
       
        public void ConsultaMayor(TextBox para, DataGridView dgv, RadioButton rb)
        {
            int p = int.Parse(para.Text);
            if (rb.Checked == true)
            {
                IEnumerable<Factura> FACt = C.ConsultaMayor(p);

                
                dgv.DataSource = FACt.ToList();


            }
        }
    }
}