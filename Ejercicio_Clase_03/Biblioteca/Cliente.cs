using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private double telefono;
        private Mascota[] mascotas;

        public Cliente(string nombre, string apellido, string domicilio, double telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }

        public void AgregarMascota(Mascota mascota)
        {
            if(this.mascotas is null) //Si el cliente no tiene ninguna mascota entra al IF.
            {
                this.mascotas = new Mascota[1]; //Si no tiene, reservo memoria para 1 mascota.
            }
            else
            {
                int newCapac = this.mascotas.Length + 1; //En newCap sumo 1, a la capacidad actual del Array.
                Array.Resize(ref this.mascotas, newCapac); //Aumento la capacidad del Array.
            }

            //Recorro el Array, para buscar un lugar donde "dejar" la mascota.
            for (int i = 0; i < this.mascotas.Length; i++)
            {
                if (this.mascotas[i] is null)
                {
                    this.mascotas[i] = mascota;
                    break;
                }
            }
        }

        public string ObtenerDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Nombre: {this.nombre}");
            retorno.AppendLine($"Apellido: {this.apellido}");
            retorno.AppendLine($"Domicilio: {this.domicilio}");
            retorno.AppendLine($"Telefono: {this.telefono}");

            //Si el Array de mascotas contiene info, entra al IF.
            if (this.mascotas != null)
            {
                retorno.AppendLine("Mascotas: ");
                foreach (Mascota mascota in mascotas)//Recorro el array y "extraigo" cada Masc y las trato 
                {                                    // individualmente.-
                    if (mascota != null)//Si no es nula, imprimo el nombre de la mascota.
                    {
                        retorno.Append(mascota.ObtenerDatos());
                    }
                }
            }
            return retorno.ToString(); //Retorno la construccion del String.
        }
    }
}
