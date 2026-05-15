using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmUsuario : Form
    {
        Controlador.controler CU = new();
        ErrorProvider erpError=new ErrorProvider();
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            slblFecha.Text=DateTime.Now.ToLongDateString();
            slblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) { }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnBuscar_Click(object sender, EventArgs e) { }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            //Validacion para que los textbox no sean nulos
            if (string.IsNullOrEmpty(txtDireccion.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtDireccion.Text.Trim()) || string.IsNullOrEmpty(txtNumero.Text.Trim()) || string.IsNullOrEmpty(txtCargo.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CU.GuardarUsuario(txtDireccion, txtNombre, txtCorreo, txtNumero, txtCargo);
            CU.MosDatos(dgvData);
            CU.VaciarTextboxUsuario(txtDireccion, txtNombre, txtCorreo, txtNumero, txtCargo);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CU.Buscar(dgvData, txtBuscar);
        }

        //Validaciones
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida=ValidarTxt.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtNumero, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtValidaCorreo(object sender, EventArgs e) 
        {
            TextBox txt = sender as TextBox;
            if(txt.Text != string.Empty && Regex.IsMatch(txt.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
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
            var vr = !string.IsNullOrEmpty(txtCargo.Text) && !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtNumero.Text);
            btnNuevo.Enabled = vr;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtNombre_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtCorreo_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtNumero_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtCargo_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtNombre, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtCargo, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            CU.EliminarUsuario(dgvData);
            CU.MosDatos(dgvData);
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CU.llenarTextoUsuario(txtDireccion, txtNombre, txtCorreo, txtNumero, txtCargo, dgvData, label1);
        }
    }
}
