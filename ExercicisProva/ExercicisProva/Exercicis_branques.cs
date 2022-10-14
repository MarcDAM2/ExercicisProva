using System;

namespace ExercicisProva
{
    class Exercicis_branques
    {
        public static void Exercici1()
        {
            Console.WriteLine("\nExercici 1:");
            try
            {
                bool is_int = true;
                Console.WriteLine("Escriu un numero");
                double demana = Convert.ToDouble(Console.ReadLine());

                //try
                //{
                //    if ((Convert.ToInt32(demana) % 1) != 0){

                      //  is_int = false;
                   // }
               // } catch(Exception e)
               // {

               // }


                //Per saber si un numero es decimal, si el residu dona diferent a 0,
                // es un numero decimal i si el residu es 0, el numero es un enter
                double residu = demana % 1;

                if (residu == 0)
                {

                    if (demana == 0)
                    {
                        Console.WriteLine(demana + " el numero es un 0");
                    }

                    if (demana > 0)
                    {
                        Console.WriteLine(demana + " es un numero positiu");
                    }
                    if (demana < 0)
                    {
                        Console.WriteLine(demana + " es un numero negatiu");
                    }
                }
                else
                {
                    if (demana > 0)
                    {
                        Console.WriteLine(demana + " es un numero decimal positiu");
                    }
                    else
                    {
                        Console.WriteLine(demana + " es un numero decimal negatiu");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Lo que has escrit no es un numero");
            }
        }

        public static void Exercici2()
        {
            Console.WriteLine("\nExercici 2:");
            try
            {
                Console.WriteLine("Indica la mesura del primer costat del triangle");

                double costat1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Indica la mesura del segon costat del triangle");

                double costat2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Indica la mesura del tercer costat del triangle");

                double costat3 = Convert.ToDouble(Console.ReadLine());
                if (costat1 == costat2 && costat1 == costat3)
                {
                    Console.WriteLine("Es un triangle equilater");
                }
                else if (costat1 == costat2 || costat2 == costat3 || costat1 == costat3)
                {
                    Console.WriteLine("Es un triangle Isoceles");
                }
                else
                {
                    Console.WriteLine("Es un triangle escale");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Lo que has escrit no es un triangle");
            }
        }

        public static void Exercici3()
        {
            Console.WriteLine("\nExercici 3:");

            try
            {
                Console.WriteLine("Escriu un any per saber si es un any de traspàs");

                int any_operant = Convert.ToInt32(Console.ReadLine());

                // Aquesta operació busca el residu de la divisó
                int residu = any_operant % 4;

                if (residu == 0)
                {
                    Console.WriteLine("L'any que has escrit es un any de traspàs");
                }
                else
                {
                    Console.WriteLine("L'any que has escrit no es un any de traspàs");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Lo que has escrit no es un numero");
            }
        }
    }
}
