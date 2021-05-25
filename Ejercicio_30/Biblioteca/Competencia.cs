using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        /// <summary>
        /// Constructor privado de Competencia que inicializa la lista de competidores.
        /// </summary>
        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        /// <summary>
        /// Constructor publico de Competencia que inicializa la cantidad de vueltas y la cantidad de competidores.
        /// </summary>
        /// <param name="cantidadVueltas">Cantidad de vueltas de la compentencia.</param>
        /// <param name="cantidadCompetidores">Cantidad maxima de competidores.</param>
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        /// <summary>
        /// Operador que suma un AutoF1 en la competencia, validando que haya lugar y que no exista.
        /// </summary>
        /// <param name="comp">Competencia a agregar el AutoF1.</param>
        /// <param name="auto">AutoF1 a agregar en la competencia.</param>
        /// <returns></returns>
        public static bool operator +(Competencia comp, AutoF1 auto)
        {
            bool retorno = false;
            Random numeroRandom = new Random();
            if ( (comp != auto) && (comp.cantidadCompetidores > 0))
            {
                auto.SetEnCompetencia = true;
                auto.SetVueltasRestantes = comp.cantidadVueltas;
                auto.SetCantidadCombustible = (short)numeroRandom.Next(15, 100);
                comp.competidores.Add(auto);
                comp.cantidadCompetidores--;
                retorno = true;
                Thread.Sleep(100);
            }
            return retorno;
        }

        /// <summary>
        /// Operador que evalua si el AutoF1 se encuentra en la Competencia.
        /// </summary>
        /// <param name="comp">Competencia a evaluar.</param>
        /// <param name="auto">AutoF1 a buscar en la competencia.</param>
        /// <returns>Retorna TRUE si el AutoF1, se encuentra en la competencia.</returns>
        public static bool operator ==(Competencia comp, AutoF1 auto)
        {
            bool retorno = false;
            foreach (AutoF1 item in comp.competidores)
            {
                if(item == auto)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Operador que evalua si el AutoF1 no se encuentra en la Competencia.
        /// </summary>
        /// <param name="comp">Competencia a evaluar.</param>
        /// <param name="auto">AutoF1 a buscar en la competencia.</param>
        /// <returns>Retorna TRUE si el AutoF1, no se encuentra en la competencia.</returns>
        public static bool operator !=(Competencia comp, AutoF1 auto)
        {
            return !(comp == auto);
        }

        /// <summary>
        /// Retorna la informacion de cada competidor de la lista.
        /// </summary>
        /// <returns>Retorna un string, con los datos de cada competidor..</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (AutoF1 item in this.competidores)
            {
                sb.AppendLine("---------------------------------------------");
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }
    }
}
