using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo : Figura
    {
        private double basex;
        private double altura;

        public Rectangulo(double basex, double altura)
        {
            this.basex = basex;
            this.altura = altura;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo...";
        }

        public override double CalcularSuperficie()
        {
            return basex * altura;
        }

        public override double CalcularPerimetro()
        {
            return (basex * 2) + (altura * 2);
        }

    }
}
