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
    public partial class FrmMenu : Form
    {
        private Centralita centralita;

        public FrmMenu()
        {
            InitializeComponent();
            centralita = new Centralita("KEVIN CENTER");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(centralita);
            llamador.ShowDialog();
            this.centralita = llamador.MostrarCentralita;
        }

        private void btnFactTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLLamada = TipoLLamada.Todas;
            mostrar.MostrarInformacion();
            mostrar.ShowDialog();
        }

        private void btnFactLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLLamada = TipoLLamada.Local;
            mostrar.MostrarInformacion();
            mostrar.ShowDialog();
        }

        private void btnFactProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLLamada = TipoLLamada.Provincial;
            mostrar.MostrarInformacion();
            mostrar.ShowDialog();
        }
    }
}
