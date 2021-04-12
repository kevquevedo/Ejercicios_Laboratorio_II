using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio_23
{
    public partial class Conversor : Form
    {
        Euro euroAux = new Euro(0);
        Pesos pesoAux = new Pesos(0);
        Dolar dolarAux = new Dolar(0);

        /// <summary>
        /// Inicializador del Formulario.
        /// </summary>
        public Conversor()
        {
            InitializeComponent();//Inicializo el formulario.
            Bitmap fondo = new Bitmap(Application.StartupPath +@"\img\monedas.jpg");//Agrego un path.
            this.BackgroundImage = fondo;//Le asigno el path al fondo del formulario.
        }

        /// <summary>
        /// Boton que disponibiliza la opcion de modificar el tipo de cambio de las monedas.
        /// </summary>
        /// <param name="sender">Boton de Lock Cotizacion.</param>
        /// <param name="e">Clicl sobre el boton Lock Cotizacion.</param>
        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            //Si la imagen es el Candado Abierto (0)
            if (btnLockCotizacion.ImageIndex == 0)
            {
                btnLockCotizacion.ImageIndex = 1;//Cambio el estado a Candado Cerrado (1)
                txtCotizacionEuro.Enabled = false;//Dejo sin opcion de modificar la cotiz del Euro.
                txtCotizacionDolar.Enabled = false;//Dejo sin opcion de modificar la cotiz del Dolar.
                txtCotizacionPeso.Enabled = false;//Dejo sin opcion de modificar la cotiz del Peso.
            }
            else//Si la imagen no es el Candado Abierto, es porque esta Cerrado.
            {
                btnLockCotizacion.ImageIndex = 0;//Cambio el estado a Candado Abierto (0)
                txtCotizacionEuro.Enabled = true;//Dejo disponible la opcion de modificar la cotiz del Euro.
                txtCotizacionDolar.Enabled = true;//Dejo disponible la opcion de modificar la cotiz del Dolar.
                txtCotizacionPeso.Enabled = true;//Dejo disponible la opcion de modificar la cotiz del Peso.
            }

        }

        /// <summary>
        /// Obtiene la cotizacion del Euro.
        /// </summary>
        /// <param name="sender">Text Box de Cotizacion del Euro.</param>
        /// <param name="e">Cotizacion del Euro.</param>
        private void txtCotizacionEuro_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(this.txtCotizacionEuro.Text, out double numRecibido))
            {
                //Si lo ingresado es un numero double, lo asigno a la cotizacion del Euro.
                Euro.SetCotizacion = numRecibido;
            }
            else
            {
                //Mientras lo ingresado no sea un tipo de dato valido, sigo haciendo foco sobre el Text Box.
                txtCotizacionEuro.Focus();
            }
        }

        /// <summary>
        /// Obtiene la cotizacion del Dolar.
        /// </summary>
        /// <param name="sender">Text Box de Cotizacion del Dolar.</param>
        /// <param name="e">Cotizacion del Dolar.</param>
        private void txtCotizacionDolar_TextChanged(object sender, EventArgs e)
        {
            //Si lo ingresado es un numero double, lo asigno a la cotizacion del Dolar.
            if (double.TryParse(this.txtCotizacionDolar.Text, out double numRecibido))
            {
                Dolar.SetCotizacion = numRecibido;
            }
            else
            {
                //Mientras lo ingresado no sea un tipo de dato valido, sigo haciendo foco sobre el Text Box.
                txtCotizacionDolar.Focus();
            }
        }

        /// <summary>
        /// Obtiene la cotizacion del Peso.
        /// </summary>
        /// <param name="sender">Text Box de Cotizacion del Peso.</param>
        /// <param name="e">Cotizacion del Peso.</param>
        private void txtCotizacionPeso_TextChanged(object sender, EventArgs e)
        {
            //Si lo ingresado es un numero double, lo asigno a la cotizacion del Peso.
            if (double.TryParse(this.txtCotizacionPeso.Text, out double numRecibido))
            {
                Pesos.SetCotizacion = numRecibido;
            }
            else
            {
                //Mientras lo ingresado no sea un tipo de dato valido, sigo haciendo foco sobre el Text Box.
                txtCotizacionPeso.Focus();
            }
        }

        /// <summary>
        /// Obtiene la cantidad de Euros a convertir.
        /// </summary>
        /// <param name="sender">Text Box de cantidad de Euros.</param>
        /// <param name="e">Asigna a euroAux la cantidad de Euros.</param>
        private void txtEuro_TextChanged(object sender, EventArgs e)
        {
            
            if (double.TryParse(this.txtEuro.Text, out double importeRecibido))
            {
                euroAux = importeRecibido;
            }

        }

        /// <summary>
        /// Obtiene la cantidad de Pesos a convertir.
        /// </summary>
        /// <param name="sender">Text Box de cantidad de Pesos.</param>
        /// <param name="e">Asigna a pesoAux la cantidad de Pesos.</param>
        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtPeso.Text, out double importeRecibido))
            {
                pesoAux = importeRecibido;
            }
        }

        /// <summary>
        /// Obtiene la cantidad de Dolares a convertir.
        /// </summary>
        /// <param name="sender">Text Box de cantidad de Dolares.</param>
        /// <param name="e">Asigna a dolarAux la cantidad de Dolares.</param>
        private void txtDolar_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtDolar.Text, out double importeRecibido))
            {
                dolarAux = importeRecibido;
            }
        }

        /// <summary>
        /// Boton para realizar la conversion de Euro a otras monedas.
        /// </summary>
        /// <param name="sender">Boton para cotizacion del Euro.</param>
        /// <param name="e">Agigna el valor de Euro a las demas monedas.</param>
        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            txtPesoAPeso.Text = pesoAux.GetCantidad().ToString();
            txtPesoADolar.Text = ((Dolar)pesoAux).GetCantidad().ToString();
            txtPesoAEuro.Text = ((Euro)pesoAux).GetCantidad().ToString();
        }

        /// <summary>
        /// Boton para realizar la conversion de Dolar a otras monedas.
        /// </summary>
        /// <param name="sender">Boton para cotizacion del Dolar.</param>
        /// <param name="e">Agigna el valor de Dolar a las demas monedas.</param>
        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            txtDolarADolar.Text = dolarAux.GetCantidad().ToString();
            txtDolarAPeso.Text = ((Pesos)dolarAux).GetCantidad().ToString();
            txtDolarAEuro.Text = ((Euro)dolarAux).GetCantidad().ToString();
        }

        /// <summary>
        /// Boton para realizar la conversion de Peso a otras monedas.
        /// </summary>
        /// <param name="sender">Boton para cotizacion del Peso.</param>
        /// <param name="e">Agigna el valor de Peso a las demas monedas.</param>
        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            txtEuroAEuro.Text = euroAux.GetCantidad().ToString();
            txtEuroADolar.Text = ((Dolar)euroAux).GetCantidad().ToString();
            txtEuroAPeso.Text = ((Pesos)euroAux).GetCantidad().ToString();
        }

    }
}
