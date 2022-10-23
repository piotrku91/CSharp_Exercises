
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
            Console.WriteLine("Podaj liczbę a: ");
            float input_a = 0;
            bool validation = float.TryParse(Console.ReadLine(), out input_a);

            float input_b = 0;
            Console.WriteLine("Podaj liczbę b: ");
            validation = validation && float.TryParse(Console.ReadLine(), out input_b);

            if (validation)
            {

                Console.WriteLine("Wynik wyrażenia to " + ((input_a * input_b) / (input_a + input_b)));
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }
        }
    }
}