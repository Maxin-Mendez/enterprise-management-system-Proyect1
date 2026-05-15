using Controlador;
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
    public partial class frmFactura : Form
    {
        ErrorProvider erpError = new ErrorProvider();
        Controlador.controler CF = new();
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            slblFecha.Text = DateTime.Now.ToLongDateString();
            slblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            //Validacion para que los textbox no sean nulos
            if (string.IsNullOrEmpty(txtCliente.Text.Trim()) || string.IsNullOrEmpty(txtDescripcion.Text.Trim()) || string.IsNullOrEmpty(txtCostoU.Text.Trim()) || string.IsNullOrEmpty(nudCantidad.Text.Trim()) || string.IsNullOrEmpty(cboMoneda.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else {
                CF.GuardarFact(txtCliente,txtDescripcion,txtCostoU, nudCantidad, cboMoneda, dtpFecha);
                CF.MostrarRegistroFactura(dgvFactura);
                txtCliente.Text = "";
                txtCostoU.Text = "";
                txtDescripcion.Text = "";
                cboMoneda.Text = " ";
                dtpFecha.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CF.EliminarFact(dgvFactura);
            CF.MostrarRegistroFactura(dgvFactura);
        }

        private void btnModificar_Click(object sender, EventArgs e) 
        {
            CF.ModificarFactura(txtCliente, txtDescripcion, txtCostoU, nudCantidad, cboMoneda, dtpFecha, dgvFactura);
        }

        private void label2_Click(object sender, EventArgs e) { }
       
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            CF.ConsultaMayor(txtConsulta, dgvConsulta, rbMayores);
            CF.ConsultaMenorFactura(txtConsulta, dgvConsulta, rbMenores);
            CF.ConsultaIgualFactura(txtConsulta, dgvConsulta, rbIguales);
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e) { }

        private void txtCostoU_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtCostoU, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtCliente.Text) && !string.IsNullOrEmpty(txtCostoU.Text) && !string.IsNullOrEmpty(txtDescripcion.Text);
            btnNuevo.Enabled = vr;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtDescripcion_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtCostoU_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtCliente, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtDescripcion, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }
    }
}
