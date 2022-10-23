
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą: ");
            int input_integer = 0;
        
            if(int.TryParse(Console.ReadLine(), out input_integer))
            {
                Console.WriteLine("Podana liczba jest " + ((input_integer % 2 == 0)?"parzysta":"nie parzysta"));
            } else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }
        }
    }
}
