using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_1
{

    class Program
    {

        static double Sum(int n, int m)
        {
            int sum = 0;
            for (int i = 1; i <= m; i++)
            {
                sum += i * i * i;

            }

            return sum;

        }
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
                Console.WriteLine("Wynik wyrażenia to " + Sum(n, m));
                return;
            }
            Console.WriteLine("Nieprawidłowa liczba lub znak");
        }
    }
}
