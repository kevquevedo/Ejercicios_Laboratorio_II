using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        /// <summary>
        /// Enumerador de las Cajas del Puesto.
        /// </summary>
        public enum Puesto
        {
            Caja1,
            Caja2
        }

        /// <summary>
        /// Constructor privado que inicializa el atributo numeroActual.
        /// </summary>
        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        /// <summary>
        /// Constructor publico que inicializa el atributo puesto del Puesto de Atencion.
        /// </summary>
        /// <param name="puesto">Puesto/Caja a asignar al Puesto de Atencion.</param>
        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }

        /// <summary>
        /// Atiende a un cliente de la cola del negocio.
        /// </summary>
        /// <param name="cliente">Cliente de la cola a atender.</param>
        /// <returns>Retorna TRUE, si lo pudo atender correctamente.</returns>
        public bool Atender(Cliente cliente)
        {
            Thread.Sleep(5000);//Delay de espera.
            //Incremento el numeroActual, ya que es un cliente que paso por un puesto. 
            int valor = PuestoAtencion.NumeroActual;
            return true;//Devuelvo TRUE.
        }

        /// <summary>
        /// Propiedad estatica que devuelve el numero actual incrementandolo en 1.
        /// </summary>
        public static int NumeroActual
        {
            get
            {
                return numeroActual++;
            }
        }


    }
}
