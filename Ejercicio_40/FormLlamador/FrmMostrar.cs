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
    public partial class FrmMostrar : Form
    {
        private TipoLLamada tipoLLamada;
        private Centralita centralita;

        public FrmMostrar()
        {
            InitializeComponent();
        }

        public FrmMostrar(Centralita centralita) : this ()
        {
            this.centralita = centralita;
        }

        public TipoLLamada TipoLLamada
        {
            set
            {
                this.tipoLLamada = value;
            }
        }

        public void MostrarInformacion()
        {
            switch (this.tipoLLamada)
            {
                case TipoLLamada.Local:
                    rtbInfoLlamadas.Text = $"Ganancia por Llamadas Locales: {this.centralita.GananciasPorLocal:0.00}";
                    break;

                case TipoLLamada.Provincial:
                    rtbInfoLlamadas.Text = $"Ganancia por Llamadas Provinciales: {this.centralita.GananciasPorProvincial:0.00}";
                    break;

                case TipoLLamada.Todas:
                    rtbInfoLlamadas.Text = $"Ganancia por Todas las LLamadas: {this.centralita.GananciasPorTotal:0.00}";
                    break;

                default:
                    break;
            }
        }
    }
}
