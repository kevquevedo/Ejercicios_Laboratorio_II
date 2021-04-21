using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }


        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo equip, Jugador jug)
        {
            bool retorno = false;
            bool jugadorExiste = true;
            foreach (Jugador item in equip.jugadores)
            {
                if(item == jug)
                {
                    jugadorExiste = false;
                }
            }
            if (jugadorExiste && (equip.jugadores.Count < equip.cantidadDeJugadores) )
            {
                equip.jugadores.Add(jug);
                retorno = true;
            }
            
            return retorno;
        }



    }
}
