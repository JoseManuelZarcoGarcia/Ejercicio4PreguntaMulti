using Ejercicio4PreguntaMulti.Servicios;

namespace Ejercicio4PreguntaMulti.Controladores
{

    class Program
    {

        static void Main(string[] args)
        {
            CalculosInterfaz ci = new CalculosImplementacion();
            SolicitudEIteracionInterfaz si = new SolicitudEIteracionImplementacion();

            bool continuar;
            long numeroMostrar;
            int numeroPedido;

           

            do
            {

              numeroPedido = si.pedirNumero();
               numeroMostrar = ci.calculo( numeroPedido);
               continuar = si.siONo();

            }while (continuar==true);

            

        }

    }

}