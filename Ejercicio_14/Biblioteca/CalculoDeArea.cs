using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CalculoDeArea
    {
        /// <summary>
        /// Obtiene el valor del Area de un Cuadrado.
        /// </summary>
        /// <param name="lado">Valor de un lado del Cuadrado.</param>
        /// <returns>Retorna el valor del área del Cuadrado.</returns>
        public static double CalcularCuadrado(double lado)
        {
            return lado * lado;
        }

        /// <summary>
        /// Obtiene el valor del Area de un Triangulo.
        /// </summary>
        /// <param name="basx">Valor de la base del Triangulo.</param>
        /// <param name="altura">Valor de la altura del Triangulo.</param>
        /// <returns>Retorna el valor del área del Triangulo.</returns>
        public static double CalcularTriangulo(double basx, double altura)
        {
            return (basx * altura) / 2;
        }

        /// <summary>
        /// Obtiene el valor del Area de un Circulo.
        /// </summary>
        /// <param name="radio">Valor del radio del Circulo.</param>
        /// <returns>Retorna el valor del área del Circulo.</returns>
        public static double CalcularCirculo(double radio)
        {
            return Math.PI * (Math.Pow(radio, 2));
        }

    }
}
