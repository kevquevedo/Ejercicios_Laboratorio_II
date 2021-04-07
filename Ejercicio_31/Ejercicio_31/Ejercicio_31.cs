using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_31
{
    class Ejercicio_31
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 31";

            Negocio negocioKevin = new Negocio("Kevin Lista");

            negocioKevin.Cliente = new Cliente(23232323, "Kevin");
            negocioKevin.Cliente = new Cliente(34343434, "Agustina");
            negocioKevin.Cliente = new Cliente(45454545, "German");
            negocioKevin.Cliente = new Cliente(56565656, "Dardo");
            negocioKevin.Cliente = new Cliente(67676767, "Elizabeth");
            Console.WriteLine($"Cantidad de clientes pendientes: {negocioKevin.ClientesPendientes}");

            Console.WriteLine("----------------------------------------------------------------");
            PuestoAtencion puestoUno = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            bool v = ~negocioKevin;
            Console.WriteLine($"Cantidad de clientes pendientes: {negocioKevin.ClientesPendientes}");

            Console.WriteLine("----------------------------------------------------------------");
            PuestoAtencion puestoDos = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            bool v2 = ~negocioKevin;
            Console.WriteLine($"Cantidad de clientes pendientes: {negocioKevin.ClientesPendientes}");

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Cantidad de Clientes atendidos: {PuestoAtencion.NumeroActual}");
            Console.ReadKey();
        }
    }
}
