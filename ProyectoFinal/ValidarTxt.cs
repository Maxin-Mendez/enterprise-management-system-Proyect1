using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public class ValidarTxt
    {
        public static bool ValidarNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        public static bool ValidarLetras(KeyPressEventArgs e)
        {
            
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                    return true;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    return true;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                    return true;
                }
                else 
                {
                    e.Handled = true;
                    return false;
                }
            
            
        }
    }
}
