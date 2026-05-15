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
    public partial class frmOpciones : Form
    {
        ErrorProvider erpError = new ErrorProvider();
        Controlador.controler2 C = new();
        private int indice;
        public frmOpciones()
        {
            InitializeComponent();
            indice = 0;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione la opción que desea realizar");
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a + b;
            lblResultado.Text = r.ToString();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a - b;
            lblResultado.Text = r.ToString();
        }

        private void multiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a * b;
            lblResultado.Text = r.ToString();
        }

        private void dividirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a / b;
            lblResultado.Text = r.ToString();
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtA.Enabled=habilitarToolStripMenuItem.Checked;
            txtB.Enabled=habilitarToolStripMenuItem.Checked;
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtA.Text = "0";
            txtB.Text = "0";
        }

        private void aleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd=new Random();
            int valor1 = rnd.Next(0,100);
            int valor2 = rnd.Next(0,100);

            txtA.Text=valor1.ToString();
            txtB.Text = valor2.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dupProductos.Items.Add(txtProducto.Text);
            txtProducto.Text = "";
        }

        private void dupProductos_SelectedItemChanged(object sender, EventArgs e)
        {
            if (dupProductos.SelectedIndex!=-1) 
            {
                string producto = (string)dupProductos.SelectedItem;
                lblMensaje.Text = string.Format("El producto seleccionado es {0} ", producto);
            }
        }

        private void btnBorrarDUP_Click(object sender, EventArgs e)
        {
            int indice=dupProductos.SelectedIndex;
            dupProductos.Items.RemoveAt(indice);
            dupProductos.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstServicios.Items.Add(txtServicios.Text);
            txtServicios.Text = string.Empty;
        }

        private void lstServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstServicios.SelectedIndex != -1) 
            {
                string servicio = (string)lstServicios.Items[lstServicios.SelectedIndex];
                lblServicios.Text = string.Format("El servicio seleccionado es {0} ", servicio);
            }
            
        }

        private void btnBorrarServicios_Click(object sender, EventArgs e)
        {
            int indice = lstServicios.SelectedIndex;

            if (indice != -1) 
            {
                lstServicios.Items.RemoveAt(indice);
            }
        }

        //Validaciones
        private void ValidarCampoP()
        {
            var vr = !string.IsNullOrEmpty(txtProducto.Text);
            btnAdicionar.Enabled = vr;
        }

        private void ValidarCampoS()
        {
            var vr = !string.IsNullOrEmpty(txtServicios.Text);
            btnAgregar.Enabled = vr;
        }

        private void frmOpciones_Load_1(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = false;
            btnAgregar.Enabled = false;
            btnAdicionarElemento.Enabled = false;
            btnAdicionarNodo.Enabled = false;
            C.ListV(lstvEmpleados);
        }

        private void txtProducto_TextChanged(object sender, EventArgs e) { ValidarCampoP(); }

        private void txtServicios_TextChanged(object sender, EventArgs e) { ValidarCampoS(); }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtProducto, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtServicios, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtA, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtB, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void btnAgregarCargos_Click(object sender, EventArgs e)
        {
            C.AgregarCargos(rbEmpleados1, rbEmpleados2, rbEmpleados3, rbEmpleados4, rbEmpleados5, rbEmpleados6, rbEmpleados7, rbEmpleados8, rbEmpleados9, rbEmpleados10, lstvEmpleados, txtCargo);
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTxt.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtCargo, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void cambiarFuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C.CambiarFuente(fontDialog1, lblMensaje, lblResultado, lblServicios, lblInicio, lblFinal, label3, label4, lblRango);
        }

        private void cambiarColorDeLasFuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C.CambiarColor(colorDialog1, lblMensaje, lblResultado, lblServicios, lblInicio, lblFinal, label3, label4, lblRango);
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            C.Fechas(monthCalendar1, lblInicio, lblFinal);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            C.FechasM(monthCalendar1, lblRango);
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            C.AbrirFileD(openFileDialog1, lblOpenDialog);
        }

        private void btnSaveDialog_Click(object sender, EventArgs e)
        {
            C.SalvarFileD(saveFileDialog1, lblSaveDialog);
        }

        private void btnAdicionarNodo_Click(object sender, EventArgs e)
        {
            C.AdicionarNodo(treeView1, txtNodo);
        }

        private void btnAdicionarElemento_Click(object sender, EventArgs e)
        {
            C.AdicionarElemento(treeView1, txtElemento);
        }

        private void btnLimpiarArbol_Click(object sender, EventArgs e)
        {
            C.LimpiarArbol(treeView1);
        }

        private void btnEliminarNodo_Click(object sender, EventArgs e)
        {
            C.EliminarNodo(treeView1);
        }

        private void ValidarCampoNodo()
        {
            var vr = !string.IsNullOrEmpty(txtNodo.Text);
            btnAdicionarNodo.Enabled = vr;
        }

        private void ValidarCampoElemento()
        {
            var vr = !string.IsNullOrEmpty(txtElemento.Text);
            btnAdicionarElemento.Enabled = vr;
        }

        private void txtNodo_TextChanged(object sender, EventArgs e) { ValidarCampoNodo(); }

        private void txtElemento_TextChanged(object sender, EventArgs e) { ValidarCampoElemento(); }

        private void btnAbrirNotepad_Click(object sender, EventArgs e)
        {
            C.AbrirNotePad(prcNotedPad, lblEstado);
        }

        private void btnCerrarNotepad_Click(object sender, EventArgs e)
        {
            C.CerrarNotePad(prcNotedPad);
        }

        private void prcNotedPad_Exited(object sender, EventArgs e)
        {
            lblEstado.Text = "NotePad Cerrado";
            notifyIcon1.ShowBalloonTip(100,"Alerta","NotePad Cerrado",ToolTipIcon.Info);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            C.Beep();
        }

        private void btnTono_Click(object sender, EventArgs e)
        {
            C.Tono(txtFreq, txtDura);
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            C.Sistema();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            C.Cargar(openFileDialog2, lblRuta);
        }

        private void btnTocar_Click(object sender, EventArgs e)
        {
            C.Tocar();
        }

        private void btnCambioImagen_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 9)
                indice = 0;

            lblFoto.ImageIndex = indice;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
