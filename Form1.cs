﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2_Unidad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtbNumPunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números 
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace 
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtbNumPunto.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true; MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtbLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números 
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio 
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar 
            else
            {
                e.Handled = true; MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static bool validarEmail(string email)
        {
            //cadena o expresion regular que verifica a un formato de correo electrónico 
            string expresion = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$";
            //verifica que el email ingresado corresponda con la expresion válida 
            if (Regex.IsMatch(email, expresion))
            {//verifica que la direccion corresponda y que la longitud de la cadena no esté vacía
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void txtbEmail_Leave(object sender, EventArgs e)
        {
            if (!validarEmail(txtbEmail.Text))
            {
                /*sino es correcto que envíe este mensaje y se posicione para verificar recuerde que se activará 
                la validación al dar click en otro textbox o simplemente dejar o salir de esa casilla de email*/
                MessageBox.Show("Dirección de correo no válida");
                txtbEmail.SelectAll(); //selecciona todo lo de la casilla 
                txtbEmail.Focus(); //se posiciona ahí de nuevo
            }
        }
    }
}
