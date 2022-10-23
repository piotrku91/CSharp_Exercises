
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_12
{
    class Program
    {
        static bool IsPrimeNumber(uint number)
        {
            uint temp = 0;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    temp++;
                }
            }

            if (temp == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            uint input_a = 0;
            Console.Write("Podaj liczbę: ");

            if (uint.TryParse(Console.ReadLine(), out input_a))
            {
                if (IsPrimeNumber(input_a))
                {
                    Console.WriteLine("Podana liczba jest liczbą pierwszą");
                }
                else
                {
                    Console.WriteLine("Podana liczba nie jest liczbą pierwszą");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }
        }
    }
}
