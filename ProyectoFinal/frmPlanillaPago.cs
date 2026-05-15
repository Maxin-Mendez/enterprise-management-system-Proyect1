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
    public partial class frmPlanillaPago : Form
    {
        Controlador.controler CP = new();
        ErrorProvider erpError = new ErrorProvider();
        public frmPlanillaPago()
        {
            InitializeComponent();
        }

        private void frmPlanillaPago_Load(object sender, EventArgs e)
        {
          
            dgvPlanillaIgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPlanillaIgr.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
            btnNuevo.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            //Validacion para que los textbox no sean nulos
            if (string.IsNullOrEmpty(txtInss.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtCargo.Text.Trim()) || string.IsNullOrEmpty(txtSalario.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                CP.MandarDatosNomina(txtInss, txtNombre, txtCargo, txtSalario, nudHoras, nudAños);
                CP.MostrarPlanilla(dgvPlanillaIgr);
                txtCargo.Text = "";
                txtNombre.Text = "";
                txtSalario.Text = "";
                nudHoras.Accelerations.Clear();
                nudAños.Accelerations.Clear();
            }
        }

        private void txtInss_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtInss, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtInss.Text) && !string.IsNullOrEmpty(txtCargo.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtSalario.Text);
            btnNuevo.Enabled = vr;
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtSalario, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtInss_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtNombre_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtCargo_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

        private void txtSalario_TextChanged(object sender, EventArgs e) { ValidarCampo(); }

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

        private void label2_Click(object sender, EventArgs e) { }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CP.ModificarPlanilla(txtInss, txtNombre, txtCargo, txtSalario, nudHoras, nudAños, dgvPlanillaIgr);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CP.EliminarNominaPlanilla(dgvPlanillaIgr);
            CP.MostrarPlanilla(dgvPlanillaIgr);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            CP.ConsultaMayorPlani(txtConsulta, dgvConsulta, rbMayores);
            CP.ConsultaMenorPlani(txtConsulta, dgvConsulta, rbMenores);
            CP.ConsultaIgualPlani(txtConsulta, dgvConsulta, rbIguales);
        }
    }
}
