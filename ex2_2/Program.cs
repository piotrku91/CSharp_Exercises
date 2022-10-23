
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę całkowitą: ");
            int input_first_integer = 0;
            bool validation = int.TryParse(Console.ReadLine(), out input_first_integer);

            int input_second_integer = 0;
            Console.WriteLine("Podaj liczbę całkowitą (oczekiwany dzielnik pierwszej podanej liczby): ");
            validation = validation && int.TryParse(Console.ReadLine(), out input_second_integer);

            if (validation)
            {
                Console.WriteLine("Podana liczba " + (input_first_integer % input_second_integer == 0 ? "jest" : "nie jest") + " dzielnikiem liczby " + input_first_integer);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }
        }
    }
}