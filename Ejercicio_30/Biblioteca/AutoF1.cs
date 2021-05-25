using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private int numero;
        private short vueltasRestantes;

        /// <summary>
        /// Constructor privado que inicializa los atributos cantidad de combustible, vueltas restantes y si se encuentra en competencia.
        /// </summary>
        private AutoF1()
        {
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.enCompetencia = false;
        }

        /// <summary>
        /// Constructor publico que iniciliaza los atributos de un Auto F1, recibiendo su numero y escuderia.
        /// </summary>
        /// <param name="numero">Numero a asignar al AutoF1.</param>
        /// <param name="escuderia">Escuderia a asignar al AutoF1.</param>
        public AutoF1(short numero, string escuderia) : this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        /// <summary>
        /// Evalua si los argumentos del tipo AutoF1 son iguales.
        /// </summary>
        /// <param name="auto1">Primer argumento del tipo AutoF1.</param>
        /// <param name="auto2">Segundo argumento del tipo AutoF1.</param>
        /// <returns>Retorna TRUE, en caso de que los AutoF1 sean iguales.</returns>
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            bool retorno = false;
            if( (auto1.numero==auto2.numero) && (auto1.escuderia == auto2.escuderia) )
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Evalua si los argumentos del tipo AutoF1 son distintos.
        /// </summary>
        /// <param name="auto1">Primer argumento del tipo AutoF1.</param>
        /// <param name="auto2">Segundo argumento del tipo AutoF1.</param>
        /// <returns>Retorna TRUE, en caso de que los AutoF1 sean distintos.</returns>
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }

        /// <summary>
        /// Propiedad sobre Cantidad de Combutible
        /// </summary>
        public short SetCantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        /// <summary>
        /// Propiedad sobre el estado en Competencia.
        /// </summary>
        public bool SetEnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        /// <summary>
        /// Propiedad sobre las Vueltas Restantes.
        /// </summary>
        public short SetVueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        /// <summary>
        /// Retorna la informacion de un AutoF1.
        /// </summary>
        /// <returns>Retorna un string, con los datos del AutoF1.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"Cantidad de Combustible: {this.SetCantidadCombustible}");
            sb.AppendLine($"Vueltas Restantes: {this.SetVueltasRestantes}");
            if (this.SetEnCompetencia)
            {
                sb.AppendLine("Se encuentra en competencia.");
            }
            else
            {
                sb.AppendLine("No se encuentra en competencia.");
            }
            return sb.ToString();
        }


    }
}
