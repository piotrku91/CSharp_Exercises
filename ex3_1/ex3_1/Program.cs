using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę n: ");
            int n = 0;
            bool validation = int.TryParse(Console.ReadLine(), out n);

            int m = 0;
            Console.WriteLine("Podaj liczbę m: ");
            validation = validation && int.TryParse(Console.ReadLine(), out m);

            if (validation)
            {
                Console.WriteLine("Wynik wyrażenia to " + ((input_a * input_b) / (input_a + input_b)));
                return;
            }
            Console.WriteLine("Nieprawidłowa liczba lub znak");
        }
    }
}
