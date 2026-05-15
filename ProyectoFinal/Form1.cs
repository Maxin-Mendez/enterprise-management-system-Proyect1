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
    public partial class Form1 : Form
    {
        private static Button botonmenuactivo = null;
        private static Form formularioactivo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Admin";
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            PanelMenuTop.BackColor = Color.FromArgb(20, 20, 95);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmUsuario());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmCliente());
        }

        private void btnRegistroAlmacen_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmRegistroAlmacen());
        }

        private void btnServiciosIngresos_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmServiciosIngresos());
        }

        private void btnPlanillaTrabajadores_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmPlanillaPago());
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercaDe form = new frmAcercaDe();
            form.ShowDialog();
        }

        private void AbrirFormulario(Form FormularioHijo)
        {
            if (formularioactivo != null)
            {
                formularioactivo.Close();
            }
            formularioactivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            FormularioHijo.BackColor = Color.GhostWhite;
            panel2.Controls.Add(FormularioHijo);
            panel2.Tag = FormularioHijo;
            FormularioHijo.Show();
            lblNombreFormulario.Text = FormularioHijo.Text;
        }

        private void BotonActivo(Button BotonSeleccionado) 
        {
            if (botonmenuactivo != null)
            {
                botonmenuactivo.BackColor = Color.MidnightBlue;
            }
            botonmenuactivo = BotonSeleccionado;
            BotonSeleccionado.BackColor = Color.FromArgb(92, 92, 197);
        }

        private void btnFacturaVenta_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmFactura());
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e) { }

        private void pnContenido_Paint(object sender, PaintEventArgs e) { }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            BotonActivo((Button)sender);
            AbrirFormulario(new frmOpciones());
        }
    }
}