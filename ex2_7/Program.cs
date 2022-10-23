
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int range_min = 1;
            const int range_max = 10;

            int input_integer = 0;
            Console.Write("Podaj liczbę z przedziału <1,10> do wyliczenia silni: ");

            if (int.TryParse(Console.ReadLine(), out input_integer) && (input_integer >= range_min && input_integer <= range_max))
            {
                uint score = 1;
                for(uint i = score; i <= input_integer; i++)
                {
                    score *= i;
                }

                Console.WriteLine("Wyliczona silnia to: " + score);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba, znak lub liczba wykracza poza zakres <{0},{1}>", range_min, range_max);
            }
        }
    }
}
