using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni,nombre)
        {
            
        }


        public float GetPromedioGoles()
        {
            this.promedioGoles = totalGoles / partidosJugados;
            return this.promedioGoles;
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Partidos Jugados: {this.partidosJugados}");
            sb.AppendLine($"Total Goles: {this.totalGoles}");
            sb.AppendLine($"Promedio de Gol: {this.GetPromedioGoles()}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador jug1, Jugador jug2)
        {
            bool retorno = false;
            if (jug1.dni == jug2.dni)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Jugador jug1, Jugador jug2)
        {
            return !(jug1 == jug2);
        }



    }
}
