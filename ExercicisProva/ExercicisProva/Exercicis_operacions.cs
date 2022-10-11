using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicisProva
{
	class Exercicis_operacions
	{

		public static void Exercici1()
		{
			Console.WriteLine("Exercici 1:\n");

			Console.WriteLine("Escriu el primer operant");
			double a = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Escriu el segon operant");
			double b = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Escriu el tercer operant");
			double c = Convert.ToDouble(Console.ReadLine());

			double raizPositiva = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
			double raizNegativa = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

			if (raizNegativa.ToString() == "NaN" || raizPositiva.ToString() == "NaN")
			{
				Console.WriteLine("no real roots");
			}
			else if (raizPositiva != raizNegativa)
			{
				Console.WriteLine("{0:0.00}", raizNegativa);
				Console.WriteLine("{0:0.00}", raizPositiva);
			}
			else
			{
				Console.WriteLine("{0:0.00}", raizPositiva);
			}
		}

		public static void Exercici2()
		{
			Console.WriteLine("\nExercici 2\n");

			double a1 = Convert.ToDouble(Console.ReadLine());
			double b2 = Convert.ToDouble(Console.ReadLine());
			double c3 = Convert.ToDouble(Console.ReadLine());

			double raizPositiva1 = (-b2 + (Math.Sqrt(Math.Pow(b2, 2) - 4 * a1 * c3))) / (2 * a1);
			double raizNegativa1 = (-b2 - (Math.Sqrt(Math.Pow(b2, 2) - 4 * a1 * c3))) / (2 * a1);

			if (raizNegativa1.ToString() == "NaN" || raizPositiva1.ToString() == "NaN")
			{
				Console.WriteLine("no real roots");
			}
			else if (raizPositiva1 != raizNegativa1)
			{
				Console.WriteLine("{0:0.00}", raizNegativa1);
				Console.WriteLine("{0:0.00}", raizPositiva1);
			}
			else
			{
				Console.WriteLine("{0:0.00}", raizPositiva1);
			}
		}
	}
}
