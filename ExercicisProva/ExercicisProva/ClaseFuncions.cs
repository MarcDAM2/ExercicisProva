using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicisProva
{
    internal class ClaseFuncions
    {
        public static void factoritzacio(int numero)
        {

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
                }
                else
                {
                    possibleMultiple++;
                }
                if (numero == 1)
                {
                    break;
                }
            }
        }

        public static void numPrimer(double numero)
        {
            double[] divisors = { 2, 3, 5, 7, 11 };
            double resultat;
            double residu;
            bool esPrimari = true;

            for (int i = 0; i < divisors.Length; i++)
            {

                resultat = numero / divisors[i];
                residu = resultat % 1;
                if (residu == 0)
                {
                    if (numero == divisors[i])
                    {

                    }
                    else
                    {
                        esPrimari = false;
                        break;
                    }
                }
                else
                {
                    esPrimari = true;
                }
            }
            if (esPrimari == false)
            {
                Console.WriteLine(numero + " no es un numero primari");

            }
            else
            {
                Console.WriteLine(numero + " es un numero primari");
            }
        }
    }
}
