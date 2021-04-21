using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
            : base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de Ruedas: {this.cantidadRuedas}");
            sb.AppendLine($"Cantidad de Puertas: {this.cantidadPuertas}");
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Cantidad de Marchas: {this.cantidadMarchas}");
            sb.AppendLine($"Peso de Carga: {this.pesoCarga}");

            return sb.ToString();
        }

    }
}
