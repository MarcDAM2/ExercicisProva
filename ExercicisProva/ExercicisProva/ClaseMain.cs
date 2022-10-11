using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicisProva
{
    class ClaseMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triar l'apartat d'exercicis que vols\n");
            Console.WriteLine("1. Exercicis Branques");
            Console.WriteLine("2. Exercicis Operacions");
            Console.WriteLine("3. Exercicis Bucles");
            Console.WriteLine("4. Exercicis Matrius");

            int apartat = Convert.ToInt32(Console.ReadLine());


            switch (apartat)
            {
                case 1:
                    ExercicisBranques();
                    break;
                case 2:
                    ExercicisOperacions();
                    break;
                case 3:
                    ExercicisBucles();
                    break;
                case 4:
                    ExercicisMatrius();
                    break;
            }
        }

        static void ExercicisBranques()
        {
            Console.WriteLine("Triar l'exercici que vol probar");
            Console.WriteLine("Exercicis 1");
            Console.WriteLine("Exercicis 2");
            Console.WriteLine("Exercicis 3");
            int exercici = Convert.ToInt32(Console.ReadLine());

            switch (exercici)
            {
                case 1:
                    Exercicis_branques.Exercici1();
                    break;
                case 2:
                    Exercicis_branques.Exercici2();
                    break;
                case 3:
                    Exercicis_branques.Exercici3();
                    break;
            }
        }

        static void ExercicisOperacions()
        {
            Console.WriteLine("Triar l'exercici que vol probar");
            Console.WriteLine("Exercicis 1");
            Console.WriteLine("Exercicis 2");
            int exercici = Convert.ToInt32(Console.ReadLine());

            switch (exercici)
            {
                case 1:
                    Exercicis_operacions.Exercici1();
                    break;
                case 2:
                    Exercicis_operacions.Exercici2();
                    break;
            }
        }

        static void ExercicisBucles()
        {
            Console.WriteLine("Triar l'exercici que vol probar");
            Console.WriteLine("Exercicis 1");
            Console.WriteLine("Exercicis 2");
            Console.WriteLine("Exercicis 3");
            int exercici = Convert.ToInt32(Console.ReadLine());

            switch (exercici)
            {
                case 1:
                    Exercicis_bucles.Exercici1();
                    break;
                case 2:
                    Exercicis_bucles.Exercici2();
                    break;
                case 3:
                    Exercicis_bucles.Exercici3();
                    break;
            }
        }

        static void ExercicisMatrius()
        {
            Console.WriteLine("Triar l'exercici que vol probar");
            Console.WriteLine("Exercicis 1");
            Console.WriteLine("Exercicis 2");
            Console.WriteLine("Exercicis 3");
            Console.WriteLine("Exercicis 4");
            int exercici = Convert.ToInt32(Console.ReadLine());

            switch (exercici)
            {
                case 1:
                    Exercicis_Matrius.Exercici1();
                    break;
                case 2:
                    Exercicis_Matrius.Exercici2();
                    break;
                case 3:
                    Exercicis_Matrius.Exercici3();
                    break;
                case 4:
                    Exercicis_Matrius.Exercici4();
                    break;
            }
        }
    }
}
