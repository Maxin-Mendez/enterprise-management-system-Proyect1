using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public class controler2
    {
        private string ruta = "";
        private ListViewGroup empleados1 = new ListViewGroup("CEO", HorizontalAlignment.Center);
        private ListViewGroup empleados2 = new ListViewGroup("Gerente General", HorizontalAlignment.Center);
        private ListViewGroup empleados3 = new ListViewGroup("Administrador", HorizontalAlignment.Center);
        private ListViewGroup empleados4 = new ListViewGroup("Jefe de Recursos Humanos", HorizontalAlignment.Center);
        private ListViewGroup empleados5 = new ListViewGroup("Auditor", HorizontalAlignment.Center);
        private ListViewGroup empleados6 = new ListViewGroup("Supervisor", HorizontalAlignment.Center);
        private ListViewGroup empleados7 = new ListViewGroup("Asistente", HorizontalAlignment.Center);
        private ListViewGroup empleados8 = new ListViewGroup("Operador", HorizontalAlignment.Center);
        private ListViewGroup empleados9 = new ListViewGroup("Personal de Limpieza", HorizontalAlignment.Center);
        private ListViewGroup empleados10 = new ListViewGroup("Ayudante", HorizontalAlignment.Center);
        public void ListV(ListView lstV)
        {
            lstV.Items.Add(new ListViewItem("Elon Musk", empleados1));

            lstV.Items.Add(new ListViewItem("Bill Gates", empleados2));
            lstV.Items.Add(new ListViewItem("Mark Zuckenberk", empleados2));

            lstV.Items.Add(new ListViewItem("Jeff Bezos", empleados3));
            lstV.Items.Add(new ListViewItem("Bernarld Arnault", empleados3));
            lstV.Items.Add(new ListViewItem("Warren Buffett", empleados3));

            lstV.Items.Add(new ListViewItem("William Dahmer", empleados4));

            lstV.Items.Add(new ListViewItem("Giovanni Ferrero", empleados5));
            lstV.Items.Add(new ListViewItem("Alain Wertheimer", empleados5));

            lstV.Items.Add(new ListViewItem("Larry Page", empleados6));
            lstV.Items.Add(new ListViewItem("Serguéi Brin", empleados6));
            lstV.Items.Add(new ListViewItem("Larry Ellison", empleados6));
            lstV.Items.Add(new ListViewItem("Steve Ballmer", empleados6));

            lstV.Items.Add(new ListViewItem("Mukesh Ambani", empleados7));
            lstV.Items.Add(new ListViewItem("Michael Bloomberg", empleados7));

            lstV.Items.Add(new ListViewItem("Gautam Adani", empleados8));
            lstV.Items.Add(new ListViewItem("Carlos Slim", empleados8));
            lstV.Items.Add(new ListViewItem("Jim Walton", empleados8));
            lstV.Items.Add(new ListViewItem("David Koch", empleados8));
            lstV.Items.Add(new ListViewItem("Charles Muntz", empleados8));

            lstV.Items.Add(new ListViewItem("Jacqueline Mars", empleados9));
            lstV.Items.Add(new ListViewItem("John Walter", empleados9));
            lstV.Items.Add(new ListViewItem("Kim Anderson", empleados9));
            lstV.Items.Add(new ListViewItem("Dieter Schwarz", empleados9));

            lstV.Items.Add(new ListViewItem("Miriam Adelson", empleados10));
            lstV.Items.Add(new ListViewItem("David Thomson", empleados10));
            lstV.Items.Add(new ListViewItem("Francis Pinault", empleados10));
            lstV.Items.Add(new ListViewItem("Michael Dell", empleados10));
            lstV.Items.Add(new ListViewItem("Julia Koch", empleados10));
            lstV.Items.Add(new ListViewItem("Phill Sandler", empleados10));
            lstV.Items.Add(new ListViewItem("Michael Scott", empleados10));
            lstV.Items.Add(new ListViewItem("Mackenzie Bloomberg", empleados10));

            lstV.Groups.Add(empleados1);
            lstV.Groups.Add(empleados2);
            lstV.Groups.Add(empleados3);
            lstV.Groups.Add(empleados4);
            lstV.Groups.Add(empleados5);
            lstV.Groups.Add(empleados6);
            lstV.Groups.Add(empleados7);
            lstV.Groups.Add(empleados8);
            lstV.Groups.Add(empleados9);
            lstV.Groups.Add(empleados10);
        }

        public void AgregarCargos(RadioButton rb1, RadioButton rb2, RadioButton rb3, RadioButton rb4, RadioButton rb5, RadioButton rb6, RadioButton rb7, RadioButton rb8, RadioButton rb9, RadioButton rb10, ListView lst, TextBox txt)
        {
            if (rb1.Checked == true)
            {
                lst.Items.Add(new ListViewItem(txt.Text, empleados1));
            }

            if (rb2.Checked == true)
            {
                lst.Items.Add(new ListViewItem(txt.Text, empleados2));
            }

            if (rb3.Checked == true)
            {
                lst.Items.Add(new ListViewItem(txt.Text, empleados3));
            }

            if (rb4.Checked == true)
            {
                lst.Items.Add(new ListViewItem(txt.Text, empleados4));
            }

            if (rb5.Checked == true)
            {
                lst.Items.Add(new ListViewItem(txt.Text, empleados5));
            }

            if (rb6.Checked == true)
            {
                lst.Items.Add(new ListViewItem(txt.Text, empleados6));
            }

            if (rb7.Checked == true)
            {
                lst.Items.Add(new ListViewItem(txt.Text, empleados7));
            }

            if (rb8.Checked == true)
            {
                lst.Items.Add(new ListViewItem(txt.Text, empleados8));
            }

            if (rb9.Checked == true)
            {
                lst.Items.Add(new ListViewItem(txt.Text, empleados9));
            }

            if (rb10.Checked == true)
            {
                lst.Items.Add(new ListViewItem(txt.Text, empleados10));
            }

            txt.Text = "";
        }

        public void CambiarFuente(FontDialog font, Label lbl1, Label lbl2, Label lbl3, Label lbl4, Label lbl5, Label lbl6, Label lbl7, Label lbl8)
        {
            if (font.ShowDialog() == DialogResult.OK)
            {
                lbl1.Font = font.Font;
                lbl2.Font = font.Font;
                lbl3.Font = font.Font;
                lbl4.Font = font.Font;
                lbl5.Font = font.Font;
                lbl6.Font = font.Font;
                lbl7.Font = font.Font;
                lbl8.Font = font.Font;
            }
        }

        public void CambiarColor(ColorDialog fcont, Label lbl1, Label lbl2, Label lbl3, Label lbl4, Label lbl5, Label lbl6, Label lbl7, Label lbl8)
        {
            if (fcont.ShowDialog() == DialogResult.OK)
            {
                lbl1.ForeColor = fcont.Color;
                lbl2.ForeColor = fcont.Color;
                lbl3.ForeColor = fcont.Color;
                lbl4.ForeColor = fcont.Color;
                lbl5.ForeColor = fcont.Color;
                lbl6.ForeColor = fcont.Color;
                lbl7.ForeColor = fcont.Color;
                lbl8.ForeColor = fcont.Color;
            }
        }

        public void Fechas(MonthCalendar month, Label lbl1, Label lbl2)
        {
            DateTime inicio = month.SelectionStart;
            DateTime final = month.SelectionEnd;

            lbl1.Text = inicio.ToString();
            lbl2.Text = final.ToString();
        }

        public void FechasM(MonthCalendar month, Label lbl1)
        {
            lbl1.Text = month.SelectionRange.ToString();
        }

        public void AbrirFileD(OpenFileDialog FileDialog, Label lbl)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                lbl.Text = FileDialog.FileName;
            }
        }

        public void SalvarFileD(SaveFileDialog SaveDialog, Label lbl) 
        {
            if (SaveDialog.ShowDialog()==DialogResult.OK) 
            {
                lbl.Text=SaveDialog.FileName;
            }
        }

        public void AdicionarNodo(TreeView treeview, TextBox txt) 
        {
            treeview.Nodes.Add(txt.Text);
            txt.Text = "";
        }

        public void AdicionarElemento(TreeView treeview, TextBox txt) 
        {
            treeview.SelectedNode.Nodes.Add(txt.Text);
            txt.Text = "";
        }

        public void LimpiarArbol(TreeView treeview)
        {
            treeview.Nodes.Clear();
        }

        public void EliminarNodo(TreeView treeview) 
        {
            treeview.Nodes.Remove(treeview.SelectedNode);
        }

        public void AbrirNotePad(Process process, Label lbl) 
        {
            process.EnableRaisingEvents = true;
            process.Start();
            lbl.Text = "NotePad Arrancado";
        }

        public void CerrarNotePad(Process process)
        {
            process.Kill();
        }

        public void Beep() 
        {
            Console.Beep();
        }

        public void Tono(TextBox txt1, TextBox txt2) 
        {
            int freq=Convert.ToInt32(txt1.Text);
            int dura=Convert.ToInt32(txt2.Text);
            Console.Beep(freq, dura);
        }

        public void Sistema() 
        {
            SystemSounds.Asterisk.Play();
        }

        public void Cargar(OpenFileDialog open, Label lbl) 
        {
            if (open.ShowDialog() == DialogResult.OK) 
            {
                ruta=open.FileName;
                lbl.Text=ruta;
            }
        }

        public void Tocar() 
        {
            try
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = ruta;
                player.Load();
                player.Play();
            }
            catch (Win32Exception ex) 
            {
                MessageBox.Show("No se pudo tocar el audio");
            }
        }

        public void CambiarImagen() { }
    }
}
