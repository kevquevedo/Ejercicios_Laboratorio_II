using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;


        private Cantina(int espacios)
        {
            botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }

        public static Cantina GetCantina(int espacios)
        {
            if(Cantina.singleton is null)
            {
                Cantina.singleton = new Cantina(espacios);
            }
            else
            {
                Cantina.singleton.espaciosTotales = espacios;
            }

            return Cantina.singleton;
        }


        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        public static bool operator +(Cantina can, Botella bot)
        {
            bool retorno = false;

            if (can.espaciosTotales > 0)
            {
                can.botellas.Add(bot);
                can.espaciosTotales--;
                retorno = true;
            }

            return retorno;
        } 


    }
}
