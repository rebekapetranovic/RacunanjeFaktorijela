using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktorijele_2
{
    class Program
        
    {
        /// <summary>
        /// RACUNANJE FAKTORIJELA NA TRI NACINA
        /// </summary>
        static void Main()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Dobrodošli u program za računanje faktorijela.\nOdaberite način na koji želite izračunati faktorijele: \n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n'a' - Klasična formula (for petlja)");
            Console.WriteLine("'b' - Rekurzija");
            Console.WriteLine("'c' - Stirlingova formula\n");

            Console.Write("Upišite slovo: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            char odabir = char.Parse(Console.ReadLine());

            if (odabir == 'a')
            {
                Console.Write("\nUpišite broj faktorijela: ");
                int br = int.Parse(Console.ReadLine());
                double rez = 1;

                for (int i = 1; i <= br; i++)
                {
                    rez = rez * i;
                }
                Console.WriteLine("Faktorijela broja {0} izračunata for petljom: {1}\n", br, rez);
            }


            else if (odabir == 'b')
            {
                Console.Write("\nUpišite broj faktorijela: ");
                int br = int.Parse(Console.ReadLine());
                double Rek = Rekurzija(br);
                Console.WriteLine("Faktorijela broja {0} izračunata rekurzijom: {1}\n", br, Rek);

            }

            else if (odabir == 'c')
            {
                Console.Write("\nUpišite broj faktorijela: ");
                int br = int.Parse(Console.ReadLine());
                double Rek = StirlingovaFormula(br);
                Console.WriteLine("Faktorijela broja {0} izračunata Stirlingovom formulom: {1}", br, Rek);

                double Rek2 = Rekurzija(br);
                Console.WriteLine("Razlika stvarnog rezultata i rezultata Stirlingove formule : {0}\n", Rek2 - Rek);
            }

            else
            {
                Console.WriteLine("\nUpisali ste pogrešno slovo!\n");
            }
        }
        static double StirlingovaFormula(int broj)
        {
            return Math.Sqrt(2 * Math.PI * broj) * (Math.Pow(broj / Math.E, broj));
        }

        static long Rekurzija(int broj)
        {
            if (broj == 0)
            {
                return 1;
            }
            return broj * Rekurzija(broj - 1);
        }

    }
}