using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4PreguntaMulti.Servicios
{
    internal class CalculosImplementacion : CalculosInterfaz
    {

        public long calculo ( int numeroPedido)
        {

            long numeroMostrar = 1;

            for (int i = 2; i <= numeroPedido; i++)
            {
                numeroMostrar = numeroMostrar * i;

            }
            Console.WriteLine(numeroMostrar);
            return numeroMostrar;
        }
        


    }
}
