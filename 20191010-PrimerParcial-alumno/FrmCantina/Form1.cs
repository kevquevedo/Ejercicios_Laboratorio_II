using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ControlCantina;

namespace FrmCantina
{
    public partial class FormCantina : Form
    {
        public FormCantina()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void cmbBotellaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Botella.Tipo tipo; 
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rbtnAgua.Checked)
            {
                Agua aguaAuxiliar = new Agua((int)nudCapacidad.Value, txtMarca.Text, (int)nudContenido.Value);
                this.barra1.AgregarBotella(aguaAuxiliar);
                MessageBox.Show("Agua agregada!.");
            }
            else if (rbtnCerveza.Checked)
            {
                Cerveza cervAuxiliar = new Cerveza((int)nudCapacidad.Value, txtMarca.Text, (Botella.Tipo)cmbBotellaTipo.SelectedIndex,(int)nudContenido.Value);
                this.barra1.AgregarBotella(cervAuxiliar);
                MessageBox.Show("Birra agregada!.");
            }
        }
    }
}
