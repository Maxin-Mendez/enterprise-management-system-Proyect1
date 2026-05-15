using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmServiciosIngresos : Form
    {
        Controlador.controler CS = new();
        ErrorProvider erpError = new ErrorProvider();
        public frmServiciosIngresos()
        {
            InitializeComponent();
        }

        private void frmServiciosIngresos_Load(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            slblFecha.Text = DateTime.Now.ToLongDateString();
            slblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnBuscar_Click(object sender, EventArgs e) { }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvServicios.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            //Validacion para que los textbox no sean nulos
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else {

                CS.RegistrarServicios(txtDescripcion, txtPrecio, txtFecha);
                CS.MoestrarIngresosPorServicios(dgvServicios);
                txtDescripcion.Text = "";
                txtPrecio.Text = "";
                txtFecha.Text = "";
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CS.Buscar(dgvServicios, txtBuscar);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtPrecio, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtPrecio.Text);
            btnNuevo.Enabled = vr;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtPrecio_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtDescripcion, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            CS.EliminarServicios(dgvServicios);
            CS.MoestrarIngresosPorServicios(dgvServicios);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CS.ModificarServicios(txtDescripcion, txtPrecio, txtFecha, dgvServicios);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            CS.ConsultaMayorServ(txtConsulta, dgvConsulta, rbMayores);
            CS.ConsultaMenorServ(txtConsulta, dgvConsulta, rbMenores);
            CS.ConsultaIgualServ(txtConsulta, dgvConsulta, rbIguales);
        }
    }
    
}
