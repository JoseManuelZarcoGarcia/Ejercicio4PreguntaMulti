using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4PreguntaMulti.Servicios
{
    internal class SolicitudEIteracionImplementacion : SolicitudEIteracionInterfaz
    {

        public int pedirNumero()
        {
            Console.Write("Escriba un nuemro entero: ");
            int numeroPedido = Convert.ToInt32(Console.ReadLine());
            return numeroPedido;
        }

        public bool siONo() 
        { 
            
            bool continuar = false;
            string s;

            Console.WriteLine("Si desea continuar escriba s, en caso contrario escriba otra cosa ");
            s = Console.ReadLine();          

            if (s == "s")
                continuar = true;
            else
                continuar = false;

            return continuar;

        }

        public void mostrar(long numeroMostrar)
        {

            Console.WriteLine("El resultado es: " + numeroMostrar);
           
        }
       
    }
}
