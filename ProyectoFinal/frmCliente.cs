using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using System.Text.RegularExpressions;


namespace ProyectoFinal
{ 

    public partial class frmCliente : Form
    {
        ErrorProvider erpError = new ErrorProvider();
        Controlador.controler C = new Controlador.controler();
        
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            btnNuevo.Enabled = false;
            slblFecha.Text = DateTime.Now.ToLongDateString();
            slblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnBuscar_Click(object sender, EventArgs e) { }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvCliente.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            //Validacion para que los textbox no sean nulos
            if (string.IsNullOrEmpty(txtDireccion.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtDireccion.Text.Trim()) || string.IsNullOrEmpty(txtNumero.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            C.ClientesDatos(txtDireccion, txtNombre, txtCorreo, txtNumero);

            C.Datagrid(dgvCliente);
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtNumero.Text = "";

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            C.Buscar(dgvCliente, txtBuscar);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            C.EliminarClient(dgvCliente);
        }

        //Validaciones
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtNumero, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtValidaCorreo(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text != string.Empty && Regex.IsMatch(txt.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                erpError.Clear();
            }
            else
            {
                erpError.SetError(txt, "Correo no Valido");
                txt.Focus();
            }
        }

        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtNumero.Text);
            btnNuevo.Enabled = vr;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtNombre_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtCorreo_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtNumero_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtNombre, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            C.ModificarClientes(txtDireccion, txtNombre, txtCorreo, txtNumero, dgvCliente);
        }
    }
}
