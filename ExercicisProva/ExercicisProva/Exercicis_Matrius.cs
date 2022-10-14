using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicisProva
{
	class Exercicis_Matrius
	{
		public static void Exercici1()
		{
			Console.WriteLine("Escriu cinc numeros: ");
			int numero1 = Convert.ToInt32(Console.ReadLine());
			int numero2 = Convert.ToInt32(Console.ReadLine());
			int numero3 = Convert.ToInt32(Console.ReadLine());
			int numero4 = Convert.ToInt32(Console.ReadLine());
			int numero5 = Convert.ToInt32(Console.ReadLine());

			int[] array = { numero1, numero2, numero3, numero4, numero5 };

			Random randNum = new Random();

			array = array.OrderBy(x => randNum.Next()).ToArray();
			Console.WriteLine("Ordre_Aleatori:");
			foreach (var i in array)
			{
				Console.WriteLine(i);
			}
		}

		public static void Exercici2()
		{
			Console.WriteLine("Escriu cinc numeros: ");
			int numero1 = Convert.ToInt32(Console.ReadLine());
			int numero2 = Convert.ToInt32(Console.ReadLine());
			int numero3 = Convert.ToInt32(Console.ReadLine());
			int numero4 = Convert.ToInt32(Console.ReadLine());
			int numero5 = Convert.ToInt32(Console.ReadLine());

			int[] array = { numero1, numero2, numero3, numero4, numero5 };

			Console.WriteLine("Moure cap a Esquerra o Dreta: ");
			string costat = Console.ReadLine();
			int[] arrayMogut = new int[array.Length];
			if (costat.Equals("Dreta"))
			{

				for (int i = 0; i <= array.Length - 2; i++)
				{
					arrayMogut[i + 1] = array[i];
				}

				arrayMogut[0] = array[array.Length - 1];

				for (int y = 0; y < arrayMogut.Length; y++)
				{
					Console.WriteLine("Array moguda cap a la dreta: [" + arrayMogut[y] + "]");
				}
			}

			if (costat.Equals("Esquerra"))
			{


				arrayMogut[4] = array[0];

				for (int i = 0; i < array.Length - 1; i++)
				{
					arrayMogut[i] = array[i + 1];
				}

				for (int y = 0; y < arrayMogut.Length; y++)
				{
					Console.WriteLine("Array moguda cap a l'esquerra: [" + arrayMogut[y] + "]");
				}
			}

		}

		public static void Exercici3()
		{
			Console.WriteLine("Quants numeros vols inserir ");
			int quantitat_num = Convert.ToInt32(Console.ReadLine());

			int llocArray = 0;
			int[] array = new int[quantitat_num];
			int resposta;

			for (int i = 1; i <= quantitat_num; i++)
			{
				Console.WriteLine("Escriu un numero? ");
				resposta = Convert.ToInt32(Console.ReadLine());
				array[llocArray] = resposta;

				llocArray++;
			}

			//Calcular Mitja
			double suma = 0.0;

			for (int f = 0; f < array.Length; f++)
			{
				suma = suma + array[f];
			}
			double resultat_mitja = suma / array.Length;
			Console.WriteLine("Mitja = " + resultat_mitja);

			//Calcular Mitjana
			Array.Sort(array);
			int mitjana;
			//Comprovem si l'array es par
			if ((quantitat_num % 2) == 0)
			{
				int numMitat1 = array.Length / 2;
				int numMitat2 = array[numMitat1 + 1];
				mitjana = (numMitat1 + numMitat2) / 2;
				Console.WriteLine("La mitjana és: " + mitjana);
			}
			else
			{
				int numMitat = array.Length / 2;
				Console.WriteLine(numMitat);
			}

			//Calcular Moda
			int l = 0;
			int numMesRepetit = 0;
			int maxCopsRepetit = 0;
			while (l < array.Length)
			{
				int numCops = 0;
				int j = 0;
				while (j < array.Length)
				{
					if (array[j] == array[l])
					{
						numCops++;
					}

					if (numCops > maxCopsRepetit)
					{
						numMesRepetit = array[l];
						maxCopsRepetit = numCops;
					}
					j++;
				}
				l++;
			}
			Console.WriteLine("El valor més repetit és: " + numMesRepetit + " i s'ha repetit " + maxCopsRepetit + " cops");

		}

		public static void Exercici4()
		{
			int p = 1;
			int[,] matriu1 = new int[3 ,3];
			Console.WriteLine("Escriu 9 numeros que tindra la matriu 1: ");

			for (int i = 0; i < matriu1.GetLength(0); i++)
			{
				// j representa el numero en la posició que estigui la j. Per exemple a la Fila 0, si j val 3, imprimirar el 9.69.
				for (int j = 0; j < matriu1.GetLength(1); j++)
				{
					matriu1 [i, j] = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Valor " + p + ": " + matriu1[i, j] + " ");
					p++;
				}

				Console.WriteLine();
			}

			int[,] matriu2 = new int[3, 3];
			p = 1;
			Console.WriteLine("Escriu 9 numeros que tindra la matriu 2: ");

			for (int i = 0; i < matriu2.GetLength(0); i++)
			{
				// j representa el numero en la posició que estigui la j. Per exemple a la Fila 0, si j val 3, imprimirar el 9.69.
				for (int j = 0; j < matriu2.GetLength(1); j++)
				{
					matriu2[i, j] = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Valor " + p + ": " + matriu2[i, j] + " ");
					p++;
				}

				Console.WriteLine();
			}

			int[,] matriuFinal = new int[3, 3];
			p = 1;
			Console.WriteLine("Els valors sumats de les dos matrius anteriors són: ");
			for (int i = 0; i < matriuFinal.GetLength(0); i++)
			{
				// j representa el numero en la posició que estigui la j. Per exemple a la Fila 0, si j val 3, imprimirar el 9.69.
				for (int j = 0; j < matriuFinal.GetLength(1); j++)
				{
					matriuFinal[i, j] = matriu1[i, j] + matriu2[i, j];
					Console.WriteLine("Valor " + p  + ": " + matriuFinal[i, j] + " ");
					p++;
				}

				Console.WriteLine();
			}
		}
	}
}
