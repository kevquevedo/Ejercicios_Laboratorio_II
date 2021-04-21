using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_22;
using Biblioteca;

namespace Ejercicio_25
{
    public partial class Conversor_Numerico : Form
    {
        NumeroBinario binario = "0";
        NumeroDecimal decimale = 0;

        public Conversor_Numerico()
        {
            InitializeComponent();
        }

        private void txtBin_TextChanged(object sender, EventArgs e)
        {
            string auxiliar = txtBin.Text;
            bool flag = true;
            foreach (char item in auxiliar)
            {
                if (item != '0' && item != '1')
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                binario = auxiliar;
            }
            else
            {
                MessageBox.Show("El valor ingresado no es valido.");
                binario = "0";
            }

            binario = txtBin.Text;
        }

        private void btnConvertBinADec_Click(object sender, EventArgs e)
        {
            txtBinADec.Text = NumeroDecimal.BinarioDecimal((string)binario).ToString();
        }

        private void txtDec_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtDec.Text, out double numIngresado))
            {
                decimale = numIngresado;
            }
            else
            {
                decimale = 0;
                MessageBox.Show("El valor ingresado no es valido.");
            }
        }

        private void btnConvertDecABin_Click(object sender, EventArgs e)
        {
            int valor = (int)decimale;
            txtDecABin.Text = NumeroBinario.DecimalBinario(valor).ToString();
        }
    }
}
