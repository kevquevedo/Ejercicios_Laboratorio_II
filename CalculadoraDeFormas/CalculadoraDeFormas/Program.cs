using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace CalculadoraDeFormas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de Formas";

            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Circulo(4));
            figuras.Add(new Cuadrado(3));
            figuras.Add(new Rectangulo(3,4));


            foreach (Figura item in figuras)
            {
                Console.WriteLine($"==============Figura: {figuras.IndexOf(item) + 1:00}======================");
                Console.WriteLine($"Tipo: {item.GetType()}");
                Console.WriteLine($"{item.Dibujar()}");
                Console.WriteLine($"Area: {item.CalcularSuperficie():0.00}");
                Console.WriteLine($"Perimetro: {item.CalcularPerimetro():0.00}");
                Console.WriteLine("============================================");
                Console.WriteLine("");
            }

            //8 - A: No esta obligado, porque en la clase Padre "Figura" es virtual. 
            //       Las otras clases tampoco estan obligadas.
            //8 - B: No esta obligado por la hereda de Rectangulo. 
            //       Las clases derivadas directamente de Figura, si estan obligadas porque es abstract.
            //8 - C: Llaman a la implementacion de CalcularPerimetro de Rectangulo.


            Console.ReadKey();
        }
    }
}
