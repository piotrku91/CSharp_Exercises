using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kradwat
{
    class Program
    {
        static double countDelta(double a, double b, double c)
        {
            return (b * b) - 4 * a * c;
        }

        static void Main(string[] args)
        {
            while(true)
            {
                string split_line = "----------------------------------------------";
                Console.WriteLine(split_line);
                Console.WriteLine("Obliczanie rozwiązań rownania funkcji kwadratowej");
                Console.WriteLine(split_line);

                double factor_a = 0;
                double factor_b = 0;
                double factor_c = 0;

                while (true) // Infinite loop till get valid data
                {
                    Console.WriteLine("Podaj współczynik a:");
                    string input_a = Console.ReadLine();
                    Console.WriteLine("Podaj współczynik b:");
                    string input_b = Console.ReadLine();
                    Console.WriteLine("Podaj współczynik c:");
                    string input_c = Console.ReadLine();

                    /* Converts format . to , */
                    input_a = input_a.Replace('.', ',');
                    input_b = input_b.Replace('.', ',');
                    input_c = input_c.Replace('.', ',');

                    if (Double.TryParse(input_a, out factor_a) && Double.TryParse(input_b, out factor_b) && Double.TryParse(input_c, out factor_c))
                    {
                        break;
                    }
                    Console.WriteLine("Jeden z parametrów nie jest liczbą lub zawiera niedozwolone znaki. Spróbuj ponownie...\n");
                }

                double delta = countDelta(factor_a, factor_b, factor_c);
                Console.WriteLine("\n\nDelta równania to: " + delta);

                if (delta > 0)
                {
                    Console.WriteLine("Równanie ma dwa rozwiązania:");
                    double x1 = (-factor_b - Math.Sqrt(delta)) / (2 * factor_a);
                    double x2 = (-factor_b + Math.Sqrt(delta)) / (2 * factor_a);
                    Console.WriteLine("x1= " + x1 +" x2=" + x2);

                } else if (delta == 0)
                {
                    Console.WriteLine("Równanie ma jedno rozwiązanie:");
                    double x = -factor_b / (2 * factor_a);
                    Console.WriteLine("x= " + x);
                } else if (delta < 0)
                {
                    Console.WriteLine("Takie równanie nie ma rozwiązań");
                }

                Console.WriteLine(split_line);
                Console.WriteLine("\n\n");

            }
        }
    }
}
