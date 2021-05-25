using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Formularios
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita1;
        public FrmLlamador()
        {
            InitializeComponent();
            cmbFranja.Enabled = false;
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Franja));
            // Lectura
            Franja franjas;
            Enum.TryParse<Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

        }

        public FrmLlamador(Centralita centralita) : this()
        {
            this.centralita1 = centralita;
        }

        public Centralita MostrarCentralita
        {
            get
            {
                return this.centralita1;
            }
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(txtNroDestino.Text.StartsWith("#"))
            {
                cmbFranja.Enabled = true;
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = String.Empty;
            txtNroOrigen.Text = String.Empty;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int duracion = random.Next(1, 50);
        
            if (txtNroDestino.Text.StartsWith("#"))
            {
                string numeroDestino = txtNroDestino.Text.Substring(1);
                Provincial provincial = new Provincial(txtNroOrigen.Text, (Franja)cmbFranja.SelectedItem, duracion, numeroDestino);
                if(this.centralita1 + provincial)
                {
                    MessageBox.Show("Se agregó la llamada Provincial correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la llamada Provincial.");
                }
            }
            else
            {
                Random random1 = new Random();
                float costo = (float)(random1.Next(50, 560) / 100);
                Local local = new Local(txtNroOrigen.Text, duracion, txtNroDestino.Text, costo);

                if (this.centralita1 + local)
                {
                    MessageBox.Show("Se agregó la llamada Local correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la llamada Local.");
                }
            }
        }
    }
}
