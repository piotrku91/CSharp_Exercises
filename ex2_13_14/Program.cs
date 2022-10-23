
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_13_14
{
    class Program
    {
        static int NWD(int lhs, int rhs)
        {
            if (lhs < 0)
                lhs = Math.Abs(lhs);
            if (rhs < 0)
                rhs = Math.Abs(rhs);
            while (rhs != 0)
            {
                int rkeeper = rhs;
                rhs = lhs % rhs;
                lhs = rkeeper;
            };
            return lhs;
        }

        static int NWW(int lhs, int rhs)
        {
            return (lhs == 0 || rhs == 0) ? 0 : Math.Abs(lhs * rhs) / NWD(lhs, rhs);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę a: ");
            int input_a = 0;
            bool validation = int.TryParse(Console.ReadLine(), out input_a);

            int input_b = 0;
            Console.WriteLine("Podaj liczbę b: ");
            validation = validation && int.TryParse(Console.ReadLine(), out input_b);

            if (validation)
            {
                Console.WriteLine("NWD = " + NWD(input_a, input_b));
                Console.WriteLine("NWW = " + NWW(input_a, input_b));
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
