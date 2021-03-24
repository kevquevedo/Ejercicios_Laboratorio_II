using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private DateTime fechaNacimiento;
        private Vacuna[] vacunas;

        public Mascota(string nombre, string especie, DateTime fechaNac)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNacimiento = fechaNac;
        }
        public void AgregarVacuna(Vacuna nomVacunne)
        {
            //Si la mascota no tiene ninguna vacuna entra al IF.
            if (this.vacunas is null)
            {
                //Si no tiene, reservo memoria para 1 vacuna.
                this.vacunas = new Vacuna[1];
            }
            else
            {
                int newCapacity = this.vacunas.Length + 1; //En newCap sumo 1, a la capacidad actual del Array.
                Array.Resize(ref this.vacunas, newCapacity); //Aumento la capacidad del Array.
            }

            //Recorro el Array, para buscar un lugar donde "dejar" la vacuna.
            for (int i = 0; i < this.vacunas.Length; i++) //Recorro hasta la longitud del Array.
            {
                if (this.vacunas[i] is null) //Si el espacio en el array esta vacio,
                {                            // le grabo el nombre y salgo (break).
                    this.vacunas[0] = nomVacunne;
                    break;
                }
            }
        }

        public string ObtenerDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Nombre Mascota: {this.nombre}");
            retorno.AppendLine($"Especie: {this.especie}");    //El Short Date, me permite solo mostrar fecha.
            retorno.AppendLine($"Fecha Nacimiento Mascota: {this.fechaNacimiento.ToShortDateString()}");

            //Si el Array de vacunas contiene info, entra al IF.
            if (this.vacunas != null)
            {
                retorno.Append("Historial de Vacunacion: ");
                foreach (Vacuna vacuna in vacunas)//Recorro el array y "extraigo" cada Vac y las trato 
                {                                 // individualmente.-
                    if (vacuna != null) //Si no es nula, imprimo el nombre de la vacuna.
                    {
                        retorno.Append($"{vacuna.NombreVacuna()}");
                    }
                }
            }
            return retorno.ToString(); //Retorno la construccion del String.
        }
    }
}
