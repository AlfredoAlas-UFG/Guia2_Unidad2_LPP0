using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_Investigacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el valor del MaskedTextBox
            string number = maskedTextBox1.Text;
            MessageBox.Show("DUI ingresado: " + number);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // Manejar el evento cuando la entrada no coincide con la máscara
            MessageBox.Show("Formato inválido. Por favor, ingrese un número de DUI válido.");
        }
    }
}
