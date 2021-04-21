using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            : base (cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de Ruedas: {this.cantidadRuedas}");
            sb.AppendLine($"Cantidad de Puertas: {this.cantidadPuertas}");
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Cantidad de Marchas: {this.cantidadMarchas}");
            sb.AppendLine($"Cantidad de Pasajeros: {this.cantidadPasajeros}");

            return sb.ToString();
        }
    }
}
