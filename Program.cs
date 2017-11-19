using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josephus
{
    class Program
    {
        static void Main(string[] args)
        {
            Josephus josephus = new Josephus();

            josephus.imprimirTitulo();
            String input = "";
            while (!Int32.TryParse(input, out int num))
            {
                Console.Write("Ingrese cantidad de personas: ");
                input = Console.ReadLine();
            }


            
            // Asigno cantidad de personas en el circulo
            int personas = Convert.ToInt32(input);

            input = "";
            while (!Int32.TryParse(input, out int num))
            {
                Console.Write("Ingrese salto: ");
                input = Console.ReadLine();
            }
            // Asigno tamaño del salto
            int k = Convert.ToInt32(input);


           
            int[] circulo = josephus.josephusItera(personas, k);

            josephus.DibujarArreglo(circulo);

            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();
        }

       

    }
}
