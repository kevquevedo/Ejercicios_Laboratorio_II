using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Colores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    }

    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            : base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de Ruedas: {this.cantidadRuedas}");
            sb.AppendLine($"Cantidad de Puertas: {this.cantidadPuertas}");
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Cilindrada: {this.cilindrada}");

            return sb.ToString();
        }
    }
}
