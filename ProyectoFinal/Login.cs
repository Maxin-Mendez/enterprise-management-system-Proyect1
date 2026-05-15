using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Diagnostics;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        int conteo = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            pbProgreso.Value = 0;
            conteo = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text != "") && (txtContraseña.Text != ""))
            {
                if ((txtUsuario.Text == "Admin") && (txtContraseña.Text == "Contraseña123"))
                {
                    timerTiempo.Enabled = true;
                    pbProgreso.Value = 0;

                    this.timerTiempo.Start();

                }

                if (txtUsuario.Text != "Admin")
                {
                    MessageBox.Show("No se encontraron coincidencias del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtUsuario.Focus();
                }

                if (txtContraseña.Text != "Contraseña123")
                {
                    MessageBox.Show("No se encontraron coincidencias de la contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtUsuario.Focus();
                }
            }
        }

        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            conteo = conteo + 2;

            if (pbProgreso.Value < 100)
                pbProgreso.Value = conteo;


            if (pbProgreso.Value == 100)
            {
                timerTiempo.Enabled = false;
                frm.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://support.google.com/accounts/answer/41078?hl=es-419&co=GENIE.Platform%3DAndroid");
        }
    }
}
