using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temperaturas;

namespace Ejercicio_24
{
    public partial class Conversor : Form
    {
        Fahrenheit fahrenheit = new Fahrenheit();
        Celsius celsius = new Celsius();
        Kelvin kelvin = new Kelvin();

        public Conversor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Obtiene la cantidad de temperatura del Fahrenheit.
        /// </summary>
        /// <param name="sender">Text Box de temperatura de Fahrenheit.</param>
        /// <param name="e">Temperatura de Fahrenheit.</param>
        private void txtFahrenheit_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtFahrenheit.Text, out double tempIngresada))
            {
                fahrenheit = tempIngresada;
            }
        }

        /// <summary>
        /// Obtiene la cantidad de temperatura del Celsius.
        /// </summary>
        /// <param name="sender">Text Box de temperatura de Celsius.</param>
        /// <param name="e">Temperatura de Celsius.</param>
        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtCelsius.Text, out double tempIngresada))
            {
                celsius = tempIngresada;
            }
        }

        /// <summary>
        /// Obtiene la cantidad de temperatura del Kelvin.
        /// </summary>
        /// <param name="sender">Text Box de temperatura de Kelvin.</param>
        /// <param name="e">Temperatura de Kelvin.</param>
        private void txtKelvin_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtKelvin.Text, out double tempIngresada))
            {
                kelvin = tempIngresada;
            }
        }

        /// <summary>
        /// Boton para realizar la conversion de Fahrenheit a otras temperaturas.
        /// </summary>
        /// <param name="sender">Boton para convertir Fahrenheit a todas las temperaturas.</param>
        /// <param name="e">Agigna el valor de Fahrenheit a las demas temperaturas.</param>
        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            txtFahrenAFahren.Text = fahrenheit.GetTemperatura().ToString();
            txtFahrenACelsius.Text = ((Celsius)fahrenheit).GetTemperatura().ToString();
            txtFahrenAKelvin.Text = ((Kelvin)fahrenheit).GetTemperatura().ToString();
        }

        /// <summary>
        /// Boton para realizar la conversion de Celsius a otras temperaturas.
        /// </summary>
        /// <param name="sender">Boton para convertir Celsius a todas las temperaturas.</param>
        /// <param name="e">Agigna el valor de Celsius a las demas temperaturas.</param>
        private void btnCelsius_Click(object sender, EventArgs e)
        {
            txtCelsiusACelsius.Text = celsius.GetTemperatura().ToString();
            txtCelsiusAFahren.Text = ((Fahrenheit)celsius).GetTemperatura().ToString();
            txtCelsiusAKelvin.Text = ((Kelvin)celsius).GetTemperatura().ToString();
        }

        /// <summary>
        /// Boton para realizar la conversion de Kelvin a otras temperaturas.
        /// </summary>
        /// <param name="sender">Boton para convertir Kelvin a todas las temperaturas.</param>
        /// <param name="e">Agigna el valor de Kelvin a las demas temperaturas.</param>
        private void btnKelvin_Click(object sender, EventArgs e)
        {
            txtKelvinAKelvin.Text = kelvin.GetTemperatura().ToString();
            txtKelvinAFahren.Text = ((Fahrenheit)kelvin).GetTemperatura().ToString();
            txtKelvinACelsius.Text = ((Celsius)kelvin).GetTemperatura().ToString();
        }
    }
}
