using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        /// <summary>
        /// Constructor privado que inicializa la cola de clientes y la caja de atencion.
        /// </summary>
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        /// <summary>
        /// Constructor publico que inicializa el nombre segun el parametro brindado.
        /// </summary>
        /// <param name="nombre">Nombre a asignar al Negocio.</param>
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Propiedad que retorna el numero de clientes pendientes de la cola.
        /// </summary>
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }

        /// <summary>
        /// Propiedad que en su GET, retorna y elimina a un cliente de la cola.
        /// Propiedad que en su SET, agrega un cliente a la cola, si es que no existe.
        /// </summary>
        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();//Retorno y elimino un cliente de la cola. FIFO.
            }
            set
            {
                if(this != value)//Valido que el cliente (value) no exista en el Negocio (this).
                {
                    this.clientes.Enqueue(value);//Si no existe, lo agrego a la cola.
                }
            }
        }

        /// <summary>
        /// Valida que el Cliente exista en la cola del Negocio.
        /// </summary>
        /// <param name="negocio">Negocio en donde buscar el cliente.</param>
        /// <param name="cliente">Cliente a buscar.</param>
        /// <returns>Retorna TRUE, si el cliente ya existe en la cola del Negocio.</returns>
        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            bool retorno = false;
            //Recorro la cola de clientes, verificando si el cliente brindado por parametro existe.
            foreach (Cliente cliQueue in negocio.clientes)
            {
                //Si existe devuelvo TRUE y rompo el foreach.
                if (cliQueue == cliente)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Valida que el Cliente NO exista en la cola del Negocio.
        /// </summary>
        /// <param name="negocio">Negocio en donde buscar el cliente.</param>
        /// <param name="cliente">Cliente a buscar.</param>
        /// <returns>Retorna TRUE, si el cliente NO existe en la cola del Negocio.</returns>
        public static bool operator !=(Negocio negocio , Cliente cliente)
        {
            return !(negocio == cliente);
        }

        /// <summary>
        /// Atiende por la caja asignada al cliente, eliminandolo de la cola.
        /// </summary>
        /// <param name="negocio">Negocio, sobre el cual trabajar.</param>
        /// <returns>Retorno TRUE, si puede atender y por ende eliminar de la cola al Cliente.</returns>
        public static bool operator ~(Negocio negocio)
        {
            bool retorno = false;
            //Obtengo al cliente eliminandolo de la cola mediante la prop Cliente: "negocio.Cliente".
            //Lo atiendo por la caja.
            if (negocio.caja.Atender(negocio.Cliente))
            {
                retorno = true;//Si todo sale bien, devuelvo TRUE;
            }
            return retorno;
        }

        /// <summary>
        /// Suma un cliente a la cola, si es que el mismo no existe en el negocio.
        /// </summary>
        /// <param name="negocio">Negocio a validar que el cliente no exista.</param>
        /// <param name="cliente">Cliente a buscar en la cola del negocio.</param>
        /// <returns></returns>
        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            bool retorno = false;
            if (negocio != cliente)//Valido que el cliente no exista en la cola del negocio.
            {
                negocio.clientes.Enqueue(cliente);//Si no existe, lo agrego.
                retorno = true;
            }
            return retorno;
        }


    }
}
