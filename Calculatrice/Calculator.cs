using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Calculatrice
    {
        static void Main(string[] args)
        {
            int nombre1, nombre2, choix;
            {
                Console.WriteLine("===== Calculatrice ===== \n Définissez deux nombres entiers. \n Le premier nombre est :");
                nombre1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Le deuxième nombre est :");
                nombre2 = int.Parse(Console.ReadLine());
                Console.Clear();
                do
                {
                    Console.WriteLine("====== Calculatrice ===== \n === Opérations === \n 1. Addition \n 2. Soustraction \n 3. Multiplication \n 4. Division \n 5. Modulo \n 6. Quitter");
                    choix = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (choix)
                    {
                        case 1:
                            Console.WriteLine("Le résultat de l'addition de " + nombre1 + " et de " + nombre2 + " est : " + (nombre1 + nombre2));
                            break;
                        case 2:
                            Console.WriteLine("Le résultat de la soustraction de " + nombre1 + " et de " + nombre2 + " est : " + (nombre1 - nombre2));
                            break;
                        case 3:
                            Console.WriteLine("Le résultat de la multiplication de " + nombre1 + " et de " + nombre2 + " est : " + (nombre1 * nombre2));
                            break;
                        case 4:
                            Console.WriteLine("Le résultat de la division de " + nombre1 + " et de " + nombre2 + " est : " + (nombre1 / nombre2));
                            break;
                        case 5:
                            Console.WriteLine("Le résultat de modulo de " + nombre1 + " et de " + nombre2 + " est : " + (nombre1 % nombre2));
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                    }
                }
                while (choix > 6);
                Console.Read();
            }
        }
	}
}
