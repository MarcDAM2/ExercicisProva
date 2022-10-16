using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicisProva
{
    class Exercicis_cadenes
    {
		public static void Exercici1()
		{
            Console.WriteLine("Escriu una frase: ");
            string frase = Console.ReadLine();
            string[] fraseParaules = frase.Split(new[] { " " }, StringSplitOptions.None);
            string paraula = "";
            int caracterParaula = 0;
            // Observem cada paraula de la frase que em escrit
            // Llavors comparem la longitud de caractera de cada paraula
            // I com a resultat ens dona la paraula més gran
            foreach (String s in fraseParaules)
            {
                if (s.Length > caracterParaula)
                {
                    paraula = s;
                    caracterParaula = s.Length;
                }
            }

            Console.WriteLine("La paraules més llarga és: " + paraula);
        }

		public static void Exercici2()
		{
            Console.WriteLine("Escriu una paraula o frase: ");
            string paraula = Console.ReadLine();

            string stringReves;
            char[] caracters = paraula.ToCharArray();
            //Fiquem el String al reves
            Array.Reverse(caracters);
            stringReves = new string(caracters);
            //Comparem el string original amb el String al reves
            bool b = paraula.Equals(stringReves);
            if (b == true)
            {
                Console.WriteLine("La paraula/frase: " + paraula + " es un Palindrom!");
            }
            else
            {
                Console.WriteLine("La paraula/frase: " + paraula + " no es un Palindrom!");
            }
        }

		public static void Exercici3()
		{
            Console.WriteLine("Escriu una double: ");
            double num = Convert.ToDouble(Console.ReadLine()); // Agafem el double que ens digui l'usuari
            long m = BitConverter.DoubleToInt64Bits(num); // Convertim el double a un numero binari
            string str = Convert.ToString(m, 2); // el passem a String per imprimir-lo
            Console.WriteLine("El numeró " + num + " en binari és: " + str);
        }
	}
}
