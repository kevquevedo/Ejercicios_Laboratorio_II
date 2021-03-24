using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_Clase_03
{
    class Principal
    {
        static void Main(string[] args)
        {
            //CLIENTE 1
            Mascota mascota1 = new Mascota("Fatiga","Perro", new DateTime(2018, 06, 23));
            Cliente cliente1 = new Cliente("Kevin", "Quevedo", "Av.Mosconi 1234", 1145454545);
            cliente1.AgregarMascota(mascota1);

            //CLIENTE 2
            Mascota mascota2 = new Mascota("Miau", "Gato", new DateTime(2020, 10, 15));
            Vacuna vacuna1 = new Vacuna("Triple Felina");
            mascota2.AgregarVacuna(vacuna1);
            Cliente cliente2 = new Cliente("Roberto", "Carlos", "Av.Rivadavia 8585", 1156565656);
            cliente2.AgregarMascota(mascota2);

            //CLIENTE 3
            Mascota mascota3 = new Mascota("Mimi", "Gato", new DateTime(2017, 01, 01));
            Mascota mascota4 = new Mascota("Thor", "Perro", new DateTime(2019, 07, 29));
            Vacuna vacuna2 = new Vacuna("Rabia Vaccune");
            mascota4.AgregarVacuna(vacuna2);
            Cliente cliente3 = new Cliente("Gimena", "Garcia", "Av.Libertador 1212", 1175757575);
            cliente3.AgregarMascota(mascota3);
            cliente3.AgregarMascota(mascota4);

            //DATOS EN CONSOLA
            Console.WriteLine(cliente1.ObtenerDatos());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(cliente2.ObtenerDatos());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(cliente3.ObtenerDatos());
            Console.ReadKey();
        }
    }
}
