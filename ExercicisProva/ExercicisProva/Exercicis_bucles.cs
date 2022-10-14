using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicisProva
{
	class Exercicis_bucles
	{
		public static void Exercici1()
        {
			Console.WriteLine("Escriu el primer operant: ");
			int numero1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Escriu el segon operant: ");
			int numero2 = Convert.ToInt32(Console.ReadLine());
			int resultat = 0;
			int contador = 0;

			if (numero1<numero2)
			{
				for (contador = numero1; numero1 <= numero2; contador++)
				{
					resultat += contador;

					numero1++;

				}
			}else
			{
				for (contador = numero2; numero2 <= numero1; contador++)
				{
					resultat += contador;

					numero2++;

				}
			}

			Console.WriteLine("Resultat: " + resultat);
        }

		public static void Exercici2()
		{
			Console.WriteLine("Escriu el primer operant: ");
			double numero1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Escriu el segon operant: ");
			double numero2 = Convert.ToInt32(Console.ReadLine());
			double resultat = 0;
			double suma = 0;
			double numeroDividit;
			int numeroFinalInt = 0;

			while (numero1 <= numero2)
            {
				numero1 += numeroFinalInt;

				if (numero1 < numero2)
				{
					Console.WriteLine("Numero actual: " + numero1);
                }
                else
                {
					break;
                }
				numeroDividit = numero1 / 10;

				string numero_string = Convert.ToString(numeroDividit);
				string numeroFinal = numero_string.Split(',')[1];
				numeroFinalInt = Convert.ToInt32(numeroFinal);


				suma += numero1;
				Console.WriteLine("Suma total: " + suma);
			}

		}

		public static void Exercici3()
		{
			Console.WriteLine("");
			int num_maxim = int.Parse(Console.ReadLine());

			int numeros = 1;
			int numerosDoble = 4;

			string capacitatActual = null;

			for (int fila = 1; fila <= num_maxim; fila++)
			{
				capacitatActual = null;
				for (int x = 1; x <= fila; x++)
				{
					if (num_maxim >= numeros)
                    {
						capacitatActual += numeros;
						numeros++;

						if (numeros >= 10)
                        {
							if (capacitatActual.Length.Equals(numerosDoble))
							{
								Console.Write(capacitatActual);
							}
							numerosDoble++;
						}
                        else
                        {
							if (capacitatActual.Length.Equals(fila))
							{
								Console.Write(capacitatActual);
							}
						}
					}
                    else
                    {
						break;
                    }
				}
				Console.WriteLine();
			}
		}
	}
}