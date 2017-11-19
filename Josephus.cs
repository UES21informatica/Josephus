using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josephus
{
    class Josephus
    {
        public int[] josephusItera(int personas, int k)
        {
            //inicializar el circulo con todas las personas vivas representadas con 1
            int[] circulo = new int[personas];
            for (int i = 0; i < personas; i++)
            {
                circulo[i] = 1;
            }

            //Comienza el juego
            int indice = 0;
            while (personas > 1)
            {
                for (int i = 0; i < k; i++)
                {
                    // Arreglo circular
                    if (indice > circulo.Length - 1)
                    {
                        indice = 0;
                    }

                    // Salto soldados muertos
                    while (circulo[indice] == 0)
                    {
                        indice++;
                        if (indice > circulo.Length - 1)
                        {
                            indice = 0;
                        }
                    }

                    // Avanzo una posicion del salto.
                    indice++;
                    DibujarArreglo(circulo, indice - 1, i);
                    System.Threading.Thread.Sleep(500);

                }
                //Mato al soldado
                circulo[indice - 1] = 0;
                personas--;
                DibujarArreglo(circulo, indice - 1, 9999);
                System.Threading.Thread.Sleep(1000);
            }
            return circulo;
        }

        internal void DibujarArreglo(int[] circulo)
        {
            DibujarArreglo(circulo, 99999, 0);
        }

        public void imprimirTitulo()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("|                            Josephus Problem                               |");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.ResetColor();
        }



        private void DibujarArreglo(int[] circulo, int indice, int apunta)
        {

            Console.Clear();
            imprimirTitulo();
            Console.SetCursorPosition(0, 4);

            String texto;

            for (int i = 0; i < circulo.Length; i++)
            {
                if (indice == i  && apunta == 9999)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    texto = "<- Disparando";
                }
                else
                if (indice == i)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    texto = "<- Apuntando " + (apunta + 1);
                }
                else if (circulo[i] == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    texto = "";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    texto = "<- Muerto    ";
                }

                Console.WriteLine("[" + i + "] = " + circulo[i] + "  " + texto);

            }
            Console.ResetColor();



        }
    }
}
