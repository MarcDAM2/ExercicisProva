using System;
using System.Collections.Generic;
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
		}

		public static void Exercici3()
		{
		}
	}
}
