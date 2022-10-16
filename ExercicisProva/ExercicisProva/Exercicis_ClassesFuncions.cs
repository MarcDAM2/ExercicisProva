using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicisProva
{
    internal class Exercicis_ClassesFuncions
    {
        public static void Exercici1()
        {
            Console.WriteLine("Exercici 1:\n");

            Console.WriteLine("Escriu un numerò: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int bucle = 999;
            int num_multiple = 1;
            int possibleMultiple = 2;

            Console.WriteLine("Factoritzatció del numerò: " + numero);
            for (int i = 0; numero < bucle; i++)
            {
                // Aquesta operació busca el residu de la divisó
                int residu = numero % possibleMultiple;
                if (residu == 0)
                {
                    // num2 serà els seguents numeros divits
                    int num2 = numero / possibleMultiple;
                    numero = num2;

                    Console.WriteLine("Múltiple " + num_multiple + ": " + possibleMultiple);
                    num_multiple++;
                }else
                {
                    possibleMultiple++;
                }
                if (numero == 1)
                {
                    break;
                }
            }
        }
        public static void Exercici2()
        {
            Console.WriteLine("Exercici 2:\n");

            Console.WriteLine("Escriu un numerò: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            ClaseFuncions.factoritzacio(numero);
        }

        public static void Exercici3()
        {
            Console.WriteLine("Exercici 3:\n");

            Console.WriteLine("Escriu un numerò: ");
            double numero = Convert.ToInt32(Console.ReadLine());
            ClaseFuncions.numPrimer(numero);
        }
    }
}
