using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_8
{
    class Program
    {
        static void DrawRectangle(uint size_a, uint size_b)
        {
            for (uint lines = 0; lines < size_a; lines++)
            {
                for (uint columns = 0; columns < size_b; columns++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }


        static void Main(string[] args)
        {
            uint input_a = 0;
            uint input_b = 0;

            Console.Write("Podaj wymiar a prostokąta: ");
            bool validation = uint.TryParse(Console.ReadLine(), out input_a);

            Console.Write("Podaj wymiar b prostokąta: ");
            validation = validation && uint.TryParse(Console.ReadLine(), out input_b);

            if (validation)
            {
                DrawRectangle(input_a, input_b);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba lub znak");
            }

            Console.ReadKey();
        }
    }
}
