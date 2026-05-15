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
    public partial class frmRegistroAlmacen : Form
    {
        Controlador.controler CA = new();
        ErrorProvider erpError = new ErrorProvider();
        public frmRegistroAlmacen()
        {
            InitializeComponent();
        }

        private void frmRegistroAlmacen_Load(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            slblFecha.Text = DateTime.Now.ToLongDateString();
            slblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnBuscar_Click(object sender, EventArgs e) { }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvRegistro.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            //Validacion para que los textbox no sean nulos
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()) || string.IsNullOrEmpty(txtCantidad.Text.Trim()) || string.IsNullOrEmpty(txtPrecio.Text.Trim()) || rbEntrada.Checked == false && rbSalida.Checked == false)
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                CA.RegistrarAlmacen(txtDescripcion, txtCantidad, txtPrecio, rbEntrada, rbSalida);
                CA.MostrarAlmacem(dgvRegistro);
                txtPrecio.Text = "";
                txtDescripcion.Text = "";
                txtCantidad.Text = "";
                rbEntrada.Checked = false;
                rbSalida.Checked = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CA.Buscar(dgvRegistro, txtBuscar);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtCantidad, "Ingrese solo Números");
            else
                erpError.Clear();
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
            var vr = !string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtPrecio.Text);
            btnNuevo.Enabled = vr;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtCantidad_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

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
            CA.EliminarAlmacen(dgvRegistro);
            CA.MostrarAlmacem(dgvRegistro);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CA.ModificarAlmacem(txtDescripcion, txtCantidad, txtPrecio, rbEntrada, rbSalida, dgvRegistro);
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            CA.ConsultaMayorAlmacen(txtConsulta, dgvConsulta, rbMayores);
            CA.ConsultaMenorAlmacen(txtConsulta, dgvConsulta, rbMenores);
            CA.ConsultaIgualAlmacen(txtConsulta, dgvConsulta, rbIguales);

        }
    }
}
